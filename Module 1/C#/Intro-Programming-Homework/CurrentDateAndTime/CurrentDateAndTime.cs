//Problem 14.* Current Date and Time

//Create a console application that prints the current date and time.Find out how in Internet.
using System;
public class CurrentDateAndTime
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Today is: " + today.ToString("dd MMM yyyy"));
    }
}
