namespace Parrot;

public abstract class Parrot(int numberOfCoconuts, double voltage, bool isNailed)
{
    private static double LoadFactor => 9.0;

    protected double NumberOfCoconutsLoadFactor => LoadFactor * numberOfCoconuts;
    
    protected virtual double BaseSpeed => 12.0;
    
    public abstract double GetSpeed();

    public abstract string GetCry();
}