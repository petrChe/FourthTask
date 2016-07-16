using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangle triangle = new Triangle(2, 3, 4);
            //triangle.CheckTriangle();
            //Console.WriteLine(triangle.FindPerimetr());
            //Console.WriteLine(triangle.FindSquare());
            //Console.ReadKey();
            Money money = new Money(5, 500);
            Money money2 = new Money(4, 50);
            Console.WriteLine(money.Sub(money2).ToString());
            Console.ReadKey();
        }
    }
}
