using LibraryTrackingApp.Application.Features.BookPublishers.Commands.Responses;

namespace LibraryTrackingApp.Application.Features.BookPublishers.Commands.Requests;

public class CreateBookPublisherCommandRequest : IRequest<CreateBookPublisherCommandResponse>
{
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public string Website { get; set; }
    public string Address { get; set; } 
    public string PhoneNumber { get; set; } 
    public string Email { get; set; } 
}
