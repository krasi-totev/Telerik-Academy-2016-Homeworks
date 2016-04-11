using System;
class FourDigits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstDigit = n / 1000;
        int secondDigit = (n / 100) % 10;
        int thirdDigit = (n / 10) % 10;
        int lastDigit = n % 10;

        Console.WriteLine(firstDigit + secondDigit + thirdDigit + lastDigit);
        Console.WriteLine(lastDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + firstDigit.ToString());
        Console.WriteLine(lastDigit.ToString() + (n / 10));
        Console.WriteLine(firstDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + lastDigit.ToString());
    }
}
