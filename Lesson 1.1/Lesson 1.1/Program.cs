using System;

namespace Lesson_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            int d = 0;
            int i = 2;

            while (i<n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                else
                {
                    i++;
                }

                  if (d == 0)
            {
                Console.WriteLine("Простое");
            }
            else
            {
                Console.WriteLine("Не простое");
            }
          
            }


        }
    }
}
