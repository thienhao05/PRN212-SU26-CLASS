namespace BmiTester
{
    //class here
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = BmiCalculator.GetBmi(70, 1.7);
            Console.WriteLine("BMI: {0}", bmi);
        }
    }

    //class here
    //KO KHUYẾN KHÍCH GỘP CLASS TRONG CÙNG 1 TẬP TIN VẬT LÝ
    //VÌ KHÓ NHÌN DANH SÁCH CLASS TỪ CÂY THƯ MỤC BÊN PHẢI
}
