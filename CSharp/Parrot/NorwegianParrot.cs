using System;

namespace Parrot;

public class NorwegianParrot(int numberOfCoconuts, double voltage, bool isNailed) : Parrot(numberOfCoconuts, voltage, isNailed)
{
    public override double GetSpeed()
    {
        return isNailed ? 0 : BaseSpeed;
    }

    protected override double BaseSpeed => Math.Min(24.0, voltage * base.BaseSpeed);

    public override string GetCry()
    {
        return voltage > 0 ? "Bzzzzzz" : "...";
    }
}