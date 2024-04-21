namespace PreAccountingBE.Application.Features.DTOs.User;
public record UserDTO : BaseAuditableDTO<Guid>
{
    public Guid Id { get; init; }
    public string UserName { get; init; }
    public string Name { get; init; }
    public string Surname { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }
    public string CreatedBy { get; init; }
    public DateTime CreatedDate { get; init; }
    public string? LastModifiedBy { get; init; }
    public DateTime? LastModifiedDate { get; init; }
}

