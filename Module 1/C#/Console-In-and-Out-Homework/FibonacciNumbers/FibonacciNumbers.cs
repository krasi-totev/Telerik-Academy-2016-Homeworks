using System;
class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 0 || n == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            long first = 0;
            long second = 1;

            Console.Write("0, 1, ");

            for (int i = 2; i < n; i++)
            {
                long third = first + second;

                if (i == n-1)
                {
                    Console.WriteLine(third);
                }
                else
                {
                    Console.Write(third + ", ");
                }
                first = second;
                second = third;
            }
        }   
    }
}
