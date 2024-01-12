// OnlineShoppingSystem.cs
using System;

class OnlineShoppingSystem
{
    static void Main()
    {
        Product product1 = new Product("Laptop", 1200.0);
        Product product2 = new Product("Headphones", 99.99);

        Customer customer = new Customer("John Doe", "john@example.com");

        ShoppingCart shoppingCart = new ShoppingCart();
        shoppingCart.AddItem(product1);
        shoppingCart.AddItem(product2);

        Order order = new Order(1, shoppingCart.Items);
        customer.AddOrder(order);

        Console.WriteLine("Customer Information:");
        customer.DisplayCustomerInfo();
    }
}
