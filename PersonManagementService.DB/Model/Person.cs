using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PersonManagementService.DB.Model;

[Table("Persons")]
public class Person
{
    [Key] public Guid Id;
    public string? Firstname { get; set; } = null!;
    public string? Lastname { get; set; } = null!;
    public DateTime? Birthday { get; set; }
    public string? SocialSecurityNumber { get; set; } = null!;
    public string? PhoneNumber { get; set; } = null!;
    public List<FinancialProducts>? Products { get; set; } = new List<FinancialProducts>();
}