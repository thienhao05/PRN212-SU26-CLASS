using Giaolang.Shop.Prop.Entities;

namespace Giaolang.Shop.Prop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit cau = new Fruit();
            cau.Name = "MÃNG CẦU GAI"; //HÀM SET CHẠY NGẦM VÌ ĐANG LÀ SET BIẾN NAME = "MÃNG CẦU GAI"
            //MÃNG CẦU GAI -> value -> _name = value;
            cau.Description = "Mãng cầu là...."; //setDescription("mãng cầu là")
            cau.Price = 5.0;
            //Console.WriteLine("GET STYLE MỚI: " + cau.Name); //tên biến đã là get
            //get chạy -> return _name;
            Console.WriteLine("MC FULL: " + cau.ToString());
        }
    }
}
