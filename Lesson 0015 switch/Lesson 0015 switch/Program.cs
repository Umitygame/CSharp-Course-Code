using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0015_switch
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  Console.WriteLine("enter number 1-3");
            string str=Console.ReadLine();
            int num = int.Parse(str);
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default:
                    Console.WriteLine("error");
                    break;*/





                    Console.Write("enter number 1-4 : ");
                    string str = Console.ReadLine();
                    int num = int.Parse(str);
            Console.Write("enter passward : ");
            string str1 = Console.ReadLine();
                    int passward = int.Parse(str1);
            if (passward == 12344321)
            {
                switch (num * 2)
                {
                    case 2:
                    case 8:
                        if (num == 1)
                            Console.WriteLine("one");
                        else
                            Console.WriteLine("four");

                        break;
                    case 4:
                        Console.WriteLine("two");
                        break;
                    case 6:
                        Console.WriteLine("three");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;



                }

            }
            else
                Console.WriteLine("error");
        }
    }
}
