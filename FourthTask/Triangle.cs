using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class Triangle
    {
        public double aSide;
        public double bSide;
        public double cSide;

        public Triangle(double a, double b, double c)
        {
            this.aSide = a;
            this.bSide = b;
            this.cSide = c;
        }

        public Triangle() { }

        public void CheckTriangle()
        {
            if ((this.aSide + this.bSide) > this.cSide)
            {
                Console.WriteLine("This triangle exists!");
            }
            else
            {
                Console.WriteLine("This triangle doesnt exist!");
            }
        }

        public double FindHalfPerimetr()
        {
            return (this.aSide + this.bSide + this.cSide) / 2;
        }

        public double FindPerimetr()
        {
            return this.aSide + this.bSide + this.cSide;
        }

        public double FindSquare()
        {
            double square = 1;
            double halfPerimetr = FindHalfPerimetr();
            square = Math.Sqrt(halfPerimetr * (halfPerimetr - this.aSide) * (halfPerimetr - this.bSide) * (halfPerimetr - this.cSide));
            return square;
        }

    }
}
