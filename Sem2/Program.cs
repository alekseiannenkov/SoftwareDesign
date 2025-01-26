using PedalCarAccountingInformationSystem;
using System.Xml.Linq;

namespace PedalCarAccauntingInformationSystem;

internal class Program
{
    static void Main(string[] args)
    {
        var customerStorage = new CustomerStorage();

        var customers = new[]
        {
            new Customer(name: "Ivan", legStrength: 6, handStrength: 4),
            new Customer(name : "Petr", legStrength : 4, handStrength : 6),
            new Customer(name : "Sidr", legStrength : 4, handStrength : 4),
            new Customer(name : "Sidr", legStrength : 6, handStrength : 6),
        };

        foreach (var customer in customers)
            customerStorage.AddCustomer(customer);

        var pedalCarFactory = new PedalCarFactory();
        var handCarFactory = new HandCarFactory();

        var carStorage = new CarService();

        carStorage.AddCar(pedalCarFactory, new PedalEngineParams(pedalSize: 2));
        carStorage.AddCar(pedalCarFactory, new PedalEngineParams(pedalSize: 3));
        carStorage.AddCar(handCarFactory, EmptyEngineParams.Empty);
        carStorage.AddCar(handCarFactory, EmptyEngineParams.Empty);

        var hseCarShop = new HseCarService(carStorage, customerStorage);

        Console.WriteLine("=== Покупатели ===");
        foreach (var customer in customers)
            Console.WriteLine(customer);

        Console.WriteLine("\n=== Продажа автомобилей ===\n");
        hseCarShop.SellCars();

        Console.WriteLine("=== Покупатели ===");
        foreach (var customer in customers)
            Console.WriteLine(customer);
    }


}