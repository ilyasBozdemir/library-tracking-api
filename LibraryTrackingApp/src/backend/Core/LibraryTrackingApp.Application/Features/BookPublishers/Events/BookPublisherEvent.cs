﻿using LibraryTrackingApp.Domain.Events;

namespace LibraryTrackingApp.Application.Features.BookPublishers.Events;

public class BookPublisherEvent
    : BaseEvent
{
    public Guid BookPublisherId { get; set; }
    public RequestNotificationType RequestNotificationType { get; set; }
}
