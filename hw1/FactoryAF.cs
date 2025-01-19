namespace PedalCarAccountingInformationSystem;
public class FactoryAF
{
    public Stack<Car> Cars { get; set; }
    public List<Customer> Customers { get; set; }

    public FactoryAF(List<Customer> customers)
    {
        Customers = customers;

        Cars = new Stack<Car>();
    }

    public void SaleCar()
    {
        foreach (var customer in Customers)
        {
            if (customer.Car == null)
            {
                if (Cars.Count == 0)
                {
                    break;
                }
                customer.Car = Cars.Pop();
            }
        }
        Cars.Clear();
    }

    public void AddCar(Car car)
    {
        Cars.Push(car);
    }

    public void AddCar()
    {
        Car car = new Car(Cars.Count + 1);
        Cars.Push(car);
    }
}