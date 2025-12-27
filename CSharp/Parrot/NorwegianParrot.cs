namespace Parrot;

public class NorwegianParrot(int numberOfCoconuts, double voltage, bool isNailed) : Parrot(numberOfCoconuts, voltage, isNailed)
{
    public override double GetSpeed()
    {
        return isNailed ? 0 : GetBaseSpeed(voltage);
    }

    public override string GetCry()
    {
        return voltage > 0 ? "Bzzzzzz" : "...";
    }
}