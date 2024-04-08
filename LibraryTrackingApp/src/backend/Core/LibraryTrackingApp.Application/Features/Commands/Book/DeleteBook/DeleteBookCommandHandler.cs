using MediatR;

namespace LibraryTrackingApp.Application.Features.Commands.Book.DeleteBook;


public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommandRequest, DeleteBookCommandResponse>
{
    //private readonly IUnitOfWork<Guid> _unitOfWork;
    //public CreateBookCommandHandler(IUnitOfWork<Guid> unitOfWork)
    //{
    //    _unitOfWork = unitOfWork;
    //}

    public async Task<DeleteBookCommandResponse> Handle(DeleteBookCommandRequest request, CancellationToken cancellationToken)
    {

        return new ()
        {
            StatusCode = 200,
            Success = true,
        };
    }
}
