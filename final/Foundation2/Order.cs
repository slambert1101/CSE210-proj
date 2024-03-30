using System;

class Order
{

    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _products = products;
        _customer = customer;
    }
    public Order(Customer customer)
    {
        _customer = customer;
        _products = [];
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double TotalPrice()
    {
        double total = 0;
        foreach(Product product in _products)
        {
            total = total + product.TotalPrice();
        }
        
        if(_customer.InUSA() == true)
        {
            total = total + 5;
        }
        else
        {
            total = total + 35;
        }
        return total;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach(Product product in _products)
        {
            label = label + $"[[{product.GetName()}, ID{product.GetID()}]]";
        }
        return label;
    }

    public string ShippingLabel()
    {
        string label = "";
        label = $"{_customer.GetName()} :: {_customer.GetAddress().FullAddress()}";
        return label;
    }
}