using LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Responses;
using LibraryTrackingApp.Application.Helpers.Filters.Enums;
using LibraryTrackingApp.Application.Helpers.Filters;


namespace LibraryTrackingApp.Application.Features.MailConfigurations.Queries.Requests;

public class GetListMailConfigurationsQueryRequest : IListQueryRequest<GetListMailConfigurationsQueryResponse>
{
    public int? CurrentPage { get; set; } = 1;
    public byte? PageSize { get; set; } = 10;
    public List<FilterItem>? Filters { get; set; }
    public List<SortingItemOption>? Sortings { get; set; }
}
