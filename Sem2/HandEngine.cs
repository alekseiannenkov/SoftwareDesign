using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedalCarAccountingInformationSystem;

namespace PedalCarAccauntingInformationSystem;

/// <summary>
/// Ручной двигатель
/// </summary>
public class HandEngine : IEngine
{
    public EngineType Type => EngineType.Hand;

    bool IEngine.IsСompatible(Customer customer)
    {
        return customer.HandStrength > 5;
    }

    public override string ToString()
        => $"Тип: {Type}";
}