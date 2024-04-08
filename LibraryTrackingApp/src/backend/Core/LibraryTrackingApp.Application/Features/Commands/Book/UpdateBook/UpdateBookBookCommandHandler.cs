namespace LibraryTrackingApp.Application.Features.Commands.Book.UpdateBook;

public class UpdateBookBookCommandHandler : IRequestHandler<UpdateBookCommandRequest, UpdateBookCommandResponse>
{
    //private readonly IUnitOfWork<Guid> _unitOfWork;
    //public CreateBookCommandHandler(IUnitOfWork<Guid> unitOfWork)
    //{
    //    _unitOfWork = unitOfWork;
    //}

    public async Task<UpdateBookCommandResponse> Handle(UpdateBookCommandRequest request, CancellationToken cancellationToken)
    {

        return new ()
        {
            StatusCode = 200,
            Success = true,
        };
    }
}
