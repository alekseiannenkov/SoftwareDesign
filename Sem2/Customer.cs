namespace PedalCarAccountingInformationSystem;
public class Customer
{
    /// <summary>
    /// Машина
    /// </summary>
    public Car? Car { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Сила ног
    /// </summary>
    public uint HandStrength { get; }

    /// <summary>
    /// Сила рук
    /// </summary>
    public uint LegStrength { get; }

    public Customer(string name, uint legStrength, uint handStrength)
    {
        Name = name;
        LegStrength = legStrength;
        HandStrength = handStrength;
    }
    public override string ToString()
    {
        return $"Имя: {Name}, Номер машины: {Car?.Number ?? -1}," +
               $"Сила рук: {HandStrength}, Сила ног: {LegStrength}";
    }
}
