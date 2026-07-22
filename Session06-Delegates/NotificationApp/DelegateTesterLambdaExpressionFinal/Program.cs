namespace DelegateTesterLambdaExpressionFinal
{
    public delegate void VoidOneIntParamsFunc(int x);
    public delegate int IntOneIntParamsFunc(int x);

    internal class Program
    {
        static void Main(string[] args)
        {
            TestReturnedLambda();
        }


        public static void TestReturnedLambda()
        {

            //IntOneIntParamsFunc f = delegate (int x) {
            //              return x * x;
            //};
            IntOneIntParamsFunc f = x => x * x;

            //int result = f(100);
            //Console.WriteLine(result);

            Console.WriteLine(f(100));
        }

        public static void TestVoidLambdaV2()
        {
            //hàm nhận vào 1 tham số và in ra bình phương
            VoidOneIntParamsFunc f = x =>
            {
                Console.WriteLine($"{x}^2 = {x * x}");
            };

            f = x => Console.WriteLine($"{x}^2 = {x * x}");

            f(10);
        }

        public static void TestVoidLambda()
        {

            //VoidOneIntParamsFunc f = delegate (int x) { };
            //VoidOneIntParamsFunct f = (int x) => { };
            //VoidOneIntParamsFunct f = (x) => { };
            //VoidOneIntParamsFunct f = x => { };

            VoidOneIntParamsFunc f = x =>
            {
                Console.WriteLine("The list of ...");
                for (int i = 1; i <= x; i++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            };

            f(1000); //xài hàm
        }
    }
}


//CHALLENGE #1:
//VIẾT HÀM NHẬN VÀO 1 CON SỐ NGUYÊN N > 0
//IN RA CÁC SỐ TỪ 1 ĐẾN N

//CHALLENGE #2:
//VIẾT HÀM NHẬN VÀO 1 CON SỐ NGUYÊN N > 0
//IN RA BÌNH PHƯƠNG CỦA NÓ, NHẬN 5 IN 25, NHẬN 10 IN 100 ...

//CHALLENGE #3:
//VIẾT HÀM NHẬN VÀO 1 CON SỐ NGUYÊN N > 0
//VÀ TRẢ VỀ BÌNH PHƯƠNG 
//DELEGATE MỚI HOÀN TOÀN, VÌ THẰNG CŨ LÀ VOID
