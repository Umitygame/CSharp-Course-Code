using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0006_UniCode
{
    class Program
    {
        static void Main(string[] args)
        {//تعرف اليوني كود وهو عباره عن اكواد 
         //وكل حرف او رمز او رقم له يوني كود خاص به يكون بشكل هذا 
            // هذا هو شكله '\u0000'
            char n = '\u0048';
            char a = '\u006c';
            char m = '\u006c';
            char e = '\u006f';
            string name = "\u0020\u004d\u006f\u0068\u0061\u006d\u0065\u0064\u0021\u0021\u0021";
            Console.Write(n);
            Console.Write(a);
            Console.Write(m);
            Console.Write(e);
            Console.Write(name);

            Console.ReadKey();
        }
    }
}
