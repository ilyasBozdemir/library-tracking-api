namespace LibraryTrackingApp.Domain.Entities.Library;

public class Staff : BaseEntity<Guid>
{
    public string Name { get; set; } 
    public string Surname { get; set; }
    public string Email { get; set; } 
    public string Phone { get; set; }
    public string Address { get; set; } 
    public DateTime EmploymentDate { get; set; }
    public string Role { get; set; } 
    public decimal Salary { get; set; } 
    public bool IsFullTime { get; set; }
}
