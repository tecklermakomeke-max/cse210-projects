public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string n, Address a) { _name=n; _address=a; }
    public bool LivesInUSA() => _address.IsInUSA();
    public string GetName() => _name;
    public Address GetAddress() => _address;
}