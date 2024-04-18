namespace LibraryTrackingApp.Application.DTOs;

public record LibraryBranchDTO : BaseAuditableDTO<Guid>
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Address { get; init; }
    public string PhoneNumber { get; init; }
    public string Description { get; init; }
}
