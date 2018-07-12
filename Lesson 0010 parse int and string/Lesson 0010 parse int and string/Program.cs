using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0010_parse_int_and_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //تحويل النصوص الى ارقام

            //string num1 = "98";
            //double num2 = 2, r;
            //r = double.Parse(num1) + num2;//تحويل النص الى رقم
            //r = Double.Parse(num1) + num2;//تحويل النص الى رقم ثاني طريقه
            //r = Convert.ToDouble(num1) + num2;// تحويل النص الى رقم ثالث طريقه
            //Console.WriteLine(r);
            //Console.ReadKey();




            //تحويل الارقام الى نصوص
            double x=1500; ;
            string y;
            // y = Convert.ToString(x);
            y= x.ToString();//تحويل الرقم الى نص ثاني طريقه
           // y = x + "";//دمج// تحويل الرقم الى نص ثالث طريقه
            Console.WriteLine("car=" + y + "$");//هكذا تدمج النصوص مع الارقام عند الطباعه
            Console.ReadKey();

        }
    }
}
