using Bmi;

namespace BmiTester
{
    //class here!!!
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = BmiCaculator.GetBmi(70, 1.7);
            Console.WriteLine("BMI: " + bmi);

            //verbatim - chuỗi nguyên bản, raw string, có sao in vậy, thấy sao in ra như vậy - WYSIWYG 
            //WHAT YOU SEE IN WHAT YOU GET

            //hãy lưu và in ra đường dẫn thư mục có tên:
            //C:\news\long-nhat
            //string path = "C:\\news\\long-nhat";
            int day = 20;
            string path = @$"C:\news\long-nhat {day}";
            Console.WriteLine("path: " + path);

            string lyric = @"Làn gió thôi bay dấu yêu đi tan tành
Mà anh không thể quên vắng bóng hình em
Ngày sau anh nghĩ có lẽ anh chẳng yêu một người nào nữa
Nhưng nỗi cô đơn biết làm sao giờ
Cỏ dại khô dưới chân sao xứng với hoa dành dành đây

                                <html>
Mùa hạ với mùa đông sao có thể bên nhau phải không
Và khi em rời đi anh trở thành một người lạ từng quen biết
Anh chúc cho em được hạnh phúc mãi sau này"; 

            //Console.WriteLine(lyric);
        }
    }

    //class here!!! nhưng ko nên làm thế
}
