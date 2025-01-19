namespace PedalCarAccountingInformationSystem;
public class Customer
{
    public Car? Car { get; set; }
    public string Name { get; set; }

    public Customer(string name, Car? car = null)
    {
        Car = car;
        Name = name;
    }
    public override string ToString()
    {
        return $"Имя: {Name}, Номер машины: {Car?.Number ?? -1}";
    }
}
