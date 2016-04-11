using System;
class PointCircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double cx = 1;
        double cy = 1;
        double cr = 1.5;

        bool isInCircke = (x - cx) * (x - cy) + (y - cx) * (y - cy) <= cr * cr;
        bool isInRactangle = x >= -1 && x <= 5 && y >= -1 && y <= 1;


        if (isInCircke)
        {
            Console.Write("inside circle");
        }
        else
        {
            Console.Write("outside circle");
        }

        Console.Write(" ");

        if (isInRactangle)
        {
            Console.WriteLine("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");
        }
       
    }
}
