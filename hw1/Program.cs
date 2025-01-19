using PedalCarAccountingInformationSystem;
using System.Xml.Linq;

namespace PedalCarAccauntingInformationSystem;

internal class Program
{
    static void Main(string[] args)
    {
        var customers = new List<Customer>
        {
            new Customer("Alex"),
            new Customer("Boris"),
            new Customer("Dmitry"),
            new Customer("Kirill"),
            new Customer("Le Dat")
        };

        var factory = new FactoryAF(customers);

        for (int i = 0; i < 5; i++)
        {
            factory.AddCar();
        }

        Console.WriteLine("Before");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));

        factory.SaleCar();

        Console.WriteLine("After");
        Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
        Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));
    }
}