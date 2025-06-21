namespace CarDealershipAPI.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public string Fname { get; set; } = null!;
    public string Lname { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Address { get; set; } = null!;
}
