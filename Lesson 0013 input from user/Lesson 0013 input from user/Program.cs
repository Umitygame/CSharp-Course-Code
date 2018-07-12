using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0013_input_from_user
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1;
            Console.Write("enter you name :");
            str1 = Console.ReadLine();//input user 
            Console.WriteLine("welcome " + str1);


            string str2;
            string str3, str4;
            Console.Write("enter number1 :");
            str2 = Console.ReadLine();
            Console.Write("enter number2:");
            str3 = Console.ReadLine();
            Console.Write("enter number3:");
            str4 = Console.ReadLine();

            Double r;
            r = Convert.ToDouble(str2)+ double.Parse(str3) + Double.Parse(str4);

            Console.WriteLine("Total=" + r);
        

            int p= 999;
            String z;
            z =p.ToString();//هذه فقط لتحويل الارقام الى نصوص ولا يجوز العكس
            z = p+"";//هذه فقط لتحويل الارقام الى نصوص ولا يجوز العكس



            /*int a;
            a  = Console.ReadLine(); لا يجوز تعرف المتغير رقمي في الادخال 
            فقط نصي ثم يحول النص الى رقم هذا الكود خطا */


        }
    }
}
