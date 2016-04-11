using System;
using System.Text;

class BitSwap
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        uint mask = (uint)Math.Pow(2, k) - 1;
        uint result1 = (uint)number & (mask << p);
        result1 >>= p;
        uint result2 = (uint)number & (mask << q);
        result2 >>= q;
        number &= ~(mask << p);
        number &= ~(mask << q);
        number |= (result2 << p);
        number |= (result1 << q);
        Console.WriteLine(number);
    }
}