using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_modul_7
{
    class Circule : IShape
    {
        private double y;
        private double x;

        static double Pi = 3.14;

        public Circule(int y , int x)
        {
            this.y = y;
            this.x = x;
        }
        public double CalculateArea()
        {
            return Pi * Math.Pow(y + x, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Pi * (y + x); ;
        }
    }

    class Square : IShape
    {
        private double y;
        private double x;

        public Square(int y, int x)
        {
            this.y = y;
            this.x = x;
        }
        public double CalculateArea()
        {
           return x * y;
        }

        public double CalculatePerimeter()
        {
            return 2 * (y + x);
        }
    }

    class Triangle : IShape
    {
        private double a;
        private double h;

        public Triangle(int a, int h)
        {
            this.a = a;
            this.h = h;
        }
        public double CalculateArea()
        {
            return a * h / 2;
        }

        public double CalculatePerimeter()
        {
            return a + (h * 2);
        }
    }
}
