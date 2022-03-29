using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestTask
{
    public class Circle : Figure
    {
        public double Radius {
            get {
                return Radius;
            }

            private set {
                if (value > 0)
                    Radius = value;
                else
                    throw new ArgumentException("Неверное значение радиуса окружности");
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        
        public override double CalculateSquare()
        {
            Square = Math.PI * Math.Pow(Radius,2);
            return Square;
        }
    }
}
