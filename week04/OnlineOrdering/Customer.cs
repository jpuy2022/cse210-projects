public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string getName()
    {
        return _name;
    }
    public string getAddress()
    {
        return _address.getFullAddress();
    }
    public bool inUSA()
    {
        return _address.isUSA();
    }

}