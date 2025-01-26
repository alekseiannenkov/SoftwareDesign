using PedalCarAccountingInformationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccauntingInformationSystem;
public interface ICustomersProvider
{
    /// <summary>
    /// Возвращает покупателей в очереди за машиной
    /// </summary>
    IEnumerable<Customer> GetCustomers();
}
