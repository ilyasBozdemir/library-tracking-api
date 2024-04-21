using LibraryTrackingApp.Application.Helpers.Filters.Enums;
using MediatR;

namespace LibraryTrackingApp.Application.Helpers.Filters;

public interface IListQueryRequest<TResponse> : IRequest<TResponse>
{
    int? CurrentPage { get; set; }
    byte? PageSize { get; set; }
    public List<FilterItem>? Filters { get; set; } // Filtreler listesi
    public List<SortingItemOption>? Sortings { get; set; } // Sıralama seçenekleri
}
