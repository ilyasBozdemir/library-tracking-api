using LibraryTrackingApp.Application.Features.Authors.Queries.Requests;
using LibraryTrackingApp.Application.Features.Authors.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using System.Net;
using Microsoft.Extensions.Caching.Memory;


namespace LibraryTrackingApp.Application.Features.Authors.Queries.Handlers;


public class GetAllAuthorsQueryHandler : IRequestHandler<GetAllAuthorsQueryRequest, GetAllAuthorsQueryResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    private readonly IMemoryCache _cache;

    public GetAllAuthorsQueryHandler(IUnitOfWork<Guid> unitOfWork, IMediator mediator, IMemoryCache cache)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        _cache = cache; 
    }

    public async Task<GetAllAuthorsQueryResponse> Handle(GetAllAuthorsQueryRequest request, CancellationToken cancellationToken)
    {
        //memory cache testi: 500 istek 9711ms
        // memory cache olamdan 500 istek 6283 ms

        // redis kullanılcaktır.

        // ve de ;

        /*
            Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
    Task RollbackAsync(CancellationToken cancellationToken = default);
    Task CommitAsync(CancellationToken cancellationToken = default);

        bunlar her handler'de kullanılcaktır.

         */
        try
        {
            string cacheKey = "AllAuthors";

            if (_cache.TryGetValue<List<AuthorDTO>>(cacheKey, out List<AuthorDTO> cachedAuthors))
            {
                return new GetAllAuthorsQueryResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Success = true,
                    Data = cachedAuthors,
                    StateMessages = new string[] { $"Tüm Yazarlar Önbellekten Alındı." }
                };
            }
            else
            {
                var readRepository = _unitOfWork.GetReadRepository<Domain.Entities.Library.Author>();
                var authorList = readRepository.GetAll();
                var authorDtoList = authorList.Select(author => new AuthorDTO
                {
                    Id = author.Id,
                    Name = author.Name,
                    Surname = author.Surname,
                    Biography = author.Biography,
                    BirthDate = author.BirthDate,
                    Country = author.Country,
                    Website=author.Website,
                }).ToList();

                _cache.Set(cacheKey, authorDtoList, TimeSpan.FromMinutes(5));

                return new GetAllAuthorsQueryResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Success = true,
                    Data = authorDtoList,
                    StateMessages = new string[] { $"Tüm Yazarlar Listelendi." }
                };
            }
        }
        catch (Exception ex)
        {
            return new GetAllAuthorsQueryResponse
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Success = false,
                StateMessages = new string[] { $"Bir hata oluştu: {ex.Message}" }
            };
        }
    }
}
