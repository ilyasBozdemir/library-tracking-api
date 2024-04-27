using LibraryTrackingApp.Application.Features.BookGenres.Queries.Responses;
using LibraryTrackingApp.Application.Features.BookPublishers.Queries.Requests;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Domain.Entities.Library;
using Microsoft.Extensions.Caching.Memory;
using System.Net;

namespace LibraryTrackingApp.Application.Features.BookPublishers.Queries.Handlers;

public class GetAllBookPublishersHandler : IRequestHandler<GetAllBookPublishersQueryRequest, GetAllBookGenresQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMemoryCache _cache;

    public GetAllBookPublishersHandler(IUnitOfWork<Guid> unitOfWork, IMediator mediator, IMemoryCache cache)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _cache = cache;
    }

    public async Task<GetAllBookGenresQueryResponse> Handle(GetAllBookPublishersQueryRequest request, CancellationToken cancellationToken)
    {
        try
        {
            // PageSize ve  PageIndex kısmı da eklenecektir.
            int PageSize = request.PageSize;
            int PageIndex = request.PageIndex;

            var readRepository = _unitOfWork
                           .GetReadRepository<Domain.Entities.Library.BookGenre>();

            var BookGenreList = readRepository.GetAll();

            var bookGenreDtoList = new List<BookGenreDTO>();

            foreach (BookGenre libraryBranch in BookGenreList)
            {
                bookGenreDtoList.Add(new BookGenreDTO
                {
                    Id = libraryBranch.Id,
                    Name = libraryBranch.Name
                });
            }


            return new()
            {
                StatusCode = (int)HttpStatusCode.OK,
                Success = false,
                Data = bookGenreDtoList,
                StateMessages = new string[] { $"Tüm Yayınevleri Listelendi." }

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
