using LibraryTrackingApp.Application.Features.BookPublishers.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.BookPublishers.Commands.Requests;

public class DeleteBookPublisherCommandRequest : IRequest<DeleteBookPublisherCommandResponse>
{
    public string Id { get; set; }
}