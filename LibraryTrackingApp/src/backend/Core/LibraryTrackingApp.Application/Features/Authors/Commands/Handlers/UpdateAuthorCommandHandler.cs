using LibraryTrackingApp.Application.Features.Authors.Commands.Requests;
using LibraryTrackingApp.Application.Features.Authors.Commands.Responses;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Domain.Entities;

namespace LibraryTrackingApp.Application.Features.Authors.Commands.Handlers;


public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommandRequest, UpdateAuthorCommandResponse>
{
    private readonly IUnitOfWork<Guid> _unitOfWork;
    private readonly IMediator _mediator;
    //private readonly IMapper _mapper;
    public UpdateAuthorCommandHandler(IUnitOfWork<Guid> unitOfWork /*,IMapper mapper*/, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
        //_mapper = mapper;
    }

    public async Task<UpdateAuthorCommandResponse> Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {
           

            var readRepository = _unitOfWork.GetReadRepository<Domain.Entities.Library.Author>();

            var existingAuthor = await readRepository.GetSingleAsync(s => s.Id == request.UpdatedId);
            if (existingAuthor == null)
            {
                return new()
                {
                    StatusCode = 404,
                    Success = false,
                    StateMessages = new string[] { "Böyle bir yazar bulunamadı" }
                };
            }
            else
            {
                var writeRepository = _unitOfWork.GetWriteRepository<Domain.Entities.Library.Author>();

                existingAuthor.Name = request.Name;
                existingAuthor.Surname = request.Surname;
                existingAuthor.BirthDate = request.BirthDate;
                existingAuthor.Country = request.Country;
                existingAuthor.Biography = request.Biography;
                existingAuthor.CreatedById = Guid.NewGuid();//staff id olucak ilerde
                existingAuthor.LastModifiedById = Guid.NewGuid();//staff id olucak ilerde
                existingAuthor.LastModifiedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now);
                existingAuthor.CreatedDateUnix = BaseEntity.ToUnixTimestamp(DateTime.Now);

                bool isUpdated = await writeRepository.UpdateAsync(existingAuthor);

                if (isUpdated)
                {
                    return new()
                    {
                        StatusCode = 200,
                        Success = true,
                        StateMessages = new string[] { "Yazar başarıyla güncellendi." }
                    };
                }
                else
                {

                    return new()
                    {
                        StatusCode = 400,
                        Success = false,
                        StateMessages = new string[] { "Yazar güncellenirken bir hata oluştu." }
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