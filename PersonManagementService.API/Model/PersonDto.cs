using System;

namespace PersonManagementService.Model;

public class PersonDto
{
    public Guid? Id  { get; set; } = null!;
    public string? Firstname { get; set; } = null!;
    public string? Lastname { get; set; } = null!;
    public DateTime? Birthday { get; set; }
    public string? SocialSecurityNumber { get; set; } = null!;
    public string? PhoneNumber { get; set; } = null!;
}