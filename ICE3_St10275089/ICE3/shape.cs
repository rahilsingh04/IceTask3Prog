using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE3
{
    public abstract class Shape
    {
        protected string Name;

        public Shape(string name)
        {
            Name = name;
        }

        public abstract void Display();
    }

}
