using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        try
        {
            int count = 0;
            foreach (int item in myList)
            {
                if (count >= n)
                    break;
                Console.WriteLine(item);
                count++;
            }
            return count;
        }
        catch
        {
            return 0;
        }
    }
}
