using LibraryTrackingApp.Application.Features.Authors.Queries.Requests;
using LibraryTrackingApp.Application.Features.Authors.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using System.Net;

namespace LibraryTrackingApp.Application.Features.Authors.Queries.Handlers;

public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQueryRequest, GetAuthorQueryResponse>
{

    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    public GetAuthorQueryHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<GetAuthorQueryResponse> Handle(GetAuthorQueryRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var readRepository =  _unitOfWork
                .GetReadRepository<Domain.Entities.Library.Author>();


            var existingAuthor = await 
                readRepository
                .ExistsAsync(b => b.Id == request.AuthorId);

            if (!existingAuthor)
            {
                return new()
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Success = false,
                    StateMessages = new string[] { "Listelenecek Yazar Bulunamadı." }
                };
            }
            else
            {
             var author = await  readRepository.GetSingleAsync(
                 author => author.Id == request.AuthorId
                 );



                return new()
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Success = true,
                    StateMessages = new string[] { "Yazar listelendi." },

                    Data = new AuthorDTO
                    {
                        Id = author.Id,
                        Name = author.Name,
                        Surname = author.Surname,
                        Biography = author.Biography,
                        BirthDate = author.BirthDate,
                        Country = author.Country,
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
