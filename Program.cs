using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgTetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[10] { 10, 25, 40, 123, 523, 1236, 51, 3100, 86, 91};

            Max(test);
            Kivalaszt(test);
        }

        public static void Max(int[] test)
        {
            int max = test[0];
            for (int i = 0; i < test.Length; i++)
            {
                if (max < test[i])
                {
                    max = test[i];
                }
            }
            Console.WriteLine(max + "\n");
        }

        public static void Kivalaszt(int[] test)
        {
            Console.Write("Adjon meg egy számot: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Adjon meg egy másik számot: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                int num3;
                num3 = num1;
                num1 = num2;
                num2 = num3;
            }

            List<int> nums = new List<int>();

            foreach (int num in test)
            {
                if ((num1 < num) && (num2 > num))
                {
                    nums.Add(num);
                }
            }
            nums.Sort();

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
