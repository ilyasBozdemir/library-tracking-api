namespace LibraryTrackingApp.Application.DataTransferObjects;

public record ListUserDto : BaseAuditableDTO<Guid>
{
    public Guid Id { get; init; }
    public string Email { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string NameSurname { get; init; }
    public string UserName { get; init; }
    public bool TwoFactorEnabled { get; init; }
}

