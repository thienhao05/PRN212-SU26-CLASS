namespace DelegateTester.V3Anonymous
{

    public delegate void NotiFunc(string to, string msg);

    //CHALLENGE: VIẾT 1 HÀM NHẬN VÀO 1 CON SỐ TỰ NHIÊN N 
    //           SAU ĐÓ, IN RA BÌNH PHƯƠNG CỦA NÓ - PowByTwo

    //CẤM KO ĐC GỌI TRỰC TIẾP TÊN HÀM
    //CẤM KO ĐC LÀM HÀM LẺ, HÀM RỜI NHƯ ĐANG CÓ 
    //-> ANONYMOUS FUNCTION

    public delegate void MathFunc(int n);

    internal class Program
    {

        public static void PrintSquare(int n)
        {
            Console.WriteLine($"{n} ^ 2 = {n * n}");
            Console.WriteLine($"{n} ^ 2 = {Math.Pow(n, 2)}");
        }

        //svm tab
        static void Main(string[] args)
        {
            PrintSquare(10);
            MathFunc f = PrintSquare;
            f(20);

            MathFunc f2 = delegate (int n)
            {
                //Console.WriteLine($"{n}^10 = {n * n * n * n * n * n * n * n * n * n}");

                int result = 1;

                for (int i = 1; i <= 10; i++)
                {
                    result *= n; //i = 1, nhân n, i = 2 nhân n, i = 3 nhân n
                }

                Console.WriteLine($"{n} ^ 10 = {result}");

            };

            f2(1); //1024

            //CHALLENGE: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN N > 10; VÀ IN RA CÁC SỐ TỪ 1 ĐẾN N.
            //PrintToN(100);
            //CẤM LÀM HÀM LẺ!!!!!!!!
            //PHẢI XÀI DELEGATE

            MathFunc f3 = delegate (int n)
            {
                if (n < 10)
                {
                    Console.WriteLine("Invalid n. n must be > 10");
                    return; //thoát hàm ko làm nữa
                }

                //CPU chạy đến đây là n > 10 rồi
                Console.WriteLine("The list of numbers form 1 to n");
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine(); //xuống hàng sau khi in dàn ngang
            };

            f3(1000);

        }

        public static void PrintToN(int n)
        {
            if(n < 10)
            {
                Console.WriteLine("Invalid n. n must be > 10");
                return; //thoát hàm ko làm nữa
            }

            //CPU chạy đến đây là n > 10 rồi
            Console.WriteLine("The list of numbers form 1 to n");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); //xuống hàng sau khi in dàn ngang
        }

        //static void Main(string[] args)
        //{
        //    //truyền thống:
        //    NotiFunc f1 = SendWhatsApp; //~ int yob = 2005;
        //    //f1 là 1 hàm void nhận 2 đầu vào string, string và cụ thể là hàm SendWhatsApp

        //    //run hàm
        //    f1("MESSI", "MÃI MÃI...");

        //    //đột phá cảnh giới Anonymous Function, hàm ẩn danh, hàm ko thèm có tên, xài qua tên luật sư
        //    // NotiFunc f2 = SendWhatsApp; lối mòn (tư duy)

        //    //tui mún send qua Telegram

        //    //NotiFunc f2 = SendTelegram; //LỐI MÒN

        //    NotiFunc f2 = delegate (string id, string message)
        //    {
        //        Console.WriteLine($"SEND TELE -> | TO {id} | MSG: {message}");
        //    };

        //    //xài như bình thường
        //    f2("MESSI TELE", "MÃI MÃI... TELE");

        //}

        public static void SendTelegram(string id, string message)
        {
            Console.WriteLine($"SEND TELE -> | TO {id} | MSG: {message}");
        }

        public static void SendWhatsApp(string id, string message)
        {
            //interpolation
            Console.WriteLine($"SEND WHATSAP | TO {id} | MSG: {message}");
        }

    }


}
