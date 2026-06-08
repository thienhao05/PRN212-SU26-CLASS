using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTester
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() : base("PINK")
        {
        }

        public Rectangle(double width, double height, string color) : base(color)
        {
            Width = width;
            Height = height;
        }

        

        public override double GetArea() => Width * Height;

        public override double GetPerimeter() => (Width + Height) * 2;

        public override string ToString()
        {
            return $"RECT -> color: {Color} | width: {Width} | height: {Height} | area: {GetArea()} | perimeter: {GetPerimeter()}";
        }
    }
}
