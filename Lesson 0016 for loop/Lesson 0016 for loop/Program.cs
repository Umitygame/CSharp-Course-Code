using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0016_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*char r;
            for (r = 'a'; r <= 'z'; r++)
                Console.WriteLine(r);*/

            //برنامج لحساب جدول الضرب
            int a, b, c;
            for (a = 1; a <= 10; a++)

                for (b = 1; b <= 10; b++)
                {
                    c = a * b;
                    Console.WriteLine(a + "*" + b + "=" + c+"\n_________");
                }

           


                    // كل الاكسي كود من رقم الى رمز او بالعكس ركز
                    char r1;
            for (r1 = '\x0'; r1 <= 'ي'; r1++)
                Console.WriteLine("______________\nxcode ("+r1+")="+(int)r1);
            Console.ReadKey();
        }
    }
}
