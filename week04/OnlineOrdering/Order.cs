using System.Collections.Concurrent;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    List<Product> _product = new List<Product>();
    private Costumer _costumer;

     public Order(Costumer costumer)
    {
        _costumer = costumer;
        _product = new List<Product>();
       
    }
    public void AddProduct(Product product)
    {
        _product.Add(product);
    }
    public double TotalPrice()
    {
        double totalPrice = 0;
        foreach(Product p in _product)
        {
            totalPrice += p.GetPrice();
        }
        if (_costumer.CountryUsa())
        {
            totalPrice += 5.0;
        }
        else 
        {totalPrice +=35;}
        
    return totalPrice;
    }
    public string PackingLabel()
    {
       string pLabel = "";
        foreach(Product p in _product)
        {
         pLabel += $"{p.GetName()} {p.GetProductId()}\n";
        }
        Console.WriteLine("Packing Label: ");
        return pLabel;
    }
    public string ShippingLabel()
    {
       string sLabel = $"Shipping Label: \n{_costumer.GetName()}, {_costumer.GetAddress().AddressTogether()}";
       return sLabel;
    }


}