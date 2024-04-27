namespace LibraryTrackingApp.Application.DataTransferObjects;

public record CreateLibraryBranchDTO : BaseAuditableDTO<Guid>
{
    public string Name { get; init; }
    public string Address { get; init; }
    public string PhoneNumber { get; init; }
    public string Description { get; init; }
}
