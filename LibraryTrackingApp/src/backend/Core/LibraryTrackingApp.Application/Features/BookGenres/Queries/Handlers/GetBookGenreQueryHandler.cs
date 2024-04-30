using LibraryTrackingApp.Application.Features.BookGenres.Queries.Requests;
using LibraryTrackingApp.Application.Features.BookGenres.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using Microsoft.Extensions.Caching.Memory;
using System.Net;

namespace LibraryTrackingApp.Application.Features.BookGenres.Queries.Handlers;



public class GetBookGenreQueryHandler : IRequestHandler<GetBookGenreQueryRequest, GetBookGenreQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMemoryCache _cache;

    public GetBookGenreQueryHandler(IUnitOfWork<Guid> unitOfWork, IMediator mediator, IMemoryCache cache)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _cache = cache;
    }

    public async Task<GetBookGenreQueryResponse> Handle(GetBookGenreQueryRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var readRepository = _unitOfWork
                .GetReadRepository<Domain.Entities.Library.WorkGenre>();


            var existingBookGenre = await
                readRepository
                .ExistsAsync(b => b.Id == request.BookGenreId);

            if (!existingBookGenre)
            {
                return new()
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Success = false,
                    StateMessages = new string[] { "Listelenecek Tür Bulunamadı." }
                };
            }
            else
            {
                var bookGenre = await readRepository.GetSingleAsync(
                    genre => genre.Id == request.BookGenreId
                    );



                return new()
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Success = true,
                    StateMessages = new string[] { "Tür listelendi." },

                    Data = new BookGenreDTO
                    {
                        Id = bookGenre.Id,
                        Name = bookGenre.Name,
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
