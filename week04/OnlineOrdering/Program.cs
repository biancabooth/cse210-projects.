using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");


        Address a1 = new Address ("300 N Main St","Centerville","Utah","USA");
        Costumer c1 = new Costumer ("Ana Doe",a1);
        Order order1 = new Order (c1);

        Product p1 = new Product("Hangers","AA123",7.99,2);
        Product p2 = new Product("Stool","AA345",7.99,1);

        order1.AddProduct(p1);
        order1.AddProduct(p2);
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
       Console.WriteLine($"{order1.TotalPrice()}$");
       Console.WriteLine();

       Address a2 = new Address ("350 N Main St","Centerville","Utah","USA");
        Costumer c2 = new Costumer ("Ana Doe",a2);
        Order order2 = new Order (c2);

        Product p3 = new Product("Shoes","AA123",50.99,2);
        Product p4 = new Product("Dress","AA345",25.99,1);

        order2.AddProduct(p3);
        order2.AddProduct(p4);
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
       Console.WriteLine($"{order2.TotalPrice()}$");

    }
}