using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        // Add shipping cost based on customer location
        double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
        
        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        packingLabel.AppendLine("Packing Label:");
        
        foreach (Product product in _products)
        {
            packingLabel.AppendLine($"{product.GetName()} - ID: {product.GetProductId()}");
        }
        
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder shippingLabel = new StringBuilder();
        shippingLabel.AppendLine("Shipping Label:");
        shippingLabel.AppendLine(_customer.GetName());
        shippingLabel.AppendLine(_customer.GetAddress().GetFullAddress());
        
        return shippingLabel.ToString();
    }
}