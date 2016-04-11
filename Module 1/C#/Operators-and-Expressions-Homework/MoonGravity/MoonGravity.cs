using System;
class MoonGravity
{
    static void Main()
    {
        double w = double.Parse(Console.ReadLine());

        double moonWeight = w * 17 / 100;

        Console.WriteLine("{0:F3}", moonWeight);
    }
}
