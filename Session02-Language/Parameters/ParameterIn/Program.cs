namespace ParameterIn
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //DoSquare(10);
            DoSquareV2(10);
        }

        //CHALLENGE 1: VIẾT HÀM NHẬN VÀO 1 CON SỐ, BÌNH PHƯƠNG NÓ, VÀ IN RA
        //IN LÀ KEYWORD TRONG C# GIÚP BIẾN ĐẦU VÀO CỦA HÀM THÀNH READ ONLY
        
        public static void DoSquareV2(in int x)
        {
            //x = x * x; //lỗi, cấm thay đổi đầu vào, 
            Console.Write($"{x}^2 = {x * x}");
        }

        public static void DoSquare(int x)
        {
            Console.Write($"{x}^2 = ");
            x = x * x;
            Console.WriteLine($"{x}");
            //Console.WriteLine($"result: {Math.Pow(x, 2)}");
        }
    }
}
