using LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Responses;

namespace LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Requests;

public class GetJwtConfigurationByIdQueryRequest : IRequest<GetJwtConfigurationByIdQueryResponse>
{
    public Guid Id { get; set; }
}
