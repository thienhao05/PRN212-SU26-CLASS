using System;
using System.Collections.Generic;
using System.Text;

namespace BmiTester
{
    public class BmiCalculator
    {
        //hàm tính bmi = ...
        public static double GetBmi(double weight, double height) => weight / (height * height);
    }
}
