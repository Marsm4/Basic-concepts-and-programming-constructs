using System;

        Console.WriteLine("задано число N — количество элементов в массиве");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 100)
        {
            Console.WriteLine("Количество элементов в массиве должно быть не больше 100");
            return;
        }


        Console.WriteLine("Далее запишите N чисел.");
        int[] k = new int[n];

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out k[i]) || Math.Abs(k[i]) > 100)
            {
                Console.WriteLine("Элементы массива должны быть целыми числами, каждое из которых по модулю не превосходит 100");
                return;
            }
        }



        Console.WriteLine("Ответ:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (k[i] + k[j] == 0)
                {
                    Console.WriteLine($"{j} {i}");
                    return;
                }
            }
        }

        Console.ReadKey();
