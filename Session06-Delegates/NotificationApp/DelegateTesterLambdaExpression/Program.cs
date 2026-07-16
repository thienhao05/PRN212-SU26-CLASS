namespace DelegateTesterLambdaExpression
{
    //CHALLENGE: VIẾT HÀM NHẬN VÀO N VÀ IN RA BÌNH PHƯƠNG 
    //CẤM DÙNG HÀM LẺ HÀM RỜI
    //CẤM DÙNG CHỮ DELEGATE, VÌ NÓ BOILER PLATE

    public delegate void MathFunc(int n);
    internal class Program
    {
        static void Main(string[] args)
        {
            MathFunc f1 = delegate (int x)
            {
                Console.WriteLine($"{x}^ 2 = {x * x}");
                Console.WriteLine($"{x}^ 2 = {Math.Pow(x, 2)}");
                
            };

            f1(10); //10^2 = 100


            //KĨ THUẬT RÚT GỌN CHỈ CÒN CÁI DÂY NỊT
            MathFunc f2 =  (int x) =>
            {
                Console.WriteLine($"{x}^ 2 = {x * x}");
                Console.WriteLine($"{x}^ 2 = {Math.Pow(x, 2)}");

            };

            f2(10);

            // Nếu chỉ có 1 tham số xóa luôn kiểu dữ liệu
            MathFunc f3 = (x) =>
            {
                Console.WriteLine($"{x}^ 2 = {x * x}");
                Console.WriteLine($"{x}^ 2 = {Math.Pow(x, 2)}");

            };

            f3(10);
             
            // Nếu chỉ có tham số và bỏ ngoặc
            MathFunc f4 = x =>
            {
                Console.WriteLine($"{x}^ 2 = {x * x}");
                Console.WriteLine($"{x}^ 2 = {Math.Pow(x, 2)}");

            };

            f4(10);

            //Đây là 1 hàm nhận vào 1 tham số và kiểu void
            MathFunc f5 = x => Console.WriteLine($"{x}^ 2 = {x * x}");

            f5(10);


        }
    }
}

//const f = x => x * x;
//const f = x => {console.log(x * x);};

