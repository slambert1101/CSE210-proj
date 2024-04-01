using System;

class Address
{
    private string _streetAdd;
    private string _city;
    private string _province;
    

    public Address(string streetAdd, string city, string province)
    {
        _streetAdd = streetAdd;
        _city = city;
        _province = province;
        
    }


    public string FullAddress()
    {
        return $"{_streetAdd}. {_city}, {_province}";
    }
}