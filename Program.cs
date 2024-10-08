using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using Westcoast_EShop.Models;

namespace Westcoast_EShop;

public class Program
{
    static void Main()
    {
        var order = new SalesOrder();

        order.OrderDate = DateTime.Now;
        order.OrderId = 1;
        order.Customer = new Customer
        {
            CustomerId = 100,
            CreatedAt = DateTime.Now,
            LastBuy = DateTime.Now,
            FirstName = "olle",
            LastName = "svensson",
            AdressLine = "hejgatan 1",
            PostalCode = "123 56",
            City = "Storstaden",
        };

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true,
        };

        var json = JsonSerializer.Serialize(order, options);

        var path = string.Concat(Environment.CurrentDirectory, "/data/order.json");

        File.WriteAllText(path, json);
    }
}
