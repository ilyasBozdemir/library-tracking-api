using LibraryTrackingApp.Application.Features.LibraryBranches.Queries.Requests;
using LibraryTrackingApp.Application.Features.LibraryBranches.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Domain.Entities.Library;
using System.Net;

namespace LibraryTrackingApp.Application.Features.LibraryBranches.Queries.Handlers;

public class GetAllLibraryBranchesQueryHandler : IRequestHandler<GetAllLibraryBranchesQueryRequest, GetAllLibraryBranchesQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    public GetAllLibraryBranchesQueryHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }
    public async Task<GetAllLibraryBranchesQueryResponse> Handle(GetAllLibraryBranchesQueryRequest request, CancellationToken cancellationToken)
    {
        try
        {
            // PageSize ve  PageIndex kısmı da eklenecektir.
            int PageSize = request.PageSize;
            int PageIndex = request.PageIndex;

            var readRepository = _unitOfWork
                           .GetReadRepository<Domain.Entities.Library.LibraryBranch>();

            var libraryBranchList = readRepository.GetAll();

            var authorDtoList = new List<LibraryBranchDTO>();

            foreach (LibraryBranch libraryBranch in libraryBranchList)
            {
                authorDtoList.Add(new LibraryBranchDTO
                {
                    Id = libraryBranch.Id,
                    Name = libraryBranch.Name,
                    Description = libraryBranch.Description,
                    Address = libraryBranch.Address,
                    PhoneNumber = libraryBranch.PhoneNumber,

                    MaxCheckoutLimit = libraryBranch.MaxCheckoutLimit,
                    MinCheckoutDurationInDays = libraryBranch.MinCheckoutDurationInDays,
                    MaxCheckoutDurationInDays = libraryBranch.MaxCheckoutDurationInDays,
                    CriticalLevelThreshold = libraryBranch.CriticalLevelThreshold,
                    NotifyOnBookOrBlogComment = libraryBranch.NotifyOnBookOrBlogComment,
                    TopMembersReportLimit = libraryBranch.TopMembersReportLimit,
                    TopBooksReportLimit = libraryBranch.TopBooksReportLimit,

                });
            }


            return new()
            {
                StatusCode = (int)HttpStatusCode.OK,
                Success = false,
                Data = authorDtoList,
                StateMessages = new string[] { $"Tüm Şubeler Listelendi." }

            };




        }
        catch (Exception ex)
        {
            return new()
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Success = false,
                StateMessages = new string[] { $"Bir hata oluştu: {ex.Message}" }
            };
        }
    }
}
