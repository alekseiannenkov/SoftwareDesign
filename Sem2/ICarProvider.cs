using PedalCarAccountingInformationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalCarAccauntingInformationSystem;

/// <summary>
/// Интерфейс, предоставляющий автомобили для покупателей
/// </summary>
public interface ICarProvider
{
    /// <summary>
    /// Получение автомобиля с соответствующим типом двигателя
    /// </summary>
    /// <param name="engineType">Тип двигателя</param>
    /// <returns>Возвращает подходящую машину, а если таких машин не осталось - null</returns>
    Car? GetCar(EngineType engineType);
}