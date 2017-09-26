﻿namespace Exer_12_TestNumbers
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            bool check = false;


            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    counter++;
                    sum += 3 * i * j;
                    if (sum >= max)
                    {
                        check = true;
                        Console.WriteLine("{0} combinations", counter);
                        Console.WriteLine("Sum: {0} >= {1}", sum, max);
                        break;
                    }
                }
                if (sum >= max)
                {
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0}", sum);

            }

        }
    }
}
