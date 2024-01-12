// Order.cs
using System;
using System.Collections.Generic;

public class Order
{
    private int orderId;
    private List<Product> products;

    public Order(int orderId, List<Product> products)
    {
        this.orderId = orderId;
        this.products = products;
    }

    public int OrderId
    {
        get { return orderId; }
    }

    public List<Product> Products
    {
        get { return products; }
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.Price;
        }
        return total;
    }

    public void DisplayOrderInfo()
    {
        Console.WriteLine($"Order ID: {orderId}, Total: ${CalculateTotal()}");
        Console.WriteLine("Products:");

        foreach (var product in products)
        {
            Console.WriteLine($"- {product.Name}: ${product.Price}");
        }
    }
}
