public class Address
{
    private string _street, _city, _state, _country;
    public Address(string s, string c, string st, string co)
    { _street=s; _city=c; _state=st; _country=co; }
    public bool IsInUSA() => _country == "USA";
    public string GetFullAddress() => $"{_street}\n{_city}, {_state}\n{_country}";
}