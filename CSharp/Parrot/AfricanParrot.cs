using System;

namespace Parrot;

public class AfricanParrot(int numberOfCoconuts, int voltage, bool isNailed) : Parrot(numberOfCoconuts, voltage, isNailed)
{
    public override double GetSpeed()
    {
        return Math.Max(0, BaseSpeed - NumberOfCoconutsLoadFactor);
    }

    public override string GetCry()
    {
        return "Sqaark!";
    }
}