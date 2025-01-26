using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedalCarAccountingInformationSystem;

namespace PedalCarAccauntingInformationSystem;

/// <summary>
/// Интерфейс для описания двигателя
/// </summary>
public interface IEngine
{
    /// <summary>
    /// Тип двигателя
    /// </summary>
    EngineType Type { get; }

    public bool IsСompatible(Customer customer);
}