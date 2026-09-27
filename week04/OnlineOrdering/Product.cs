using System;

public class Product
{
    private string _productId;
    private double _productPrice;
    private int _quantity;
    private string _productName;

    public Product(string productId, string productName, double productPrice, int quantity)
    {
        _productId = productId;
        _productName = productName;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    public double PriceForProduct()
    {
        return _productPrice * _quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }
}
