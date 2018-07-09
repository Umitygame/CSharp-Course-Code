using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0012_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool and1 = true && true;
            bool and2 = true && false;
            Console.WriteLine(and1+" "+and2+"\n");
            // Console.WriteLine(and1 + and2);خطا
            //لا يجوز وضع المتغيرن من دون فراغ لانه لن يقبل 

            bool or1=true||false;
            Console.WriteLine(or1);

            bool not = !true;// ! علامة النفي هي  
            Console.WriteLine(not);


        }
    }
}
