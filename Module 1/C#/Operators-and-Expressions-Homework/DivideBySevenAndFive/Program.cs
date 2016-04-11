using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 5 == 0 && n % 7 == 0)
        {
            Console.WriteLine("true " + n);
        }
        else
        {
            Console.WriteLine("false " + n);
        }
    }
}
