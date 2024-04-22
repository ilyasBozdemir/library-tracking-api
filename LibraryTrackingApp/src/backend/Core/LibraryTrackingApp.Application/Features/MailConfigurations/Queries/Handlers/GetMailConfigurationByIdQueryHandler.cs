using LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Requests;
using LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Handlers;

public class GetMailConfigurationByIdQueryHandler : IRequestHandler<GetMailConfigurationByIdQueryRequest, GetMailConfigurationByIdQueryResponse>
{
    public Task<GetMailConfigurationByIdQueryResponse> Handle(GetMailConfigurationByIdQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
