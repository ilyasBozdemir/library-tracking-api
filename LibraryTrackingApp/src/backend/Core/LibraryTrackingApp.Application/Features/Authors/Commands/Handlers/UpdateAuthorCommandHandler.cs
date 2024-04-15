using LibraryTrackingApp.Application.Features.Authors.Commands.Requests;
using LibraryTrackingApp.Application.Features.Authors.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.Authors.Commands.Handlers;


public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommandRequest, UpdateAuthorCommandResponse>
{
    public Task<UpdateAuthorCommandResponse> Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}