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

            obj = i2;// упаковка
            i2 = (int)obj;// распаковка


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

            //Console.WriteLine(st3.Remove(4)); 
            Console.WriteLine(st3.Remove(1, 1));


            //2c

            String emptystr = "";
            // экземпляр объекта System.String, содержащий 0 символов:
            //Для пустых строк можно вызывать методы

            String nullstr = null;
            //Строки со значениями null не ссылаются на экземпляр объекта System.String,
            //попытка вызвать метод для строки null вызовет исключение NullReferenceException. 
            //строки null можно использовать в операциях объединения и сравнения с другими строками.

            //2d

            StringBuilder strbuild = new StringBuilder("stringbuilder");
            Console.WriteLine(strbuild.Remove(0, 6));
            Console.WriteLine(strbuild.Insert(0, '1'));


            //3a
            int m;
            m = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[m,m];
            Random rn = new Random();

            for (int i= 0; i < m; i++)
            {
                for(int j = 0; j < m; j++)
                {                    
                    mas[i,j] = rn.Next(2,15);
                    Console.Write("\t" + mas[i, j]);
                }
                Console.WriteLine();
            }


            //3b

            String[] strmas = new String[] { "Odin", "Dva", "Tri"};

            Console.WriteLine("Элементы Массива:");
            foreach(var el in strmas)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("Длина массива: " + strmas.GetLength(0).ToString());

            void ChangeElment()
            {
                Console.WriteLine("Введите позицию ээлемента");
                int pos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите новое значение");
                String newel = Console.ReadLine();

                strmas[pos] = newel;

                foreach (string el in strmas)
                {
                    Console.WriteLine(el);
                }
            }

            try { ChangeElment(); }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("В массиве нет элемента с таким номером, попробуйте снова");
                ChangeElment();
            }

            //3c
            int[][] jaggedarr = new int[3][];

            jaggedarr[0] = new int[2];
            jaggedarr[1] = new int[3];
            jaggedarr[2] = new int[4];

            Console.WriteLine("Заполните массив");
            foreach(var array in jaggedarr)
            {
                for(int i =0; i< array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Ступенчатый массив");
            for(int i =0; i<jaggedarr.GetLength(0); i++)
            {
                for(int j = 0; j< jaggedarr[i].GetLength(0); j++)
                {
                    Console.Write("\t"+jaggedarr[i][j]);
                }
                Console.WriteLine();
            }


            //4

            //ValueTuple<int, string, char, string, ulong> tuple = new ValueTuple<int, string, char, string, ulong>(2, "323");
            var tuple = (element1:5, element2:"string1", element3:'c',element4:"string2",element5:9487363345);

            Console.WriteLine(tuple);
            var tup = (tuple.Item1, tuple.Item3, tuple.Item4);
            Console.WriteLine(tuple.element1 + "::" + tuple.element3 + "::" + tuple.element5);

            int peremennay_takskozat = tup.Item1;

            Console.WriteLine(tuple.Equals(tup));

            (int var1, char var2, string var3) = tup; //Деконструирование кортежа (var1, var2, var3 -- переменные, в которые 
            //будут записаны элементы кортежа)

            (int, int,int,char) fun(int[] array, string stroka) => (array.Max(), array.Min(),array.Sum(), stroka.First());
            int[] arra = new int[] { 1, 2, 3 };

            Console.WriteLine(fun(arra,st2));
        }

    }
}
