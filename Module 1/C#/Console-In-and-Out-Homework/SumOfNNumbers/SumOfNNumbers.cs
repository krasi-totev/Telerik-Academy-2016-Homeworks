using System;
class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            int currentInput = int.Parse(Console.ReadLine());
            result += currentInput;
        }
        Console.WriteLine(result);
    }
}
