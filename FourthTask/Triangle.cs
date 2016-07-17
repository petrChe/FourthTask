using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    public enum TriangleType { Rectangular, RectangularGeron, Isosceles, Geron};
    class Triangle
    {
        public TriangleType type;
        public double aSide;
        public double bSide;
        public double cSide;

        public Triangle(TriangleType type, double a, double b, double c)
        {
            this.type = type;
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
            if (this.type.Equals(TriangleType.Geron))
            {
                double square = 1;
                double halfPerimetr = FindHalfPerimetr();
                square = Math.Sqrt(halfPerimetr * (halfPerimetr - this.aSide) * (halfPerimetr - this.bSide) * (halfPerimetr - this.cSide));
                return square;
            }
            else
            {
                return 0.0; //ADD Exeption
            }
        }
        public double FindSquare(double height)
        {
            if (this.type.Equals(TriangleType.Isosceles))
            {
                double square = 1;
                square = 0.5 * this.aSide * height;
                return square;
            }
            else
            {
                return 0.0; //ADD Exeption
            }
        }

    }
}
