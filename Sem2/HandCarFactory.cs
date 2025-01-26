using PedalCarAccountingInformationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccauntingInformationSystem;
/// <summary>
/// Реализация фабрики для создания ручных автомобилей
/// </summary>
public class HandCarFactory : ICarFactory<EngineParamsBase>
{
    /// <summary>
    /// Реализация метода для создания ручных автомобилей
    /// </summary>
    private static readonly Random _random = new();
    public Car CreateCar(EngineParamsBase carParams, int number)
    {
        var engine = new HandEngine();
        return new Car(engine, number);
    }
}