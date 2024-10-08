namespace Westcoast_EShop.Models;

public class Customer
{
    public int CustomerId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime LastBuy { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? AdressLine { get; set; }

    public string? PostalCode { get; set; }

    public string? City { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    
}
