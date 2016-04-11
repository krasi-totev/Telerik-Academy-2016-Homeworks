using System;
class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double radius = 2;
        double point = x * x + y * y;

        double diference = Math.Sqrt(x * x + y * y);

        bool isInCircle = point <= radius * radius;

        if (isInCircle)
        {
            Console.WriteLine("yes " + diference.ToString("F2"));
        }
        else
        {
            Console.WriteLine("no " + diference.ToString("F2"));
        }
        
    }
}
