using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Requests;
using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Domain.Entities;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Handlers;

public class UpdateLibraryBranchCommandHandler
    : IRequestHandler<UpdateLibraryBranchCommandRequest, UpdateLibraryBranchCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;

    //private readonly IMapper _mapper;
    public UpdateLibraryBranchCommandHandler(
        IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/
        ,
        IMediator mediator
    )
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<UpdateLibraryBranchCommandResponse> Handle(
        UpdateLibraryBranchCommandRequest request,
        CancellationToken cancellationToken
    )
    {
        try
        {
            var readRepository =
                _unitOfWork.GetReadRepository<Domain.Entities.Library.LibraryBranch>();

            var existingLibraryBranch = await readRepository.GetSingleAsync(
                s => s.Id == request.UpdatedId
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

                existingLibraryBranch.Name = request.Name;
                existingLibraryBranch.Description = request.Description;
                existingLibraryBranch.Address = request.Address;
                existingLibraryBranch.PhoneNumber = request.PhoneNumber;
                existingLibraryBranch.LastModifiedById = Guid.NewGuid(); //staff name olucak ilerde hata almasın diye new guid
                existingLibraryBranch.LastModifiedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now);

             
                bool isUpdated = await writeRepository.UpdateAsync(existingLibraryBranch);

                if (isUpdated)
                {
                    return new()
                    {
                        StatusCode = 200,
                        Success = true,
                        StateMessages = new string[] { "Şube başarıyla güncellendi." }
                    };
                }
                else
                {
                    return new()
                    {
                        StatusCode = 400,
                        Success = false,
                        StateMessages = new string[] { "Şube güncellenirken bir hata oluştu." }
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
                StateMessages = new string[] { $"Bir hata oluştu: {ex.Message}" }
            };
        }
    }
}
