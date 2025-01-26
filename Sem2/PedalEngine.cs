using System.Runtime.CompilerServices;
using PedalCarAccauntingInformationSystem;

namespace PedalCarAccountingInformationSystem;
public class PedalEngine : IEngine
{
    public int PedalSize { get; set; }

    public EngineType Type => EngineType.Pedal;

    public PedalEngine(int pedalSize)
    {
        PedalSize = pedalSize;
    }

    bool IEngine.IsСompatible(Customer customer)
    {
        return customer.LegStrength > 5;
    }

    public override string ToString()
        => $"Тип: {Type}, Размер педалей: {PedalSize}";

}


