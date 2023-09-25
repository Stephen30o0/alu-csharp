using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length <= 0)
        {
            Console.WriteLine();
        }
        else
        {
            string line = new string('_', length);
            Console.WriteLine(line);
        }
    }

    static void Main(string[] args)
    {
        Line.PrintLine(3);
        Line.PrintLine(0);
        Line.PrintLine(12);
        Line.PrintLine(-98);
    }
}
