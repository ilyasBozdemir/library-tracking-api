using LibraryTrackingApp.Application.Features.Authors.Queries.Requests;
using LibraryTrackingApp.Application.Features.Authors.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Application.Shared.Wrappers.Extensions;
using LibraryTrackingApp.Domain.Entities.Library;
using System.Drawing;
using System.Net;

namespace LibraryTrackingApp.Application.Features.Authors.Queries.Handlers;

public class GetAllAuthorsQueryHandler : IRequestHandler<GetAllAuthorsQueryRequest, GetAllAuthorsQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    public GetAllAuthorsQueryHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<GetAllAuthorsQueryResponse> Handle(GetAllAuthorsQueryRequest request, CancellationToken cancellationToken)
    {
		try
		{
            // PageSize ve  PageIndex kısmı da eklenecektir.
            int PageSize = request.PageSize;
            int PageIndex = request.PageIndex;

            var readRepository = _unitOfWork
                           .GetReadRepository<Domain.Entities.Library.Author>();

            var authorList =  readRepository.GetAll();

          


            var authorDtoList = new List<AuthorDTO>();

            foreach (Author author in authorList)
            {
                authorDtoList.Add(new AuthorDTO 
                {
                    Id = author.Id,
                    Name = author.Name,
                    Surname = author.Surname,
                    Biography = author.Biography,
                    BirthDate = author.BirthDate,
                    Country = author.Country,
                });
            }


            return new()
            {
                StatusCode = (int)HttpStatusCode.OK,
                Success = false,
                Data= authorDtoList,
                StateMessages = new string[] { $"Tüm Yazarlar Listelendi." }
                
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
