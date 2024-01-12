// Customer.cs
using System;
using System.Collections.Generic;

public class Customer
{
    private string name;
    private string email;
    private List<Order> orders;

    public Customer(string name, string email)
    {
        this.name = name;
        this.email = email;
        this.orders = new List<Order>();
    }

    public string Name
    {
        get { return name; }
    }

    public string Email
    {
        get { return email; }
    }

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer Name: {name}, Email: {email}");
        Console.WriteLine("Orders:");

        foreach (var order in orders)
        {
            order.DisplayOrderInfo();
            Console.WriteLine();
        }
    }
}
