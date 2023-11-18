using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("задано число N — количество элементов в массиве");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 100)
        {
            Console.WriteLine("Количество элементов в массиве должно быть не больше 100");
            return;
        }


        Console.WriteLine("Далее запишите N чисел — элементы массива через пробел.");
        string[] h = Console.ReadLine().Split(' ');
        if (h.Length != n)
        {
            Console.WriteLine("Количество чисел не соответствует заданному количеству элементов в массиве");
            return;
        }
        Console.WriteLine("Ответ:");
        int[] k = new int[n];
        int sum = 0;



        for (int i = 0; i < n; i++)
        {
            if (!int.TryParse(h[i], out k[i]) || Math.Abs(k[i]) > 100)
            {
                Console.WriteLine("Элементы массива должны быть целыми числами, каждое из которых по модулю не превосходит 100");
                return;
            }
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
