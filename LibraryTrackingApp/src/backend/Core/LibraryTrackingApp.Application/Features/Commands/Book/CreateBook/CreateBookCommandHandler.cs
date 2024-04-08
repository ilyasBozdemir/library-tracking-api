using MediatR;

namespace LibraryTrackingApp.Application.Features.Commands.Book.CreateBook;


public class CreateBookCommandHandler : IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
{
    //private readonly IUnitOfWork<Guid> _unitOfWork;
    //public CreateBookCommandHandler(IUnitOfWork<Guid> unitOfWork)
    //{
    //    _unitOfWork = unitOfWork;
    //}

    public async Task<CreateBookCommandResponse> Handle(CreateBookCommandRequest request, CancellationToken cancellationToken)
    {

        return new () 
        {
            StatusCode = 200,
            Success = true,
        };
    }
}
