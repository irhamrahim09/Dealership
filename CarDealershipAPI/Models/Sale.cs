namespace CarDealershipAPI.Models;

public class Sale
{
    public int SaleId { get; set; }
    public int CarId { get; set; }
    public int CustomerId { get; set; }
    public int SalespersonId { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal SalePrice { get; set; }
}
