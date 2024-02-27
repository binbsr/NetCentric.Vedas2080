using System;
using System.Linq;

class Helpers
{
    public void Print() => Console.WriteLine("Hello");

    public void Print(string greeting) => Console.WriteLine(greeting);

    internal float CalculateBMI(float heightInFt, float weightInKg = 50.0f) //weightInKg is optional
    {
        var heightInM = heightInFt / 3.14f;
        var bmi = weightInKg / (heightInM * heightInM); // kg/m^2
        return bmi;
    }

    public (int, int) GetYoungestAndEldest(params int[] ages) // tuples
    {
        var youngest = ages.Min();
        var eldest = ages.Max();

        return (youngest, eldest);
    }
}
