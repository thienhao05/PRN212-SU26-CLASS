using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTester
{
    //dấu : ~~~ extends và implements bên Jav
    public class Triangle : Shape
    {
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double EdgeC { get; set; }


        public Triangle(double a, double b, double c, string color) : base(color)
        {
            EdgeA = a;
            EdgeB = b;
            EdgeC = c;
        }

        public Triangle() : base("PINK")
        {
        }

        //CÔNG THỨC HERON: S = CĂN BẬC 2 (CHU VI / 2) * (P - A) * (P - B) * (P - C)
        public override double GetArea()
        {
            double halfP = GetPerimeter() / 2;
            return Math.Sqrt(halfP * (halfP - EdgeA) * (halfP - EdgeB) * (halfP - EdgeC));
        }

        public override double GetPerimeter() => EdgeA + EdgeB + EdgeC;

        public override string ToString()
        {
            return $"TRIANGLE -> color: {Color} | a: {EdgeA} | b: {EdgeB} | c: {EdgeC} | area: {GetArea()} | perimeter: {GetPerimeter()}";
        }
    }
}
