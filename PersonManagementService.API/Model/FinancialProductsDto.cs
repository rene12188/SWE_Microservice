using System.ComponentModel.DataAnnotations;
using PersonManagementService.DB.Model;

namespace PersonManagementService.Model;

public class FinancialProductsDto
{
    public Guid Id { get; set; } = Guid.Empty;
    public float Balance { get; set; } = 0;
    public ProductType? ProductType { get; set; } = null!;
    public float InterestRate { get; set; } = 0;
}