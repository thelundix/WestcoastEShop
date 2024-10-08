using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using Westcoast_EShop.Models;

namespace Westcoast_EShop;

public class Program
{
    static void Main()
    {
        var orders = new List<SalesOrder>();

        // beställning 1
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

        // SKAPA ORDER RAD
        var orderItem = new OrderItem();
        var product = new Product();

        product.ItemNumber = "1-5679X";
        product.ProductId = 1;
        product.Name = "Sliptrissor";
        product.Price = 40;

        orderItem.Discount = 0.10M;
        orderItem.Quantity = 10;
        orderItem.Product = product;
        orderItem.LineSum =
            orderItem.Quantity
            * (orderItem.Product.Price - (orderItem.Discount * orderItem.Product.Price));

        // lägg till orderraden till salesorder orderitems..

        order.OrderItems = new List<OrderItem>();
        order.OrderItems.Add(orderItem);

        // skapa order rad 2 ...

        orderItem = new OrderItem();
        product = new Product();

        product.ItemNumber = "1-5665X";
        product.ProductId = 2;
        product.Name = "yxa";
        product.Price = 10;

        orderItem.Discount = 0.10M;
        orderItem.Quantity = 10;
        orderItem.Product = product;
        orderItem.LineSum =
            orderItem.Quantity
            * (orderItem.Product.Price - (orderItem.Discount * orderItem.Product.Price));

        // lägg till orderraden till salesorder orderitems..
        order.OrderItems.Add(orderItem);
        orders.Add(order);

        // beställning 2
        order = new SalesOrder();

        order.OrderDate = DateTime.Now;
        order.OrderId = 2;
        order.Customer = new Customer
        {
            CustomerId = 100,
            CreatedAt = DateTime.Now,
            LastBuy = DateTime.Now,
            FirstName = "Anneli",
            LastName = "svensson",
            AdressLine = "hejgatan 1",
            PostalCode = "123 56",
            City = "Storstaden",
        };

        // SKAPA ORDER RAD
        orderItem = new OrderItem();
        product = new Product();

        product.ItemNumber = "1-5672X";
        product.ProductId = 1;
        product.Name = "slipmaskin";
        product.Price = 12;

        orderItem.Discount = 0.10M;
        orderItem.Quantity = 10;
        orderItem.Product = product;
        orderItem.LineSum =
            orderItem.Quantity
            * (orderItem.Product.Price - (orderItem.Discount * orderItem.Product.Price));

        // lägg till orderraden till salesorder orderitems..

        order.OrderItems = new List<OrderItem>();
        order.OrderItems.Add(orderItem);

        // skapa order rad 2 ...

        orderItem = new OrderItem();
        product = new Product();

        product.ItemNumber = "1-5663X";
        product.ProductId = 2;
        product.Name = "hammare";
        product.Price = 10;

        orderItem.Discount = 0.10M;
        orderItem.Quantity = 10;
        orderItem.Product = product;
        orderItem.LineSum =
            orderItem.Quantity
            * (orderItem.Product.Price - (orderItem.Discount * orderItem.Product.Price));

        // lägg till orderraden till salesorder orderitems..
        order.OrderItems.Add(orderItem);
        orders.Add(order);

        // här skriver vi ner allt till ett json dokument
        var path = string.Concat(Environment.CurrentDirectory, "/data/orders.json");

        Storage.WriteJson(path, orders);
    }
}
