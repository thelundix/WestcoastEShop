namespace Westcoast_EShop.Models;

public class SalesOrder
{
    // properties
    public int OrderId { get; set; }
    public Customer? Customer { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderItem>? OrderItems { get; set; }

    // Methods

    public override string ToString()
    {
        return $"{OrderId} {OrderDate.ToString("yyyy-MM-dd")} {Customer}";
    }
}
