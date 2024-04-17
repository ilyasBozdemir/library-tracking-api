using LibraryTrackingApp.Application.Features.Authors.Queries.Requests;
using LibraryTrackingApp.Application.Features.Authors.Queries.Responses;
using LibraryTrackingApp.Application.Features.LibraryBranches.Queries.Requests;
using LibraryTrackingApp.Application.Features.LibraryBranches.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Domain.Entities.Library;
using System.Net;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Queries.Handlers;

public class GetLibraryBranchQueryHandler : IRequestHandler<GetLibraryBranchQueryRequest, GetLibraryBranchQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    public GetLibraryBranchQueryHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }
    public async Task<GetLibraryBranchQueryResponse> Handle(GetLibraryBranchQueryRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var readRepository = _unitOfWork
                .GetReadRepository<Domain.Entities.Library.LibraryBranch>();


            var existingLibraryBranch = await
                readRepository
                .ExistsAsync(b => b.Id == request.LibraryBranchId);

            if (!existingLibraryBranch)
            {
                return new()
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Success = false,
                    StateMessages = new string[] { "Listelenecek Şube Bulunamadı." }
                };
            }
            else
            {
                var libraryBranch = await readRepository.GetSingleAsync(
                    author => author.Id == request.LibraryBranchId
                    );

                return new()
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Success = true,
                    StateMessages = new string[] { "Şubeler listelendi." },

                    Data = new LibraryBranchDTO
                    {
                        Id = libraryBranch.Id,
                        Name = libraryBranch.Name,
                        Address = libraryBranch.Address,
                        Description = libraryBranch.Description,
                    }

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
