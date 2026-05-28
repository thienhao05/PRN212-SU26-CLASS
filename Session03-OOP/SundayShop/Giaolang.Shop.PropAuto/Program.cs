using Giaolang.Shop.PropAuto.Entities;

namespace Giaolang.Shop.PropAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KHỎI CẦN CTOR RỖNG VÌ CLASS MÀ KO CÓ CTOR THÌ MẶC NHIÊN SDK LCU1 BIÊN DỊCH CODE TỰ TĂNG THÊM CTOR RỖNG - Y CHANG JAVA,, LÚC NÀY TA NEW OBJECT RỖNG CÁC FIELD NHƯ TỜ FORM CHƯA ĐIỀN -> DÙNG SET MÀ CHƠI, HOẶC NEW VÀ OBJECT INITIALIZER
            Fruit cau = new Fruit()
            {
                Name = "Mãng Cầu",
                Price = 5.0,
                Desc = "....",
                Id = 5,
            };

            Console.WriteLine($"CẦU info: {cau.Id} | {cau.Name} | {cau.Desc} | {cau.Price}");

            cau = null;

            Console.WriteLine($"CẦU info: {cau.Id} | {cau.Name} | {cau.Desc} | {cau.Price}");
        }
    }
}
