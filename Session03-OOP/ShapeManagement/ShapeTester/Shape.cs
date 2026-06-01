using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTester
{
    //ko new abstract class vì ko đủ code
    //chỉ khai báo Cha new Con()
    //          Shape d1 = new Disk();
    //      Khai báo Con new Con() quá quen
    //          Disk d1 = new Disk();
    public abstract class Shape
    {
        public string Color { get; set; }

        //hàm ko có code để đám con implement giùm
        protected Shape(string color)
        {
            Color = color;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
