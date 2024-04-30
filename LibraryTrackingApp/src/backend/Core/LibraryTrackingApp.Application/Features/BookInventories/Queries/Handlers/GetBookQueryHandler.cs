using LibraryTrackingApp.Application.Features.BookInventories.Queries.Requests;
using LibraryTrackingApp.Application.Features.BookInventories.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using System.Net;

namespace LibraryTrackingApp.Application.Features.BookInventories.Queries.Handlers;

public class GetBookQueryHandler : IRequestHandler<GetBookQueryRequest, GetBookQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    public GetBookQueryHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<GetBookQueryResponse> Handle(GetBookQueryRequest request, CancellationToken cancellationToken)
    {

        try
        {
            var readRepository = _unitOfWork
                .GetReadRepository<Domain.Entities.Library.WorkCatalog>();


            var existingAuthor = await
                readRepository
                .ExistsAsync(b => b.Id == request.BookId);

            if (!existingAuthor)
            {
                return new()
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Success = false,
                    StateMessages = new string[] { "Listelenecek Kitap Bulunamadı." }
                };
            }
            else
            {
                var author = await readRepository.GetSingleAsync(
                    author => author.Id == request.BookId
                    );



                return new()
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Success = true,
                    StateMessages = new string[] { "Kitap listelendi." },

                    // burası güncellencek,
                    // genre publisher author bilgileri tamamen eklenecek.
                    Data = new BookDTO
                    {
                        Id = author.Id,

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
