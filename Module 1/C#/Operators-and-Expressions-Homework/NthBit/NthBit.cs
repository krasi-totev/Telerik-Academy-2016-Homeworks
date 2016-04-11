using System;
class NthBit
{
    static void Main()
    {
        long p = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

            int mask = 1 << n;
            long pAndMask = p & mask;
            long bit = pAndMask >> n;
            Console.WriteLine(bit);
    }
}
