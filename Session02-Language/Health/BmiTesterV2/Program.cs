namespace BmiTesterV2
{
    //class here !!!!!
    public class BmiCalculator
    {
        //Java: tên hàm cú pháp con Lạc Đà camel Case Notation
        //C#  : tên hàm cú pháp Pascal - Pascal Case Notation
        public static double GetBmi(double weight, double height) => weight / (height * height); //double arrow
        //expression bodied
       
    }
    //đạt nguyên lý S trong SOLID: Single Rsponsibility


    //int yob = 2004; ăn đòn
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = BmiCalculator.GetBmi(70, 1.7);
            Console.WriteLine($"BMI: {bmi}");
        }
    }

    //class here!!!!
}
