using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE3
{
    public class Circle : Shape, ICalculateArea
    {
        private int Radius;

        public Circle(string name, int radius) : base(name)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            Console.WriteLine($"Shape: {Name}, Radius: {Radius}, Area: {CalculateArea():F2}");
        }
    }


}
