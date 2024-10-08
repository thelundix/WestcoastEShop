using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Westcoast_EShop.Models;

public class Product
{
    // Properties

    public int ProductId { get; set; }

    public string? ItemNumber { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }

    // Methods

    public override string ToString()
    {
        return $"{ProductId} {Name} {Price}";
    }
}
