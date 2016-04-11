using System;
class SumOfFiveNumbers
{
    static void Main()
    {
        int result = 0;

        for (int i = 0; i < 5; i++)
        {
            int currentInput = int.Parse(Console.ReadLine());
            result += currentInput;
        }

        Console.WriteLine(result);
    }
}
