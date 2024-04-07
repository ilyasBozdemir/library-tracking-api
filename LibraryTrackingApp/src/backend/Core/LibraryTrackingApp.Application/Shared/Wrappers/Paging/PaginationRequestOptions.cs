namespace LibraryTrackingApp.Application.Shared.Wrappers.Paging;

public class PaginationRequestOptions
{
    public readonly int MaxPageSize;

    public PaginationRequestOptions(int maxPageSize = 100)
    {
        MaxPageSize = maxPageSize;
    }

    private int _pageSize;
    public int PageSize
    {
        get => _pageSize;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                    "PageSize must be greater than zero.");

            if (value > MaxPageSize)
                throw new ArgumentOutOfRangeException(nameof(value),
                    $"PageSize must be between 1 and {MaxPageSize}.");

            _pageSize = value;
        }
    }

    public int TotalItemCount { get; set; } // Sayfalanan toplam öğe sayısı
    public int CurrentPageIndex { get; set; } // Şu anki sayfa indeksi
}
