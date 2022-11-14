using System.ComponentModel.DataAnnotations;

namespace PersonManagementService.DB.Model;

public class FinancialProducts
{
    [Key] public Guid Id;
    public float Balance { get; set; } = 0;
    public ProductType? ProductType { get; set; } = null!;
    public float InterestRate { get; set; } = 0;
    

}