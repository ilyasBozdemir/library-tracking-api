using LibraryTrackingApp.Application.Features.WorkPublishers.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.WorkPublishers.Commands.Requests;

public class DeleteBookPublisherCommandRequest : IRequest<DeleteBookPublisherCommandResponse>
{
    public string Id { get; set; }
}