using System;
class NumberComparer
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());

        if (n >= m)
        {
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine(m);
        }
    }
}
