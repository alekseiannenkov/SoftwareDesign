using PedalCarAccountingInformationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccauntingInformationSystem;

public class CustomerStorage : ICustomersProvider
{
    /// <summary>
    /// Список покупателей
    /// </summary>
    public List<Customer> Customers { get; }
    public CustomerStorage()
    {
        Customers = new List<Customer>();
    }

    public IEnumerable<Customer> GetCustomers()
        => Customers.Where(customer => customer.Car == null);

    /// <summary>
    /// Добавление покупателя
    /// </summary>
    /// <param name="customer">Покупатель</param>
    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }
}