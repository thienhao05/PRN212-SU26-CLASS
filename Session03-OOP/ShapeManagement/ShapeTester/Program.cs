namespace ShapeTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
//CHALLENGE: THIẾT KẾ APP ĐỂ LƯU ĐC CÁC HÌNH TRÒN (BK), HÌNH CHỮ NHẬT (DÀI, RỘNG)
//                                       TAM GIÁC (3 CẠNH)
//          TÍNH TOÁN VÀ IN RA DIỆN TÍCH, CHU VI
//          SAU ĐÓ RESIZE TĂNG GIẢM KÍCH THƯỚC CÁC HÌNH THEO X% (ZOOM)

//NGUYÊN LÝ SOLID 
//SINGLE RESPONSIBILITY: MỖI CLASS CHỈ LÀM VIỆC CỦA MÌNH GIỎI
//class Rectangle (width, length, color, S(), P())
//class     Disk  (radius,        color, S(), P())
//class  Triangle (a, b, c      , color, S(), P())
//class      ....
//                               ------------------> Shape (color, S() ko code
//                                                                 P() ko code
//                                                              abstract class
//                     CHA SHAPE: super class, base class: ba sẽ là cánh chim........
//CHA: NHÂN TỬ CHUNG CỦA ĐÁM CON: a * b + a * c ~~~~~~ a * (b + c)

