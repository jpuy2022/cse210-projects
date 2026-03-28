public class Order{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product p)
    {
        _products.Add(p);
    }
    public double CalculateTotal()
    {
        double total = 0;
        int delivery = 0;
        foreach (Product p in _products)
        {
            if (_customer.inUSA())
            {
                delivery = 5;
            }
            else
            {
                delivery = 35;
            }
            total = total + delivery;
        }

        return total;
    }

    public string getPackLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label = label + $"{p.getName()}, ID: {p.getId()}";
        }
        return label;
    }
    
    public string getShippingLabel()
    {
        string label = $"{_customer.getName()}\n{_customer.getAddress()}";
        return label;
    }
}