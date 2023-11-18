using System;

        Console.WriteLine("задайте количество дней когда вы измерели температуру ");
        int n = int.Parse(Console.ReadLine());

        int[] temperatures = new int[n];
        Console.WriteLine("Укажите значения температуры  ");

        for (int i = 0; i < n; i++)
        {
            temperatures[i] = int.Parse(Console.ReadLine());
        }


Console.WriteLine("Вывод:");
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
    

