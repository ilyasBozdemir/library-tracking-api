using LibraryTrackingApp.Application.Features.JwtConfigurations.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.JwtConfigurations.Queries.Requests;

public class GetJwtConfigurationByIdQueryRequest : IRequest<GetJwtConfigurationByIdQueryResponse>
{
    public Guid Id { get; set; }
}
