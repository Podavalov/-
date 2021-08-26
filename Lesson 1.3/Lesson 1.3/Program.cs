using System;

namespace Lesson_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Fibonachi(int n)  //рекурсия
            {
                if (n == 0 || n == 1)
                {
                    return n;
                }
                else
                {
                    return Fibonachi(n - 1) + Fibonachi(n - 2);
                }
            }
            static int Fb(int n)    // цикл
            {
                int a = 0;
                int b = 1;
                int tmp;

                for (int i = 0; i < n; i++)
                {
                    tmp = a;
                    a = b;
                    b += tmp;
                }

                return a;
            }



        }

    }
}
