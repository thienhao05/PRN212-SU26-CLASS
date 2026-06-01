using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTester
{
    //dấu : ~~~ extends và implements bên Jav
    public class Triangle : Shape
    {
        //public int Weight { get; set; }
        //public int Height { get; set; }

        public Triangle(string color) : base(color)
        {
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
