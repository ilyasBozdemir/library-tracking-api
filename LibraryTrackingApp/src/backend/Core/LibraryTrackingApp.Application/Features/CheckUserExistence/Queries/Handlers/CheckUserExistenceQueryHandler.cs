using LibraryTrackingApp.Application.Features.Authors.Queries.Requests;
using LibraryTrackingApp.Application.Features.Authors.Queries.Responses;
using LibraryTrackingApp.Application.Features.CheckUserExistence.Queries.Requests;
using LibraryTrackingApp.Application.Features.CheckUserExistence.Queries.Responses;
using LibraryTrackingApp.Application.Interfaces.Services;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;

namespace LibraryTrackingApp.Application.Features.CheckUserExistence.Queries.Handlers;

public class CheckUserExistenceQueryHandler:IRequestHandler<CheckUserExistenceQueryRequest, CheckUserExistenceQueryResponse> 
{

    private readonly IUserService _userService;
    private readonly IAuthService _authService;
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;


    public CheckUserExistenceQueryHandler(IUserService userService, IAuthService authService, IMapper mapper, IMediator mediator)
    {
        _userService = userService;
        _authService = authService;
        _mapper = mapper;
        _mediator = mediator;
    }
    public async Task<CheckUserExistenceQueryResponse> Handle(CheckUserExistenceQueryRequest request, CancellationToken cancellationToken)
    {

        try
        {
            bool userExists = await _authService.CheckUserExistence(request.UsernameOrEmail, request.UsernameOrEmail);

            return new()
            {
                Status = userExists
            };

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
