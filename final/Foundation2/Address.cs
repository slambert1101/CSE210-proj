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

}