﻿namespace LibraryTrackingApp.Domain.Entities.Library;

public class Tag : BaseEntity<Guid>, IAuditable<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid CreatedById { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public virtual ICollection<Book> Books { get; set; }
}
