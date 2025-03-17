using ICE3;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ICE3;

namespace ICE3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a rectangle instance
            ICalculateArea rectangle = new Rectangle("Rectangle", 5, 10);
            rectangle.Display();

            // Create a circle instance
            ICalculateArea circle = new Circle("Circle", 7);
            circle.Display();
        }
    }


}
