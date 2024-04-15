using LibraryTrackingApp.Application.Features.Authors.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.Authors.Commands.Requests;

public class DeleteAuthorCommandRequest : IRequest<DeleteAuthorCommandResponse>
{
    public string Id { get; set; }
}