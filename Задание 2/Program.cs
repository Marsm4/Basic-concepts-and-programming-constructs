using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введит количество элементов в массиве 1<=N<=100:");
        Console.WriteLine("Введит n числа через пробел -∞<N<=100:");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] h = Console.ReadLine().Split(' ');
        int[] k = new int[n];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            k[i] = Convert.ToInt32(h[i]);
            int j = 0;
            for (; j < i; j++)
                if (k[i] + k[j] == 0)
                    break;
            if (i > j)
            {
                Console.Write($"{j} {i}");
                break;
            }
        }
        Console.ReadKey();
        }
}
