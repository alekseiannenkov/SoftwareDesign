using PedalCarAccountingInformationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccauntingInformationSystem;

/// <summary>
/// Обобщенный интерфейс фабрики для создания автомобилей
/// </summary>
public interface ICarFactory<TParams>
    where TParams : EngineParamsBase
{
    /// <summary>
    /// Метод для конструкирования автомобилей
    /// </summary>
    Car CreateCar(TParams carParams, int number);
}