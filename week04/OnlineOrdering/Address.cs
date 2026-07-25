public class Address
{
    private string _streetAddress;
    private string _city;
    private string _province;
    private string _country;
    public Address(string street, string city, string province, string country)
    {
        _streetAddress = street.Trim();
        _city = city.Trim();
        _province = province.Trim();
        _country = country.Trim();
    }
    public bool IsInAmerica()
    {
        return _country == "USA";
    }

    public string DisplayAddress()
    {
        return $"{_streetAddress},\n{_city} {_province},\n{_country}";
    }
}