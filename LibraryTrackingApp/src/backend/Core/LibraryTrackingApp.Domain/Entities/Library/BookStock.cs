﻿namespace LibraryTrackingApp.Domain.Entities.Library;


public class BookStock : BaseEntity<Guid>
{
    public Guid Id { get; set; }
    public int Quantity { get; set; }

    public virtual Book Book { get; set; }
}
