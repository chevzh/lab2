using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            //1a

            // Типы данных, которые поддерживаются компилятором напрямую, называются примитивными (primitive types); 
            //у них существуют прямые аналоги в библиотеке классов .NET Framework Class Library (FCL).
            sbyte sb = 101;
            byte b = 100;
            short s = 31233;
            ushort us = 23435;
            int i = 121243123;
            uint ui = 1233121233;
            long l = 1312312333322234214;
            ulong ul = 123123123123123;
            char c = 'c';
            float f = 1.2f;
            double d = 213321.2323;
            bool boo = true;
            decimal dec = 13;
            string str = "sdfjhdskjf";
            object obj = new object();
            dynamic dyn;


            //1b

            // Неявное преобразование разрешено только если оно не сопряжено с потерей данных.


            string str1 = "123";
            int i1 = Convert.ToInt32(str1);// явное

            int i2 = 432;
            string str2 = i2.ToString();

            Int32 ia = 32;
            Int64 ib = ia;// неявное




            //1c

            obj = i;// упаковка
            i = (int)obj;// распаковка


            //1d

            var v = 5; // неявно типизированная переменная
            Console.WriteLine(v);


            //1e

            str = null;
            Int32? ni = Convert.ToInt32(str);


            //2a

            Console.WriteLine(123.ToString() + " " + "literal");

            //2b

            String st1 = "string1";
            String st2 = "string2";
            String st3 = "string3";

            Console.WriteLine(st1 + st2); // сцепление

            //Копирование?

            st3 = st2.Substring(0, 3); // выделение подстроки(3 символа, начиная с 0) 
            Console.WriteLine(st3);

            //разделение строки
            string[] arr = st2.Split('g');
            foreach (string element in arr)
            {
                Console.WriteLine(element);
            }

            // вставка подстроки

            Console.WriteLine(st3.Insert(1, st1));

            //удаление подстроки

            //Console.WriteLine(st3.Remove(5));  // WTF?
            Console.WriteLine(st3.Remove(1, 1));


            //2c

            String emptystr;
            String nullstr = null; //?

            //2d

            StringBuilder strbuild = new StringBuilder("stringbuilder");
            Console.WriteLine(strbuild.Remove(0, 6));
            Console.WriteLine(strbuild.Insert(0, '1'));

        }
    }
}
