using LibraryTrackingApp.Application.Features.BookPublishers.Commands.Requests;
using LibraryTrackingApp.Application.Features.BookPublishers.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Domain.Entities;

namespace LibraryTrackingApp.Application.Features.BookPublishers.Commands.Handlers;


public class CreateBookPublisherCommandHandler : IRequestHandler<CreateBookPublisherCommandRequest, CreateBookPublisherCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    //private readonly IMapper _mapper;
    public CreateBookPublisherCommandHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<CreateBookPublisherCommandResponse> Handle(CreateBookPublisherCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var existinBookPublisher = await _unitOfWork
                .GetReadRepository<Domain.Entities.Library.BookPublisher>()
                .ExistsAsync(b =>
                b.Name == request.Name
                );

            if (existinBookPublisher)
            {
                return new()
                {
                    StatusCode = 409,
                    Success = false,
                    StateMessages = new string[] { "Bu bilgilere sahip bir yayınevi zaten mevcut." }
                };
            }
            var newBookPublisher = new Domain.Entities.Library.BookPublisher()
            {
                Name = request.Name,
                Website = request.Website,
                Address = request.Address,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,

                IsDeleted = false,
                CreatedById = Guid.NewGuid(),//staff id olucak ilerde
                LastModifiedById = Guid.NewGuid(),//staff id olucak ilerde
                LastModifiedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
                CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now),
            };

            var bookDto = new BookPublisherDTO()
            {
                Name = request.Name,
                Website = request.Website,
                Address = request.Address,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
            };

            var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.BookPublisher>();
            bool isAdded = await writeRepository.AddAsync(newBookPublisher);
            if (isAdded)
            {
                return new()
                {
                    StatusCode = 201,
                    Success = true,
                    StateMessages = new string[] { "Yayınevi başarıyla oluşturuldu." }
                };
            }
            else
            {

                return new()
                {
                    StatusCode = 400,
                    Success = false,
                    StateMessages = new string[] { "Yayınevi eklenirken bir hata oluştu." }
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