using System;
class ModifyBit
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            ulong mask = (ulong)(~(1 << p));
            ulong result = (ulong)(n & mask);
            Console.WriteLine(result);
        }
        else
        {
            ulong mask = (ulong)1 << p;
            ulong result = (ulong)(n | mask);
            Console.WriteLine(result);
        }

    }
}
