// ShoppingCart.cs
using System;
using System.Collections.Generic;

public class ShoppingCart
{
    private List<Product> items;

    public ShoppingCart()
    {
        this.items = new List<Product>();
    }

    public void AddItem(Product product)
    {
        items.Add(product);
    }

    public List<Product> Items
    {
        get { return items; }
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var item in items)
        {
            total += item.Price;
        }
        return total;
    }
}
