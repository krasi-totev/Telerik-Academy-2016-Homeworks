using System;
class ThirdDigit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int thirdDigit = (n % 1000) / 100;

        if (thirdDigit == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false " + thirdDigit);
        }
    }
}
