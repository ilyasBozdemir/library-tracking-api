using LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Requests;
using LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Responses;
using LibraryTrackingApp.Application.Helpers.Filters.Enums;
using LibraryTrackingApp.Application.Interfaces.UnitOfWork;
using LibraryTrackingApp.Domain.Constants;
using LibraryTrackingApp.Domain.Entities.Configuration;

namespace LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Handlers;

public class GetListMailConfigurationsQueryHandler : IRequestHandler<GetListMailConfigurationsQueryRequest, GetListMailConfigurationsQueryResponse>
{
    private readonly IUnitOfWork<int> _unitOfWork;
    private readonly IMapper _mapper;
    public GetListMailConfigurationsQueryHandler( IMapper mapper, IUnitOfWork<int> unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<GetListMailConfigurationsQueryResponse> Handle(GetListMailConfigurationsQueryRequest request, CancellationToken cancellationToken)
    {
        int page = request.CurrentPage ?? 1;
        int pageSize = request.PageSize ?? 10;

        var query = _unitOfWork.GetReadRepository<MailAccountConfiguration>().GetAll();

        if (request.Filters != null)
        {
            foreach (var filter in request.Filters)
            {
                query = FilterItem.ApplyFilter(query, filter);
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

        GetListMailConfigurationsQueryResponse mailConfigurationsList = new();

        //query çevrilcek

        return mailConfigurationsList;
    }
}

