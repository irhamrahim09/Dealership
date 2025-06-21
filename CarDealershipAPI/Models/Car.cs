namespace CarDealershipAPI.Models;

public class Car
{
    public int CarId { get; set; }
    public string Make { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int Year { get; set; }
    public string Vin { get; set; } = null!;
    public decimal Price { get; set; }
    public string Status { get; set; } = null!;
}
