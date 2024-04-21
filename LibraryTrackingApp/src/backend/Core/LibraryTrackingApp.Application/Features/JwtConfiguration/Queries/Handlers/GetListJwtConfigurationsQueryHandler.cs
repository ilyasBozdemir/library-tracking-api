using LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Requests;
using LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Responses;
using LibraryTrackingApp.Application.Helpers.Filters.Enums;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Domain.Entities.Configuration;

namespace LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Handlers;

public class GetListJwtConfigurationsQueryHandler : IRequestHandler<GetListJwtConfigurationsQueryRequest, GetListJwtConfigurationsQueryResponse>
{
    private readonly IUnitOfWork<int> _unitOfWork;
    private readonly IMapper _mapper;
    public GetListJwtConfigurationsQueryHandler( IMapper mapper, IUnitOfWork<int> unitOfWork = null)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    public async Task<GetListJwtConfigurationsQueryResponse> Handle(GetListJwtConfigurationsQueryRequest request, CancellationToken cancellationToken)
    {
        int page = request.CurrentPage ?? 1;
        int pageSize = request.PageSize ?? 10;

        var query = _unitOfWork.GetReadRepository<JwtSettingConfiguration>().GetAll();

        if (request.Filters != null)
        {
            foreach (var filter in request.Filters)
            {
                query =  FilterItem.ApplyFilter(query, filter);
            }
        }

        if (request.Sortings != null)
        {
            foreach (var sorting in request.Sortings)
            {
                query = sorting.ApplySorting(query);
            }
        }

        if (request.CurrentPage != null && request.PageSize != null)
        {
            query = query.Skip((request.CurrentPage.Value - 1) * request.PageSize.Value)
                       .Take(request.PageSize.Value);
        }


        GetListJwtConfigurationsQueryResponse jwtConfigurationsList = new();

        //query çevrilcek

        return jwtConfigurationsList;
    }
}

