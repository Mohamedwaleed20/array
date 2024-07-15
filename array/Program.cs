using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = Console.ReadLine().Split(' ');
        int x = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (Convert.ToInt32(arr[i]) == x)
            {
                Console.WriteLine(i);
                return;
            }
        }

        Console.WriteLine(-1);
    }
}