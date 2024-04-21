using LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Responses;
using LibraryTrackingApp.Application.Helpers.Filters.Enums;
using LibraryTrackingApp.Domain.Constants;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LibraryTrackingApp.Application.Features.JwtConfiguration.Queries.Requests;

public class GetListJwtConfigurationsQueryRequest : IRequest<GetListJwtConfigurationsQueryResponse>
{
    public int? CurrentPage { get; set; } = 1;
    public byte? PageSize { get; set; } = 10;
    public List<LibraryTrackingApp.Application.Helpers.Filters.Enums.FilterItem>? Filters { get; set; }
    public List<SortingItemOption>? Sortings { get; set; }
}
