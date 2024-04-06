namespace LibraryTrackingApp.Application.Shared.Wrappers.Paging;

public class Paginate<T>
{
    public Paginate()
    {
        Items = Array.Empty<T>();
    }

    public PaginationInfo PaginationInfo { get; set; }
    public int Count { get; set; }
    public int Pages { get; set; }
    public IList<T> Items { get; set; }

    public bool HasPrevious => PaginationInfo.PageIndex > 0;
    public bool HasNext => PaginationInfo.PageIndex + 1 < Pages;
}
