using System;
using System.Collections.Generic;

namespace prov_del_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hp = "1";
            int hp2;
            int loop = 0;

            Console.WriteLine("Please Pick a Nubmer between 1-20");

            hp = Console.ReadLine();
            bool number = int.TryParse(hp, out hp2);

            if (number == false || hp2 > 20 || hp2 < 1)
            {
                Console.WriteLine("That was not a number between 1-20");
                hp = Console.ReadLine();

            }


            while (hp2 > 0)
            {

                Console.Write("[");
                while (loop < hp2)
                {
                    Console.Write("=");
                    loop++;
                }

                Console.Write("]");
                hp2--;
                Console.WriteLine();
                loop = 0;

            }

            Console.ReadLine();


        }
    }
}
