using System;
using System.Collections.Generic;
using System.Text;

namespace Bmi
{
    /// <summary>
    /// This class offers methods to calculate BMI and related things. Class này cung cấp các hàm tính toán liên quan chỉ số BMI
    /// </summary>
    public class BmiCaculator
    {
        /// <summary>
        /// This method returns BMI based on weight and height. Hàm trả về chỉ số bmi dựa trên cân nặng và chiều cao.
        /// </summary>
        /// <param name="weight">Cân nặng theo kg</param>
        /// <param name="height">Chiều cao theo m</param>
        public static double GetBmi(double weight, double height)  =>  weight / (Math.Pow(height, 2));
        
    }
}
