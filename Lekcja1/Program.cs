using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja1
{
    class Program
    {
        static void Main(string[] args)
        {
            //STALA
            const float PI = 3.14f; 

            //CAŁKOWITE
            sbyte zmienna6 = sbyte.MaxValue;
            short zmienna4 = short.MaxValue;
            byte zmienna3 = byte.MaxValue;
            int zmienna = int.MaxValue;
            long zmienna2 = long.MaxValue;
            Console.WriteLine(zmienna);
            Console.WriteLine(zmienna2);
            Console.WriteLine(zmienna3);
            Console.WriteLine(zmienna4);
            Console.WriteLine(zmienna6);

            //ZMIENNO PRZECINKOWE
            float zmienna7 = 1.1312f;
            double zmienna5 = 5.5478;
            decimal zmienna8 = 9.234M;

            //ZMIENNE TYPU TEKST
            string zmienna9 = "1";
            char zmienna10 = '4';

            //ZMIENNA TYPU LOGICZNEGO
            bool zmienna11 = true;
            bool zmienna12 = false;
            bool zmienna13 = 5 > 2;
            Console.WriteLine(zmienna13);


            Console.WriteLine("Hello World");
            Console.ReadKey();

        }
    }
}
