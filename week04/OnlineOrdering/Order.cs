using System.Collections.Generic;
public class Order
{
    private List<Product> _products = new();
    private Customer _customer;
    public Order(Customer c) => _customer = c;
    public void AddProduct(Product p) => _products.Add(p);
    public double GetTotalPrice()
    {
        double t=0;
        foreach(var p in _products) t+=p.GetTotalCost();
        t+= _customer.LivesInUSA() ? 5 : 35;
        return t;
    }
    public string GetPackingLabel()
    {
        string s="Packing:\n";
        foreach(var p in _products) s+=$"{p.GetName()} ({p.GetProductId()})\n";
        return s;
    }
    public string GetShippingLabel() => $"Shipping:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
}