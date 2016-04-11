//Declare five variables choosing for each of them the most appropriate of the types 
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
//52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it.Try to compile the code.

using System;
class Program
{
    static void Main()
    {
        for (int i = 33; i <= 126; i++)
        {
            Console.Write((char)i);
        }
    }
}