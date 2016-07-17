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
            Triangle triangle = new Triangle(TriangleType.Geron, 2, 3, 4);
            triangle.CheckTriangle();
            Console.WriteLine(triangle.FindPerimetr());
            Console.WriteLine(triangle.FindSquare());
            Console.ReadKey();
            //Money money = new Money(5, 500);
            //Money money2 = new Money(4, 50);
            //Console.WriteLine(money.Sub(money2).ToString());
            //Goods toy = new Goods("Doll", new DateTime(2016,07,16), new DateTime(2016, 07, 10), new Money(100,50), 10, 1);
            //Console.WriteLine(toy.FindCost(10));
            //toy.FindPriceAfterDevaluation();
            //Console.WriteLine(toy.price.ToString());
            //Console.ReadKey();
        }
    }
}
