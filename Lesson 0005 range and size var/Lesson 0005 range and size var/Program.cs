using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0005_range_and_size_var
{
    class Program
    {
        static void Main(string[] args)
        {
           //bit<byte كل 8 بت يساوي 1بايت ولتحويل الالبايت ال بت تضرب 8 في عدد البايت
            //مثال 8*1= 8بت تم تحويل بايت واحد الى بت
            //مثال 8*2=16 بت تم تحويل اثنين بايت الى بت وهكذا
            Console.WriteLine("byte\nsize = 8 bit\ndigits=3");
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sizeof(byte)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("sbyte\nsize = 8 bit\ndigits=3");
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sizeof(sbyte)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("short\nsize = 16 bit\ndigits=5");
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(sizeof(short)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("ushort\nsize = 16 bit\ndigits=5");
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(sizeof(ushort)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("int\nsize = 32 bit\ndigits=9or10");
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(sizeof(int)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("uint\nsize = 32 bit\ndigits=9or10");
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(sizeof(uint)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("long\nsize = 64 bit\ndigits=18or19");
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(sizeof(long)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("ulong\nsize = 64 bit\ndigits=19or20");
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(sizeof(ulong)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("float\nsize = 32 bit\ndigits=7");
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(sizeof(float)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("double\nsize = 64 bit\ndigits=15");
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(sizeof(double)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("decimal\nsize = 128 bit\ndigits=28");
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(sizeof(decimal)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("char\nsize = 16 bit");
            Console.WriteLine(char.MinValue);//من فراغ الى علامة استفهام
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(sizeof(char)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("string\nsize = free bit");
            Console.WriteLine("============");
            Console.WriteLine("bool\nsize = 8 bit");
            Console.WriteLine(sizeof(bool)); //الحجم في البايت وليس بت

            Console.WriteLine("============");
            Console.WriteLine("object\nsize = free bit");
            Console.WriteLine("==================");
            Console.ReadKey();
        }
    }
}
