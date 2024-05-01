using LibraryTrackingApp.Application.Features.WorkPublishers.Commands.Requests;
using LibraryTrackingApp.Application.Features.WorkPublishers.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Domain.Entities;

namespace LibraryTrackingApp.Application.Features.WorkPublishers.Commands.Handlers;


public class UpdateBookPublisherCommandHandler : IRequestHandler<UpdateBookPublisherCommandRequest, UpdateBookPublisherCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    //private readonly IMapper _mapper;
    public UpdateBookPublisherCommandHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<UpdateBookPublisherCommandResponse> Handle(UpdateBookPublisherCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var readRepository = _unitOfWork.GetReadRepository<Domain.Entities.Library.WorkPublisher>();

            var existingBookPublisher = await readRepository.GetSingleAsync(s => s.Id == request.UpdatedId);
            if (existingBookPublisher == null)
            {
                return new()
                {
                    StatusCode = 404,
                    Success = false,
                    StateMessages = new string[] { "Yayınevi bulunamadı" }
                };
            }
            else
            {
                var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.WorkPublisher>();

                existingBookPublisher.Name = request.Name;
                existingBookPublisher.Website = request.Website;
                existingBookPublisher.PhoneNumber = request.PhoneNumber;
                existingBookPublisher.Address = request.Address;
                existingBookPublisher.Email = request.Email;



                existingBookPublisher.CreatedById = Guid.NewGuid();//staff id olucak ilerde
                existingBookPublisher.LastModifiedById = Guid.NewGuid();//staff id olucak ilerde
                existingBookPublisher.LastModifiedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now);
                existingBookPublisher.CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now);

                bool isUpdated = await writeRepository.UpdateAsync(existingBookPublisher);

                if (isUpdated)
                {
                    return new()
                    {
                        StatusCode = 200,
                        Success = true,
                        StateMessages = new string[] { "Yayınevi başarıyla güncellendi." }
                    };
                }
                else
                {

                    return new()
                    {
                        StatusCode = 400,
                        Success = false,
                        StateMessages = new string[] { "Yayınevi güncellenirken bir hata oluştu." }
                    };
                }
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