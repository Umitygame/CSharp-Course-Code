﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0011_Convert_Varaibles
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=91.9;
            int b ;
           //  b = Convert.ToInt32(a);// intالى doubleتم تحويل متغير من نوع 
            // b = Convert.Toint(a);  Toint لا يجوز كتابه الانتجر بالحرف الصغير
            b = (int)a;// intالى doubleتم تحويل متغير من نوع 
            //doubleوليسintكانما نقول هذا المتغير من نوع 
            Console.WriteLine(b);
          //  Console.ReadKey();



            object name1 = "omr";
            string name2;
               name2 =(string) name1;
            Console.WriteLine(name2);
         //   Console.ReadKey();





            // unicode (int; char; .....)الاكسي كود
            char c = 'p';
            int x;
            x = c;//هذه الحاله يقبل بها لكن العكس لا يجوز
            int ba = 89;
            char s;
            s =(char) ba;//لا يقبل يجب التحويل

            Console.WriteLine(s+" "+(char)55+" "+(int)'t');// الاكسي كودunicode
            Console.ReadKey();
            // (" ") عند الطباعه يجب ان تضع مسافه حتى لا يظهر خطا مثل
        }
    }
}