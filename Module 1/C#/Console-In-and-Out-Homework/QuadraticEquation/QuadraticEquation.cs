using System;
class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine(Math.Min(x1, x2).ToString("F2"));
            Console.WriteLine(Math.Max(x1, x2).ToString("F2"));
        }
        else if (discriminant == 0)
        {
            double x1Andx2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("{0:F2}", x1Andx2);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}