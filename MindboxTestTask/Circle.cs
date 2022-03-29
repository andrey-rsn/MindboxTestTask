using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestTask
{
    public class Circle : Figure
    {
        private double radius;

        public double Radius 
        {
            get
            {
                return this.radius;
            }
        
            private set
            {
                if (value > 0)
                    this.radius = value;
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
            Square = Math.Round(3.14 * Math.Pow(Radius,2),2);
            return Square;
        }
    }
}
