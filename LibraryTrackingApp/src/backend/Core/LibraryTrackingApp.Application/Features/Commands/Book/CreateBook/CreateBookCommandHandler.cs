using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.Commands.Book.CreateBook;


public class CreateBookCommandHandler : IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    //private readonly IMapper _mapper;
    public CreateBookCommandHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<CreateBookCommandResponse> Handle(CreateBookCommandRequest request, CancellationToken cancellationToken)
    {

        try
        {
            var existingBook = await _unitOfWork.GetReadRepository<Domain.Entities.Library.Book>()
                .ExistsAsync(b => b.ISBN == request.ISBN);

            if (existingBook)
            {
                return new ()
                {
                    StatusCode = 409,
                    Success = false,
                    Errors = new string[] { "Bu ISBN numarasına sahip bir kitap zaten mevcut." }
                };
            }

            var newBook = new Domain.Entities.Library.Book()
            {
                Title = request.Title,
                ISBN = request.ISBN,
                Publisher = request.Publisher,
                PublicationDate = request.PublicationDate,
                PageCount = request.PageCount,
                Status = request.Status,
                IsDeleted = false,
                DeletedDate = null
            };

            var bookDto = new BookDTO()
            {
                Title = request.Title,
                ISBN = request.ISBN,
                Publisher = request.Publisher,
                PublicationDate = request.PublicationDate,
                PageCount = request.PageCount
            };

            //var newBook = _mapper.Map<Domain.Entities.Library.Book>(request); // bunu assembly olarak eklerken sorun oldugu için 
            // su anlık elle yazdım sonrasında düzeltme yapacağım.


            var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.Book>();
            bool isAdded = await writeRepository.AddAsync(newBook);

            if (isAdded)
            {
                return new()
                {
                    StatusCode = 200,
                    Success = true,
                    Errors = new string[] { "Kitap başarıyla eklendi." }
                };
            }
            else
            {

                return new()
                {
                    StatusCode = 400,
                    Success = false,
                    Errors = new string[] { "Kitap eklenirken bir hata oluştu." }
                };
            }

        }
        catch (Exception ex)
        {
            return new()
            {
                StatusCode = 500,
                Success = false,
                Errors = new string[] { $"Bir hata oluştu: {ex.Message}" }
            };
        }
    }
}