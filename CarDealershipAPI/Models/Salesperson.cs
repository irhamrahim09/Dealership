namespace CarDealershipAPI.Models;

public class Salesperson
{
    public int SalespersonId { get; set; }
    public string Fname { get; set; } = null!;
    public string Lname { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
}
