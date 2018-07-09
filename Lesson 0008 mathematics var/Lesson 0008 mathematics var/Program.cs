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
            // type -= " ";خطا لا يجوز فقط الجمع يرهم مع النصوص انه حالة دمج
            Console.WriteLine(type);





            Double x = 5;
            ++x;
            x++;
            --x;
            x--;
            x = x + 2;
            x = x - 3;
            x = 4 + x++;//لا تزيد واحد لانها اقل اسبقيه حتى x++
            //اقل اسبقيه من اليساوي وياتي التنفيذ بعد تنفيذ اليساوي
            Console.WriteLine("x="+x);

            



            int p = 9;
            int c = 8;
            bool b1 = p >= c;
            bool b2 = p > c;
            bool b3 = p == c;
            bool b4 = p <= c;
            bool b5= p < c;
            bool b6 = p != c;


            Console.WriteLine("(b1="+ b1
                +" )(b2= " + b2
                + ")( b3= " + b3
                + ")( b4= " + b4
                + ")( b5= " + b5
                + ")( b6= " + b6+")");

            Console.ReadKey();


        }
    }
}
