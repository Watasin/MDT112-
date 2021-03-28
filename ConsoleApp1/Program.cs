using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, z, x, y;
            Console.Write("Input a : ");

            i = int.Parse(Console.ReadLine());
            Console.Write("Inpur b : ");

            z = int.Parse(Console.ReadLine());
            x = i;
            y = z;



            bool l = false;



            while (l == false)
            {
                if (x == y)
                {
                    Console.WriteLine("Output x : " + x);
                    l = true;
                }
                else if (x < y)
                {
                    x = x + i;



                }
                else
                    y = y + z;
            }
        }
    }
}
