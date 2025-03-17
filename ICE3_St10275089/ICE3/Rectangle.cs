using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE3
{
    public class Rectangle : Shape, ICalculateArea
    {
        private int Width;
        private int Height;

        public Rectangle(string name, int width, int height) : base(name)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public override void Display()
        {
            Console.WriteLine($"Shape: {Name}, Width: {Width}, Height: {Height}, Area: {CalculateArea()}");
        }
    }


}
