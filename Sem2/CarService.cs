using PedalCarAccountingInformationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccauntingInformationSystem;
public class CarService : ICarProvider
{
    /// <summary>
    /// Коллекция для хранения автомобилей
    /// </summary>
    private readonly LinkedList<Car> _cars = new();

    private int number = 1;

    public Car? GetCar(EngineType engineType)
    {
        var car = _cars.FirstOrDefault(car => car.Engine.Type == engineType);

        if (car != null)
            _cars.Remove(car);

        return car;
    }

    public void AddCar<TParams>(ICarFactory<TParams> carFactory, TParams carParams)
        where TParams : EngineParamsBase
    {
        var car = carFactory.CreateCar(carParams, number++);
        _cars.AddLast(car);
    }
}

