using System;

class Program
{
    static void Main()
    {
        // Ввод размера массива
        Console.Write("Введите размер массива n: ");
        int n = int.Parse(Console.ReadLine());

        // Ввод элементов массива
        int[,] mas = new int[n, n];
        Console.WriteLine("Введите элементы массива через пробел наприер 12 31 13 :");
                                                                            
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                mas[i, j] = int.Parse(input[j]);
            }
        }

        // Вывод введенной матрицы
        Console.WriteLine("Введенная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(mas[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Проверка на симметрию
        bool flag = true;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mas[i, j] != mas[j, i])
                {
                    flag = false;
                    break;
                }
            }
            if (!flag)
                break;
        }

        // Вывод результата
        if (flag)
            Console.WriteLine("Матрица симметрична");
        else
            Console.WriteLine("Матрица не симметрична");

        Console.ReadKey();
    }
}