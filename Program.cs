using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 16, 17, 15, 0, 20, 1, 1, 2 };
        int n = arr.Length;
        int maxLoad = 0, load = 0, diff = 0;
        load = arr.Sum();
        
        if (load % n != 0)
        {
            Console.WriteLine(-1);
            return;
        }
        
        load /= n;

        for (int i = 0; i < n; i++)
        {
            diff += (arr[i] - load);

            if (diff < 0)
                maxLoad = Math.Max(maxLoad, -diff);
            else
                maxLoad = Math.Max(maxLoad, diff);
        }
        
        Console.WriteLine(maxLoad);
    }
}