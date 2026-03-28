using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address a1 = new Address("18 de Julio 934", "Montevideo", "Montevideo", "Uruguay");
        Customer c1 = new Customer("Jhon", a1);

        Order o1 = new Order(c1);
        

    }
}