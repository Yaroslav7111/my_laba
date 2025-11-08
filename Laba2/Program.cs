using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();


        int babyka = 0;
        foreach (int c in input )
        {
            if (c == 'I' )
                babyka++;
            else if (c  "IV" )
                babyka+=4;
            else if (c == 'V')
                babyka+=10;
            else if (c == 'X' )
                babyka+=5;
        }

        Console.WriteLine($"Сумма = {babyka}");


    }
}
