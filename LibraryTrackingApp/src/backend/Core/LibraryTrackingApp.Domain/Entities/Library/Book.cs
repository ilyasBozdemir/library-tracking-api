namespace LibraryTrackingApp.Domain.Entities.Library;


public class Book : BaseEntity<Guid>
{
    public Guid Id { get; set; }
    public Guid GenreId { get; set; }
    public Guid AuthorId { get; set; }
    public string Title { get; set; } 
    public string ISBN { get; set; }
    public string Description { get; set; }
    public string CoverImageUrl { get; set; }
    public int PageCount { get; set; }
    public Publisher Publisher { get; set; }
    public DateTime PublicationDate { get; set; }
    public DateTime OriginalPublicationDate { get; set; }
    public BookStatus Status { get; set; }
    public BookFormat Format { get; set; }
    public BookLanguage BookLanguage { get; set; }
    public bool IsFeatured { get; set; }
    public ICollection<string> Tags { get; set; }

    public virtual Genre Genre { get; set; }
    public virtual ICollection<Author> Authors { get; set; }
    public virtual ICollection<BookStock> BookStocks { get; set; }
    public virtual ICollection<Borrow> Borrows { get; set; }
}