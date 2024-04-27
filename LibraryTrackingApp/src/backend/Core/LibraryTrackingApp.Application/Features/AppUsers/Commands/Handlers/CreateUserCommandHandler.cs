using LibraryTrackingApp.Application.DataTransferObjects;
using LibraryTrackingApp.Application.Features.AppUsers.Commands.Requests;
using LibraryTrackingApp.Application.Features.AppUsers.Commands.Responses;
using LibraryTrackingApp.Application.Features.AppUsers.Events;
using LibraryTrackingApp.Application.Interfaces.Services;
using LibraryTrackingApp.Domain.Constants;
using LibraryTrackingApp.Domain.Exceptions;

namespace LibraryTrackingApp.Application.Features.AppUsers.Commands.Handlers;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
{
    private readonly IUserService _userService;
    private readonly IAuthService _authService;
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;
    public CreateUserCommandHandler(IUserService userService, IAuthService authService, IMapper mapper, IMediator mediator)
    {
        _userService = userService;
        _authService = authService;
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
    {

        try
        {
            bool userExists = await _authService.CheckUserExistence(request.Username, request.Email);

            if (userExists)
                return new()
                {
                    StatusCode = 409,
                    Success = false,
                    StateMessages = new string[] { "Bu bilgilere sahip bir kullanıcı zaten mevcut." }
                };


            var user = _mapper.Map<CreateUserDTO>(request);



            var createUserResponse = await _userService.CreateAsync(user);

            var commandResponse = new CreateUserCommandResponse()
            {
                Success = true,
                StateMessages = new string[] { "Kullanıcı Başarıyla Oluşturuldu." },
                StatusCode = 201
            };

            commandResponse.Data = user;

            var UserCreatedEvent = new UserEvent() { UserId = user.Id };

            await _mediator.Publish(UserCreatedEvent);

            return commandResponse;
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
