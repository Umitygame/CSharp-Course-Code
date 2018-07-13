using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0011_Convert_Varaibles
{
    class Program
    {
        static void Main(string[] args)
            //تحوييل متغرات رقمية من غير نوع
        {//(int ,double,char,long) يمكن تحويل المتغيرات  
            //(string,int or double or long or char) لكن لا يمكن تحويل بين 
            char a='h';
            int b ;
           //  b = Convert.ToInt32(a);// intالى doubleتم تحويل متغير من نوع 
            // b = Convert.Toint(a);  Toint لا يجوز كتابه الانتجر بالحرف الصغير
            b = (int)a;// intالى doubleتم تحويل متغير من نوع 
            //doubleوليسintكانما نقول هذا المتغير من نوع 
            Console.WriteLine("b="+b);
          //  Console.ReadKey();



            object name1 = "omr";//تحويل متغيرين نصيين من غير نوع
            string name2;
               name2 =(string) name1;
            Console.WriteLine("name="+name2);
         //   Console.ReadKey();





            // unicode (int; char; .....)الاكسي كود
            //تحويل متغير نصي الى متغير رقمي او بالعكس واعطاء الاكسي كود
            char c = 'p';
            int x;
            x = c;//هذه الحاله يقبل بها لكن العكس لا يجوز
            int ba = 89;
            char s;
            s =(char) ba;//لا يقبل يجب التحويل

            Console.WriteLine(" x= "+x+" s= "+s+" a= "+(char)55+" t="+(int)'t');// الاكسي كودunicode
            Console.ReadKey();
            // (" ") عند الطباعه يجب ان تضع مسافه حتى لا يظهر خطا مثل
        }
    }
}
