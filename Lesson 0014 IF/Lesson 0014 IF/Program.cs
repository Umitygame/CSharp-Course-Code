using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0014_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number1=");

            double str1  = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter number2=");

            double str2 = double.Parse(Console.ReadLine());

            if (str1 > str2)
            {
                Console.WriteLine("number1 > number2");
            }
            if (str1 < str2)
            {
                Console.WriteLine("number1 < number2");
            }
            if (str1 == str2)
            {
                Console.WriteLine("number1 = number2");
            }
            double r = str1 + str2;
            Console.WriteLine("sum="+r);




            Console.WriteLine("enter name one:-\n1-ali omer 2-omr mohamed");

            string str = Console.ReadLine();
            if(str== "ali omer")
            {
                Console.WriteLine("ali is good boy");
            }
            if (str =="omr mohamed")
            {
                Console.WriteLine("this man is sly and burglar");
            }
            else
            {
                Console.WriteLine("Error");

            }



            //اداة شرط جديدة
            Console.Write("enter number= ");
            double pp = double.Parse(Console.ReadLine());
            //اذا تحقق الشرط"pass" يجب ان يكون المتغير نصي لاننا ندخل نصوص اما 
            //اذا لم يتحقق الشرط"faild" او 
            //اذا كان المتغير رقم يجب ان يكون الشرط رقم واذا متغير منطقي كذالك 
            string String =(pp > 50) ? "pass" : "faild";
            //string String = (c > 12) ? 2 : 7;خطا لان المتغير نصي والشرط رقمي
            Console.WriteLine(String);

            Console.ReadKey();
        }
    }
}
