using System.Net.Http.Headers;

public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name, string fullAddress)
    {
        _name = name;
        string[] lines = fullAddress.Split(',');
        string street = lines[0];
        string city = lines[1];
        string province = lines[2];
        string state = lines[3];
        Address address = new(street, city, province, state);
        _address = address;
    }
    public bool LivesInTheUS()
    {
        return _address.IsInAmerica();
    }

    public string GetCustomerResidence()
    {
        return $"{_name}, Living at {_address.DisplayAddress()}";
    }

}