//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;
class AgeAfterTenYears
{
    static void Main()
    {
        string myBirthday = Console.ReadLine();
        DateTime birthDate = DateTime.Parse(myBirthday);
        DateTime today = DateTime.Today;

        int age = today.Year - birthDate.Year;

        if (today.Month < birthDate.Month)
        {
            age -= 1;
        }
        Console.WriteLine(age);
        Console.WriteLine(age + 10);
   
    }
}
