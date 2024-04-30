using LibraryTrackingApp.Application.Features.BookPublishers.Queries.Requests;
using LibraryTrackingApp.Application.Features.BookPublishers.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using Microsoft.Extensions.Caching.Memory;
using System.Net;

namespace LibraryTrackingApp.Application.Features.BookPublishers.Queries.Handlers;

public class GetBookPublisherQueryHandler : IRequestHandler<GetBookPublisherQueryRequest, GetBookPublisherQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMemoryCache _cache;

    public GetBookPublisherQueryHandler(IUnitOfWork<Guid> unitOfWork, IMediator mediator, IMemoryCache cache)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _cache = cache;
    }

    public async Task<GetBookPublisherQueryResponse> Handle(GetBookPublisherQueryRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var readRepository = _unitOfWork
                .GetReadRepository<Domain.Entities.Library.WorkPublisher>();


            var existingBookPublisher = await
                readRepository
                .ExistsAsync(b => b.Id == request.BookPublisherId);

            if (!existingBookPublisher)
            {
                return new()
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Success = false,
                    StateMessages = new string[] { "Listelenecek Yayınevi Bulunamadı." }
                };
            }
            else
            {
                var bookGenre = await readRepository.GetSingleAsync(
                    genre => genre.Id == request.BookPublisherId
                    );



                return new()
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Success = true,
                    StateMessages = new string[] { "Yayınevi listelendi." },

                    Data = new BookPublisherDTO
                    {
                        Id = bookGenre.Id,
                        Name = bookGenre.Name,
                        Address = bookGenre.Address,
                        Website = bookGenre.Website,
                        PhoneNumber = bookGenre.PhoneNumber,
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
