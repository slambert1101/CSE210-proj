using System;

class Address
{
    private string _streetAdd;
    private string _city;
    private string _province;
    private string _country;

    public Address(string streetAdd, string city, string province, string country)
    {
        _streetAdd = streetAdd;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool InUSA()
    {
        if(_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string FullAddress()
    {
        return $"{_streetAdd}, {_city}, {_province}, {_country}";
    }
}