using System;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()); // количество чисел в таблице
        int[] temperatures = new int[n];

        // Считываем значения температуры из входных данных
        for (int i = 0; i < n; i++)
        {
            temperatures[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Перебираем значения температуры и ищем локальные минимумы и максимумы
        for (int i = 1; i < n - 1; i++)
        {
            if (temperatures[i] < temperatures[i - 1] && temperatures[i] < temperatures[i + 1])
            {
                Console.WriteLine("day {0}: {1} (min)", i + 1, temperatures[i]);
            }
            else if (temperatures[i] > temperatures[i - 1] && temperatures[i] > temperatures[i + 1])
            {
                Console.WriteLine("day {0}: {1} (max)", i + 1, temperatures[i]);
            }
        }
    }
}