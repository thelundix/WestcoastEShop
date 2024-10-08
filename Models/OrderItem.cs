using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Westcoast_EShop.Models;

public class OrderItem
{
    // Properties
    public decimal Discount { get; set; }

    public decimal LineSum { get; set; }

    public Product? Product { get; set; }

    public int Quantity { get; set; }

    // methods

    public override string ToString()
    {
        return $"{Discount} {Product} {Quantity} {LineSum}";
    }
}
