using LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Responses;


namespace LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Requests;

public class GetMailConfigurationByIdQueryRequest : IRequest<GetMailConfigurationByIdQueryResponse>
{
    public Guid Id { get; set; }
}