using PedalCarAccountingInformationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccauntingInformationSystem;
/// <summary>
/// Реализация фабрики для создания педальных автомобилей
/// </summary>
public class PedalCarFactory : ICarFactory<PedalEngineParams>
{
    /// <summary>
    /// Реализация метода для создания педальных автомобилей
    /// </summary>
    private static readonly Random _random = new();
    public Car CreateCar(PedalEngineParams carParams, int number)
    {
        var engine = new PedalEngine(carParams.PedalSize);
        return new Car(engine, number);
    }
}

