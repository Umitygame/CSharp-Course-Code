using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0007_merge_and_naming_varaibles
{
    class Program
    {
        static void Main(string[] args)
        {

            char \u006eame1 = 'h';// استخدم اليوني كود للحرف الاول
            char \u006eame2 = 'i';
            int Int = 9;
            string @string = "hloo"//نستطيع ان ننزل سطر لاكمال النص لكن في 
                                    //نهايه السطر فارزه منقوطه
                 + " "
                 + "ali"
                 + " number";
            string num1 = "mohamed";
            string num2 = " and";
            string num3 = " amr";
            string numAll = num1 + num2 + num3;


            Console.WriteLine(\u006Eame1//نستطيع ان ننزل سطر لاكمال في الطباعه لكن في 
                                        //نهايه السطر فارزه منقوطه
                + ""
                + \u006Eame2
                + " "
                + @string + Int
                + " ok"
                + "\n" + numAll);
            Console.ReadKey();
        }
    }
}
