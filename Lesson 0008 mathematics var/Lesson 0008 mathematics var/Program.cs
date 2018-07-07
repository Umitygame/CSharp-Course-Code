using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0008_mathematics_var
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 19.3;
            double num2 = 17.4;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);
            int num3 = 9, num4 = 98, r;
            r = num3 / num4;
            Console.WriteLine(r);

            double num5 = 5;
            num5 += 5;
            num5 *= 5;
            num5 -= 5;
            num5 /= 5;
            num5 %= 5;
            Console.WriteLine(num5);
            string type = "ali";
            type += " ";
            type += "mohamed" + " " + "omr";
            Console.WriteLine(type);
            Console.ReadKey();
            // type -= " ";خطا لا يجوز فقط الجمع يرهم مع النصوص

        }
    }
}
