namespace ShapeTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithDisk();
            //PlayWithRectangle();
            //PlayWithTriangle();
            PlayWithDiskReziable();
        }

        public static void PlayWithDiskReziable()
        {
            Disk d1 = new Disk(2, "RED");
            d1.Resize(5);           
            Console.WriteLine("Disk 1: " + d1.ToString()); //10, 314, 62.8
           
        }

        public static void PlayWithTriangle()
        {
            //Shape r1 = new Rectangle(10, 20.0, "YELLOW");
            Shape t1 = new Triangle(color: "YELLOW", a: 3, b: 4.0, c: 5.0);
            Console.WriteLine("Triangle 1: " + t1.ToString()); //s: 6, p = 12

            Triangle t2 = new Triangle()
            {
                //Color = "GREEN",
                EdgeC = 10.0,
                EdgeA = 6,
                EdgeB = 8.0,
            };

            Console.WriteLine("Triangle 2: " + t2.ToString()); //s: 24, p = 24
        }

        public static void PlayWithDisk()
        {
            Shape d1 = new Disk(2, "RED");
            Console.WriteLine("Disk 1: " + d1.ToString()); //s: 12,56, p = 12.56

            Disk d2 = new Disk(3, "GREEN");
            Console.WriteLine("Disk 2: " + d2.ToString()); //s: 28.26, p = 18.84
                                                           //unit test, expected value
                                                           //actual đoán xem chạy
        }

        public static void PlayWithRectangle()
        {
            //Shape r1 = new Rectangle(10, 20.0, "YELLOW");
            Shape r1 = new Rectangle(color: "YELLOW", width: 10, height: 20.0);
            Console.WriteLine("Rect 1: " + r1.ToString()); //s: 200, p = 60;

            Rectangle r2 = new Rectangle()
            {
                //Color = "GREEN",
                Height = 10.0,
                Width = 10.0
            };

            Console.WriteLine("Rect 2: " + r2.ToString());
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

