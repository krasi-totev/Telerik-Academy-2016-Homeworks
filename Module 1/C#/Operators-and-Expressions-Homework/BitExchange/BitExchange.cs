using System;
class BitExchange
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        long mask1 = 7 << 3;
        long mask2 = 7 << 24;
        long mask3 = n >> 21;
        long mask4 = n << 21;
        long farBits = mask1 & mask3;
        long closeBits = mask2 & mask4;

        long maskForZeroes = ~(7 << 3);
        long zeroes = n & maskForZeroes;

        long result = zeroes | farBits;

        long maskForZeroes2 = ~(7 << 24);
        long zeroes2 = result & maskForZeroes2;

        long result2 = zeroes2 | closeBits;

        Console.WriteLine(result2);
    }
}
