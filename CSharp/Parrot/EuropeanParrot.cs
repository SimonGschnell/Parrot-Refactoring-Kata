namespace Parrot;

public class EuropeanParrot(int numberOfCoconuts, double voltage, bool isNailed) : Parrot(numberOfCoconuts, voltage, isNailed)
{
    public override double GetSpeed()
    {
        return GetBaseSpeed();
    }

    public override string GetCry()
    {
        return "Sqoork!";
    }
}