using System.Threading.Channels;

namespace BmiTester
{
    internal class Program
    {
        //okie: biến, hàm
        static void Main(string[] args)
        {
            double height = 1.7, weight = 70;
            double bmi = GetBmi(weight, height);
            Console.WriteLine("W: " + weight + " | H: " + height + " | BMI: " + bmi);
            //string concatenation - ghép chuỗi bằng dấu + 
            
            Console.WriteLine("W: {0} | H: {1} | BMI: {2}", weight, height, bmi); //cw tab
            //string place holder, điền vào chỗ trống

            Console.WriteLine($"W: {weight * weight} | H: {height} | BMI: {bmi}");
            //string interpolation, ráng suy luận trong cái chuỗi chỗ nào là biến thay thế value của biến vào



            //double bmi = GetBmi(70, 1.7);
            //Console.WriteLine("W: 30, H:1.7, BMI: " + bmi); //cw tab ~ sout tab bên Java
            //Console.WriteLine("W: 30, H:1.7, BMI: {0}", bmi);


        }

        //okie: biến, hàm
        //viết hàm tính bmi = cân nặng kg / chiều cao m^2
        //bmi < 18.5 -> ốm
        //              <= 24.9, mlem
        //> 25 mập

        //TRONG C# NẾU HÀM CHỈ CÓ DUY NHẤT 1 CÂU LỆNH TRONG THÂN HÀM
        //TA ĐC PHÉP VIẾT/ ĂN BỚI CÚ PHÁP, CHO HÀM GỌN GÀNG HƠN
        //BÊN JAVA KO CÓ
        //LOẠI BỎ CẶP { }
        //LOẠI BỎ KEYWORD RETURN 
        //NỐI TÊN HÀM VÀ THÂN HÀM QUA DẤU => 
        //KÉO LÊN 1 DÒNG NẾU MUỐN
        //CÚ PHÁP NÀY GỌI LÀ EXPRESSION BODIED - THÂN HÀM NHÌN NHƯ BIỂU THỨC TÍNH TOÁN

        //TUYỆT ĐỐI KO ĐC NHẦM CÚ PHÁP NÀY VÀ BIỂU THỨC LAMBDA - LAMBDA EXPRESSION SẼ HỌC SAU !!!!!!!!!
        //2 THẰNG ĐỀU XÀI => NHƯNG HOÀN TOÀN KHÁC NHAU !!!!!!
        public static double GetBmi(double weight, double height) =>  weight / (height * height);
        

        //MLEM
        //public static double GetBmi(double weight, double height)
        //{
        //    return weight / (height * height);
        //}

        /*
         
        OOP: OBBJECT ORIENTED PARADIGM / PROGRAMMING
        4 PRINCIPLES
        + ABREACTION - TÌM CLASS
        + ENCAPSULATION - CLASS WITH +-
        + INHERITANCE - NOT COPY & PASTE
        + POLYMORPHISM GIÙM => TÍNH S(...) => TRUYỀN VÀO HÌNH TRÒN, VUÔNG, TAM GIÁC

        NÂNG CAO: SOLID
        + SINGLE RESPONSIBILITY: MỖI CLASS CHỈ NÊN LÀM 1 NHIỆM VỤ

         */

    }
}
