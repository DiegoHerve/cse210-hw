using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _productList;
    private Customer _customerInfo;

    public Order(Customer customerInfo)
    {
        _productList = new List<Product>();
        _customerInfo = customerInfo;
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public double CalculateOrderPrice()
    {
        double total = 0;

        foreach (Product product in _productList)
        {
            total += product.PriceForProduct();
        }

        if (_customerInfo.InUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";

        foreach (Product product in _productList)
        {
            label += product.GetName() + " - " + product.GetProductId() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL\n";

        label += _customerInfo.GetName() + "\n";
        label += _customerInfo.GetAddress().GetFullAddress();

        return label;
    }
}
