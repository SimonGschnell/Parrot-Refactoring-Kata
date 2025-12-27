using System;

namespace Parrot;

public class AfricanParrot(int numberOfCoconuts, double voltage, bool isNailed) : Parrot(numberOfCoconuts, voltage, isNailed)
{
    public override double GetSpeed()
    {
        return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * numberOfCoconuts);
    }

    public override string GetCry()
    {
        return "Sqaark!";
    }
}