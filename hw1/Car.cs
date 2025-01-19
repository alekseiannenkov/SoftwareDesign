using System;

namespace PedalCarAccountingInformationSystem;
public class Car
{
    private static readonly Random _random = new();
    public Engine Engine { get; private set; }
    public int Number { get; private set; }

    public Car()
    {
        Engine = new Engine(_random.Next(1, 100));
    }
    public Car(int number)
    {
        Engine = new Engine(_random.Next(1, 100));
        Number = number;
    }

    public override string ToString()
    {
        return $"Номер: {Number}, Размер педалей: {Engine.PedalSize}";
    }
}
