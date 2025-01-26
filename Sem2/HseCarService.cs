using PedalCarAccountingInformationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccauntingInformationSystem;
public class HseCarService
{
    /// <summary>
    /// Сервис предоставляющий нам автомобили
    /// </summary>
    private readonly ICarProvider _carProvider;

    /// <summary>
    /// Сервис предоставляющий нам покупателей
    /// </summary>
    private readonly ICustomersProvider _customersProvider;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    public HseCarService(ICarProvider carProvider, ICustomersProvider customersProvider)
    {
        _carProvider = carProvider;
        _customersProvider = customersProvider;
    }

    public void SellCars()
    {
        var customers = _customersProvider.GetCustomers();

        foreach (var customer in customers)
        {
            if (customer.Car != null)
            {
                continue;
            }

            var suitableEngineType = DetermineEngineType(customer);

            if (!suitableEngineType.HasValue)
            {
                continue;
            }

            var car = _carProvider.GetCar(suitableEngineType.Value);

            if (car == null)
                continue;

            customer.Car = car; // иначе вручаем автомобиль
        }
    }


    private static EngineType? DetermineEngineType(Customer customer)
    {
        if (customer.LegStrength > 5)
            return EngineType.Pedal;

        if (customer.HandStrength > 5)
            return EngineType.Hand;

        return null;
    }
}

