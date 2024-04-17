using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Requests;
using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Handlers;

public class DeleteLibraryBranchCommandHandler
    : IRequestHandler<DeleteLibraryBranchCommandRequest, DeleteLibraryBranchCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;

    //private readonly IMapper _mapper;
    public DeleteLibraryBranchCommandHandler(
        IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/
        ,
        IMediator mediator
    )
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<DeleteLibraryBranchCommandResponse> Handle(
        DeleteLibraryBranchCommandRequest request,
        CancellationToken cancellationToken
    )
    {
        try
        {
            var readRepository =
                _unitOfWork.GetReadRepository<Domain.Entities.Library.LibraryBranch>();

            Guid bookId;
            bool isGuid = Guid.TryParse(request.Id, out bookId);

            var existingLibraryBranch = await readRepository.GetSingleAsync(
                s => isGuid && s.Id == bookId
            );

            if (existingLibraryBranch == null)
            {
                return new()
                {
                    StatusCode = 404,
                    Success = false,
                    StateMessages = new string[] { "Böyle bir şube bulunamadı" }
                };
            }
            else
            {
                var writeRepository =
                    _unitOfWork.GetWriteRepository<Domain.Entities.Library.LibraryBranch>();
                bool isDeleted = await writeRepository.DeleteAsync(existingLibraryBranch);
                if (isDeleted)
                {
                    return new()
                    {
                        StatusCode = 200,
                        Success = true,
                        StateMessages = new string[] { "Şube başarıyla silindi." }
                    };
                }
                else
                {
                    return new()
                    {
                        StatusCode = 400,
                        Success = false,
                        StateMessages = new string[] { "Şube silinirken bir hata oluştu." }
                    };
                }
            }
        }
        catch (Exception ex)
        {
            return new()
            {
                StatusCode = 500,
                Success = false,
                StateMessages = new string[] { $"Şube silinirken bir hata oluştu: {ex.Message}" }
            };
        }
    }
}
