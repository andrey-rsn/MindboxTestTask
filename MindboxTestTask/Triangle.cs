using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestTask
{
    internal class Triangle : Figure
    {
        public double A 
        {
            get {
                return A;
            }
            private set {
                if (value > 0)
                    A = value;
                else
                    throw new ArgumentException("Неверное значение стороны треугольника");
            }
        }

        public double B
        {
            get
            {
                return B;
            }
            private set
            {
                if (value > 0)
                    B = value;
                else
                    throw new ArgumentException("Неверное значение стороны треугольника");
            }
        }

        public double C
        {
            get
            {
                return C;
            }
            private set
            {
                if (value > 0)
                    C = value;
                else
                    throw new ArgumentException("Неверное значение стороны треугольника");
            }
        }

        public Triangle(double a,double b, double c)
        {
            A = a;
            B = b;
            C = c;
            if(!TriangleIsExist())
            {
                throw new ArgumentException("Треугольника с такими сторонами не существует");
            }
        }
        public override double CalculateSquare()
        {
            var p = (A + B + C) / 2;

            Square=Math.Sqrt(p*(p-A)*(p-B)*(p-C));

            return Square;
        }

        private bool TriangleIsExist()
        {
            if (A < B + C && B < C + A && C < B + A)
                return true;
            else
                return false;
                  
        }
    }
}
