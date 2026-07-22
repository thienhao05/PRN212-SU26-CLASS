namespace DelegateTesterLambdaExpression
{
    //CHALLENGE: VIẾT HÀM NHẬN VÀO N VÀ IN RA BÌNH PHƯƠNG 
    //CẤM DÙNG HÀM LẺ HÀM RỜI
    //CẤM DÙNG CHỮ DELEGATE, VÌ NÓ BOILER PLATE

    public delegate void MathFunc(int n);
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    MathFunc f1 = delegate (int x)
        //    {
        //        Console.WriteLine($"{x}^ 2 = {x * x}");
        //        Console.WriteLine($"{x}^ 2 = {Math.Pow(x, 2)}");

        //    };

        //    f1(10); //10^2 = 100


        //    //KĨ THUẬT RÚT GỌN CHỈ CÒN CÁI DÂY NỊT
        //    MathFunc f2 = (int x) =>
        //    {
        //        Console.WriteLine($"{x}^ 2 = {x * x}");
        //        Console.WriteLine($"{x}^ 2 = {Math.Pow(x, 2)}");

        //    };

        //    f2(10);

        //    // Nếu chỉ có 1 tham số xóa luôn kiểu dữ liệu
        //    MathFunc f3 = (x) =>
        //    {
        //        Console.WriteLine($"{x}^ 2 = {x * x}");
        //        Console.WriteLine($"{x}^ 2 = {Math.Pow(x, 2)}");

        //    };

        //    f3(10);

        //    // Nếu chỉ có tham số và bỏ ngoặc
        //    MathFunc f4 = x =>
        //    {
        //        Console.WriteLine($"{x}^ 2 = {x * x}");
        //        Console.WriteLine($"{x}^ 2 = {Math.Pow(x, 2)}");

        //    };

        //    f4(10);

        //    //Đây là 1 hàm nhận vào 1 tham số và kiểu void
        //    MathFunc f5 = x => Console.WriteLine($"{x}^ 2 = {x * x}");

        //    f5(10);


        //}


        static void Main(string[] args)
        {
            //PrintRange(10, 20);

            //TwoParamsFunc fRange = PrintRange; //chuẩn quá, ko thèm làm

            //ẩn danh - hàm bán linh hồn là cái tên gọi
            TwoParamsFunc fRange = delegate (int x, int y)
            {
                Console.WriteLine($"The list of numbers from {x} to {y}");

                for (int i = x; i <= y; i++)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine(); //xuống hàng sau khi in dàn ngang các số
            };
            //xài hàm qua tên gọi fRange
            fRange(100, 200);

            //LAMBDA là ẨN DANH RÚT GỌN,
            //RÚT GỌN KEYWORD DELEDATE; VẪN CÒN DÀI
            fRange = (int x, int y) =>
            {
                Console.WriteLine($"The list of numbers from {x} to {y}");

                for (int i = x; i <= y; i++)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine(); //xuống hàng sau khi in dàn ngang các số
            };

            fRange(500, 1000);

            //RÚT GỌN DATA TYPE
            fRange = (x, y) =>
            {
                Console.WriteLine($"The list of numbers from {x} to {y}");

                for (int i = x; i <= y; i++)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine(); //xuống hàng sau khi in dàn ngang các số
            };

            fRange(5000, 6000);

            //TRONG MAIN NÈ:
            OneParamFunc fMsg = str =>
            {
                Console.WriteLine("In cái message/string tham số gửi vào");
                Console.WriteLine(str);
            };

            fMsg("SÁNG SỚM NAY, MAY KO TÂY BÁN NHÀ");
        }

        //CHALLENGE 2: VIẾT HÀM IN RA TỪ MIN ĐẾN MAX NHƯNG KO CHƠI HÀM RỜI / HÀM LẺ
        //ĐÁP ÁN: DELEGATE!


        //CHALLENGE: VIẾT HÀM LẺ -> VIẾT HÀM NHẬN VÀO 2 SỐ TỰ NHIÊN
        //              MIN < MAX VÍ DỤ: 5, 100
        //              HÃY IN RA CÁC SỐ NẰM TRONG ĐOẠN MIN MAX NÀY
        //              5, 6, 7, 8, 9, 10, ... 100

        public static void PrintRange(int min, int max)
        {
            Console.WriteLine($"The list of numbers from {min} to {max}");
            
            for (int i = min; i <= max; i++)
            {
                //Console.Write(i + " ");
                Console.Write($"{i} ");
            }

            Console.WriteLine(); //xuống hàng sau khi in dàn ngang các số
        }


    }

    // CLASS HERE! INTERFACE HERE! DELEGATE HERE!
    public delegate void TwoParamsFunc(int min, int max);

    // DELEGATE MỚI, HÀM 1 THAM SỐ THOY
    public delegate void OneParamFunc(string msg); //hàm nhận vào
                                                   //1 chuỗi và làm gì với chuỗi ai biết!!!! Chỉ biết mày là hàm 1 tham số string
}

//const f = x => x * x;
//const f = x => {console.log(x * x);};

//KĨ THUẬT VIẾT BIỂU THỨC LAMBDA - HÀM ẨN DANH, HÀM KO CÓ TÊN
//MUỐN CHƠI VỚI HÀM ẨN DANH, KO TÊN, LAMBDA, THÌ BẮT BUỘC PHẢI KHAI BÁO DELEGATE TRƯỚC ĐÓ (CLASS ĐẠI DIỆN CHO 1 NHÓM HÀM)

//HÀM ẨN DANH (ANONYMOUS METHOD) HAY BIỂU THỨC LAMBDA BẢN CHẤT VẪN LÀ 1 HÀM NHƯ MỌI HÀM MÌNH ĐÃ HỌC, ĐÃ VIẾT, NAY VIẾT CÚ PHÁP LS5 HƠN, ĂN BỚT RẤT NHIỀU KÍ TỰ BOILER PLATE

//CÚ PHÁP CHUẨN HÀM BÌNH THƯỜNG
//  data-type TenHam(danh sách tham số, tham số, tham số, int x, ...)
//  {
//      code, thân hàm, body of method/function, implementation
//      return giá-trị nếu hàm có trả về;
//  }

//CÚ PHÁP BIỂU THỨC LAMBDA

// DELEGATE CHUẨN
// DelegateType biến-luật-sư = Tên-Hàm-Lẻ | Thân-Chủ;  //ko có dấu ngoặc
//              biến-luật-sư();             //chạy hàm

// HÀM ẨN DANH
// DelegateType biến-luật-sư = delegate(các tham số hàm lẻ) {
//                                              code hàm lẻ, kể cả return ..
//                             };  //;here VIPD

// BIỂU THỨC LAMBDA - RÚT GỌN CHỈ CÒN CÁI DÂY NỊT CỦA ẨN DANH
// XÓA KEYWORD delegate
// NỐI THAM SỐ HÀM VÀ BODY THÂN HÀM QUA => 

// DelegateType biến-luật-sư = (các tham số hàm lẻ) => {
//                                              code hàm lẻ, kể cả return ..
//                             };  //;here VIPD BIỂU THỨC LAMBDA BẢN FULL

// -> RÚT GỌN THAM SỐ HÀM ******************************
// 1. CÓ THỂ BỎ DATA TYPE CỦA CÁC THAM SỐ, CHỈ GIỮ LẠI TÊN THAM SỐ
// 2. NẾU HÀM CHỈ CÓ 1 THAM SỐ, THÌ ĐC PHÉP BỎ THÊM DẤU () 2 BÊN 
// THAM SỐ
// (int a, int b) => { ... };
// (a, b) => { ... };

// (int x) => { ... };
// (x) => { ... };
//  x => { ... }


// 3. HÀM KO CÓ THAM SỐ
// () => { ... }


// -> RÚT GỌN THÂN HÀM ******************************
//1. NẾU HÀM CÓ NHIỀU HƠN 1 LỆNH, THÌ KO RÚT GỌN GÌ CẢ, VẪN PHẢI ĐỦ
//  { các lệnh; các lệnh; lệnh return ... }

//2. NẾU HÀM CHỈ CÓ 1 CÂU LỆNH, THÌ RÚT GỌN LOẠI BỎ { NGOẶC } VÀ KEYWORD RETURN BỎ LUÔN; KO CÓ RETURN THÌ BỎ { }

//TÌNH HUỐNG RÚT GỌN TUYỆT ĐỐI ĐIỆN ẢNH
// x => lệnh-tính-toán-in-ấn-gì-đó
//() => lệnh-tính-toán-in-ấn-gì-đó

