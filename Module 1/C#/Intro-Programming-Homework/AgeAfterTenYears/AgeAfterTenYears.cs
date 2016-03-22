//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;
class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("What is your birth date?");
        Console.Write("Day: ");
        string day = Console.ReadLine();

        Console.Write("Month (with digits): ");
        string month = Console.ReadLine();

        Console.Write("Year: ");
        string year = Console.ReadLine();

        string myBirthday = month + "/" + day + "/" + year;
        DateTime birthDate = DateTime.Parse(myBirthday);
        DateTime today = DateTime.Today;

        int age = today.Year - birthDate.Year;

        if (today.Date < birthDate.Date)
        {
            age -= 1;
        }
        Console.WriteLine("-----------------------");
        Console.WriteLine(" Born: " + birthDate.ToString("dd MMMM yyyy"));
        Console.WriteLine("-----------------------");
        Console.WriteLine(" Age: " + age + " years old!");
        Console.WriteLine("-----------------------");
    }
}
