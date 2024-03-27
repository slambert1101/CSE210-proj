using System;

class Product
{
    private string _name;
    private int _ID;
    private decimal _price;
    private int _quantity;


    public Product(string name, int ID, decimal price, int quantity)
    {
        _name = name;
        _ID = ID;
        _price = price;
        _quantity = quantity;

    }

    public decimal TotalPrice()
    {
        decimal total = _price * _quantity;
        return total;
    }
}