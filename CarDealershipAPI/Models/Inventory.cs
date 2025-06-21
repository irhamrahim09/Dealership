namespace CarDealershipAPI.Models;

public class Inventory
{
    public int InventoryId { get; set; }
    public int CarId { get; set; }
    public string Location { get; set; } = null!;
    public int Quantity { get; set; }
}
