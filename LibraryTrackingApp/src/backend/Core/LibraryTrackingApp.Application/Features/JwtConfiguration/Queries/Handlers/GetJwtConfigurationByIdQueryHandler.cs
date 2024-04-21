using LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Requests;
using LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Responses;


namespace LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Handlers;

public class GetJwtConfigurationByIdQueryHandler : IRequestHandler<GetJwtConfigurationByIdQueryRequest, GetJwtConfigurationByIdQueryResponse>
{

    public Task<GetJwtConfigurationByIdQueryResponse> Handle(GetJwtConfigurationByIdQueryRequest request, CancellationToken cancellationToken)
    {

        throw new NotImplementedException();
    }
}
