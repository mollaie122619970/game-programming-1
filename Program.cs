using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTime t1 = new MyTime();
            MyTime t2 = new MyTime(4);
            MyTime t3 = new MyTime(10 ,2 );
            MyTime t4 = new MyTime(3 , 55 , 48);

            Console.WriteLine("t1 time");
            t1.printUniversal();
            t1.printStarndard();
            Console.WriteLine();


            Console.WriteLine("t2 time");
            t2.printUniversal();
            t2.printStarndard();
            Console.WriteLine();


            Console.WriteLine("t3 time");
            t3.printUniversal();
            t3.printStarndard();
            Console.WriteLine();


            Console.WriteLine("t4 time");
            t4.printUniversal();
            t4.printStarndard();
            Console.WriteLine();



        }
    }
}
