namespace ParameterOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintIntList();
            //Console.WriteLine($"The sum of interger list from 1 to 10: {SumIntList()}");
            //Console.WriteLine($"The sum even of interger list from 1 to 10: {SumEvenList()}");
            //out giúp mình có thể vừa sum, count,...
            //int sumE;
            //int sumAll = ProcessIntList(out sumE);
            //Console.WriteLine($"SUM ALL: {sumAll} | SUM EVEN: {sumE}");

            //sumAll = ProcessIntList(out int sumAllEvens);

            //PrintIntList();
            //int sum = SumEvenList();
            //Console.WriteLine("The sum of even list from 1 to 10: " + sum);

            int allSum = ProcessIntList(out int eSum, out int eCount); // inline declaration

            Console.WriteLine("Sum all: " + allSum);
            Console.WriteLine("Count evens: {0}", eCount);
            Console.WriteLine($"Sum evens: {eSum}");
            // là có thể trả ra 1 cái tổng và nhiều cái phụ trong đó
            // giống như truyền tham chiếu, bên trong thay đổi gì thì bên ngoài hốt đủ luôn

        }

        //CHALLENGE 4: VIẾT 1 HÀM TRẢ VỂ 2 THỨ:
        //TỔNG CHẴN TỪ 1 .. 10
        //TỔNG ALL  TỪ 1 ĐẾN 10
        //TUI MUỐN NHẬN VỀ 30 VÀ 55
        //THUA VÌ HÀM CHỈ CÓ 1 LỆNH RETURN
        //HOẶC RETURN MẢNG, HOẶC RETURN ARRAYLIST
        //out ở tham số nào thì tương đương
        //TUI, HÀM HỨA SẼ CÓ 1 VALUE ĐC GÁN CHO BIẾN OUT TRONG HÀM ~~ 1 LỆNH RETURN NHƯNG KO CẦN GHI RÕ RETURN
        public static int ProcessIntList(out int evensSum, out int evensCount)
        {
            evensSum = 0;    //tổng số của các số chẵn
            evensCount = 0;  //tiện đếm luôn số con số chẵn
            int allSum = 0;
            for (int i = 1; i <= 10; i++)
            {
                allSum += i;  //cứ gặp số là cộng => tổng all

                if (i % 2 == 0)  //hỏi thêm có chẵn ko
                {
                    evensSum += i;
                    evensCount++;
                }  //2 4 6 8 10  => tổng 30 5 con chẵn
            }

            return allSum;
        }

        

        //public static int ProcessIntList(out int sumEven)
        //{
        //    sumEven = 6969;
        //    return 8386;
        //}


        //CHALLENGE 3: VIẾT HÀM TRẢ VỀ TỔNG CỦA CÁC SỐ CHẴN TỪ: 1..10: 2 4 6 8 10 = 30
        public static int SumEvenList()
        {
            //kĩ thuật ốc bu nhồi thịt, con heo đất
            //cộng dồn
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        //CHALLENGE 2: VIẾT HÀM TÍNH TỔNG TRẢ VỀ TỔNG CỦA CÁC SỐ TỪ 1...10
        //1 2 3 4 5 6 7 8 9 10 => 55
        public static int SumIntList()
        {
            //kĩ thuật ốc bu nhồi thịt, con heo đất
            //cộng dồn
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            return sum;
        }




        //CHALLENGE 1: VIẾT HÀM IN RA CÁC SỐ TỪ 1 ĐẾN 100 (LÁT HỒI 10)
        public static void PrintIntList()
        {
            Console.WriteLine("The list of numbers from 1 to 100");

            for (int i = 1; i <= 100; i++)
            {
                Console.Write("{0} ", i);
                //Console.Write($"{i} ");
            }
            //sống có trách nhiệm, xuống hàng sau khi in xong
            Console.WriteLine();
        }
    }
}
