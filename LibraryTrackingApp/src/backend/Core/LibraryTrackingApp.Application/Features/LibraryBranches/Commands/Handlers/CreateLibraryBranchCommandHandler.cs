using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Requests;
using LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Commands.Handlers;

public class CreateLibraryBranchCommandHandler : IRequestHandler<CreateLibraryBranchCommandRequest, CreateLibraryBranchCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    //private readonly IMapper _mapper;
    public CreateLibraryBranchCommandHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<CreateLibraryBranchCommandResponse> Handle(CreateLibraryBranchCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var existingLibraryBranch = await _unitOfWork.GetReadRepository<Domain.Entities.Library.LibraryBranch>()
                .ExistsAsync(b => b.PhoneNumber == request.PhoneNumber);

            if (existingLibraryBranch)
            {
                return new()
                {
                    StatusCode = 409,
                    Success = false,
                    StateMessages = new string[] { "Bu Telefon numarasına ait  bir şube zaten mevcut." }
                };
            }

            var newLibraryBranch = new Domain.Entities.Library.LibraryBranch()
            {
                Name = request.Name,
                Description = request.Description,
                Address = request.Address,
                PhoneNumber = request.PhoneNumber,
                IsDeleted = false,
                DeletedDate = null,
                CreatedBy = "test-user",//staff name olucak ilerde
                LastModifiedBy = "test-user",//staff name olucak ilerde
                LastModifiedDate = DateTime.Now,
                CreatedDate = DateTime.Now,
            };

            var libraryBranchDto = new LibraryBranchDTO()
            {

            };



            var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.LibraryBranch>();
            bool isAdded = await writeRepository.AddAsync(newLibraryBranch);

            if (isAdded)
            {
                return new()
                {
                    StatusCode = 200,
                    Success = true,
                    StateMessages = new string[] { "Şube başarıyla eklendi." },

                };
            }
            else
            {

                return new()
                {
                    StatusCode = 400,
                    Success = false,
                    StateMessages = new string[] { "Şube eklenirken bir hata oluştu." }
                };
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
