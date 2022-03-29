using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestTask
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;
        public double A 
        {
            get {
                return this.a;
            }
            private set {
                if (value > 0)
                    this.a = value;
                else
                    throw new ArgumentException("Неверное значение стороны треугольника");
            }
        }

        public double B
        {
            get
            {
                return this.b;
            }
            private set
            {
                if (value > 0)
                    this.b = value;
                else
                    throw new ArgumentException("Неверное значение стороны треугольника");
            }
        }

        public double C
        {
            get
            {
                return this.c;
            }
            private set
            {
                if (value > 0)
                    this.c = value;
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

            Square=Math.Round(Math.Sqrt(p*(p-A)*(p-B)*(p-C)),2);

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
