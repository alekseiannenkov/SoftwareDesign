using System;
using PedalCarAccauntingInformationSystem;

namespace PedalCarAccountingInformationSystem;
public class Car
{
    public IEngine Engine { get; private set; }
    public int Number { get; private set; }

    public Car(IEngine engine, int number)
    {
        Engine = engine;
        Number = number;
    }

    public bool IsCompatible(Customer customer)
    {
        return Engine.IsСompatible(customer);
    }

    public override string ToString()
    {
        return $"Номер: {Number}, Двигатель: {Engine}";
    }
}
