using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.Commands.Book.CreateBook;


public class CreateBookCommandHandler : IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    //private readonly IMapper _mapper;
    public CreateBookCommandHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/)
    {
        _unitOfWork = unitOfWork;
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
                return new CreateBookCommandResponse
                {
                    StatusCode = 409,
                    Success = false,
                    Errors = new string[] { "Bu ISBN numarasına sahip bir kitap zaten mevcut." }
                };
            }

            var newBook = new Domain.Entities.Library.Book()
            {
                Title = request.Title,
                Author = request.Author,
                ISBN = request.ISBN,
                Publisher = request.Publisher,
                PublicationDate = request.PublicationDate,
                Status = request.Status,
                IsDamaged = request.IsDamaged,
            };


            //var newBook = _mapper.Map<Domain.Entities.Library.Book>(request);


            var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.Book>();
            bool isAdded = await writeRepository.AddAsync(newBook);

            if (isAdded)
            {
      
                return new CreateBookCommandResponse
                {
                    StatusCode = 200,
                    Success = true,
                    Errors = new string[] { "Kitap başarıyla eklendi." }
                };
            }
            else
            {
      
                return new CreateBookCommandResponse
                {
                    StatusCode = 400,
                    Success = false,
                    Errors = new string[] { "Kitap eklenirken bir hata oluştu." }
                };
            }

        }
        catch (Exception ex)
        {
            return new CreateBookCommandResponse
            {
                StatusCode = 500,
                Success = false,
                Errors = new string[] { $"Bir hata oluştu: {ex.Message}" }
            };
        }
    }
}
