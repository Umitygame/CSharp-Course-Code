using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0004_data_types_var
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number1 = 255;
            sbyte number2 = -128;
            short number3 = -9999;
            ushort number4 = 9999;
            int number5 = -999999999;
            uint number6 = 111111111;
            long number7 = -999999999999991234;
            ulong number8 = 9999999999999999999;
            float number9 = 9999999f; // f(يجب ان ينتهي بحرف)
            double number10 = 123456789111111;
            decimal number11 = 9999999999999999999999999999m; //m(يجب ان ينتهي بحرف) 
            char print = 'p';
            string name = "ali ali";
            bool x = true;
            object y = false;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);
            Console.WriteLine(number6);
            Console.WriteLine(number7);
            Console.WriteLine(number8);
            Console.WriteLine(number9);
            Console.WriteLine(number10);
            Console.WriteLine(number11);
            Console.WriteLine(print);
            Console.WriteLine(name);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
