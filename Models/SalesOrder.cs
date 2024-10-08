namespace Westcoast_EShop.Models;

public class SalesOrder
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    public Customer? Customer { get; set; }
}
