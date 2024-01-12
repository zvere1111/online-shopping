// Product.cs
using System;

public class Product
{
    private string name;
    private double price;

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public string Name
    {
        get { return name; }
    }

    public double Price
    {
        get { return price; }
    }
}
