//Problem 16.* Print Long Sequence

//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).
using System;
public class PrintLongSequence
{
    static void Main()
    {
        int count = 0;

        for (int i = 2; i <= 1001; i++)
        {
            count++;
            if (count % 10 == 0)
            {
                Console.WriteLine();
            }
            if (i % 2 != 0)
            {
                Console.Write(i - 2 * i + ", ");
            }
            else
            {
                Console.Write(i + ", ");
            }
        }
        Console.WriteLine();
    }
}
