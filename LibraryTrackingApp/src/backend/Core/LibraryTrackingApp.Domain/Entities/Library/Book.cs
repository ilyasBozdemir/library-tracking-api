namespace LibraryTrackingApp.Domain.Entities.Library;

 
public class Book : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public Guid GenreId { get; set; }
    public Guid PublisherId { get; set; }
    public Guid AuthorId { get; set; }
    public Guid LibraryBranchId { get; set; }
    public Guid BookStockBranchId { get; set; }
    public Guid BorrowId { get; set; }

    public string Title { get; set; } 
    public string ISBN { get; set; }
    public string Description { get; set; }
    public string CoverImageUrl { get; set; }
    public int PageCount { get; set; }
 
    public DateTime PublicationDate { get; set; }
    public DateTime OriginalPublicationDate { get; set; }
    public BookStatus Status { get; set; }
    public BookFormat Format { get; set; }
    public BookLanguage BookLanguage { get; set; }
    public bool IsFeatured { get; set; }



    public Guid CreatedById { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }

    public  Genre Genre { get; set; }
    public Publisher Publisher { get; set; }

    public  LibraryBranch LibraryBranch { get; set; }
    public  ICollection<Tag> Tags { get; set; }
    public  ICollection<Author> Authors { get; set; }
    public  ICollection<BookStock> BookStocks { get; set; }
    public  ICollection<Borrow> Borrows { get; set; }
}