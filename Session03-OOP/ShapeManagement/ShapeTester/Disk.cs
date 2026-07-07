using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTester
{
    public class Disk : Shape, IResizable
    {
        //hình tròn thì có màu sắc, bán kính, diện tích, chu vi
        //                 ------             -----------------
        //                  Shape               Shape
        //public string Color { get; set; } //lên Sharp làm nhân tử chung

        public double Radius { get; set; } //_radius chống lưng

        public Disk(double radius, string color) : base(color) // ~~~ new Shape(color);
        {
            //Java: super(color);
            Radius = radius;
            //this._radius = radius;
            //     _radius = radius;
        }

        public override double GetArea()
        {
            //pi * r^2
            //return Math.PI * Radius * Radius;
            return Math.PI * Math.Pow(Radius, 2);
        }


        //2 * pi * r    expression body
        public override double GetPerimeter() => 2 * Math.PI * Radius;

        public override string ToString()
        {
            return $"DISK -> color: {Color} | radius: {Radius} | area: {GetArea()} | perimeter: {GetPerimeter()}";
        }

        public void Resize(double size)
        {
            Radius *= size;
        }
    }
}