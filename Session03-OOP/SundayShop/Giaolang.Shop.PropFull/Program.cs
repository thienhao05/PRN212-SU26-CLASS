using Giaolang.Shop.PropFull.Entities;

namespace Giaolang.Shop.PropFull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new trái cây theo nhiều style
            Fruit cau = new Fruit(1, "MÃNG CẦU", "MÃNG CẦU LÀ ....", 5.0);
            
            Fruit sung = new Fruit(name: "SUNG", description: "SUNG SƯỚNG LÀ ....", price: 6.0, id: 2); //name argument

            Fruit dua = new(3, "DỪA", "DỪA LÀ ....", 7.0); //cú pháp mới ăn bớt vế phải

            var du = new Fruit(4, "ĐU ĐỦ", "ĐU ĐỦ CX CX LÀ ....", 8.0); //ăn bớt vế trái, type inferrent: dựa trên data đưa vào

            var yob = 2005; //tự suy rằng yob là int do ăn theo value
            //xài var thì phải gắn value ngay lúc khai báo, ko gán value ko căng được RAM để bố trí biến
            //var x; sai nhen, sai cú pháp nhen

            //CÁCH MỚI NHẤT HIỆN NAY, ĂN THEO PROPERTY
            Fruit xoai = new(); //bạn có 1 tờ giấy trắng, constructor rỗng đc dùng
            //set từng field 
            xoai.Id = 5;
            xoai.Price = 9.0; //xài hàm set style mới - dùng Property = 
            xoai.Name = "XOÀI CÁT";

            Console.WriteLine("ĐỦ info: " + du.Id + " | " + du.Name + " | " + du.Price);

            Console.WriteLine($"XOÀI info: {xoai.Id} | {xoai.Name} | {xoai.Price} | {xoai.Description}");

            //VỪA NEW GỌI SET KIỂU MỚI.............
            Fruit cr = new()
            {
                //này là mình đã set rồi
                Name = "Cherry Kangagroo",
                Price = 10,
                Description = "Cheery xứ chuột túi...",
                Id = 6
                //viết gộp new và set, ĐC GỌI LÀ KĨ THUẬT OBJECT INITIALIZER
            };
            

        }
    }
}
