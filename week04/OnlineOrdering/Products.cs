public class Product
{
    private string _name, _id;
    private double _price;
    private int _qty;
    public Product(string n, string id, double p, int q)
    { _name=n; _id=id; _price=p; _qty=q; }
    public double GetTotalCost() => _price * _qty;
    public string GetName() => _name;
    public string GetProductId() => _id;
}