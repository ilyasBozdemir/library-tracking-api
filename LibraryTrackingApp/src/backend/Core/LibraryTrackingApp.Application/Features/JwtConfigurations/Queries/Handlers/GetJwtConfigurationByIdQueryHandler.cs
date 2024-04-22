using LibraryTrackingApp.Application.Features.JwtConfigurations.Queries.Requests;
using LibraryTrackingApp.Application.Features.JwtConfigurations.Queries.Responses;


namespace LibraryTrackingApp.Application.Features.JwtConfigurations.Queries.Handlers;

public class GetJwtConfigurationByIdQueryHandler : IRequestHandler<GetJwtConfigurationByIdQueryRequest, GetJwtConfigurationByIdQueryResponse>
{

    public Task<GetJwtConfigurationByIdQueryResponse> Handle(GetJwtConfigurationByIdQueryRequest request, CancellationToken cancellationToken)
    {

        throw new NotImplementedException();
    }
}
