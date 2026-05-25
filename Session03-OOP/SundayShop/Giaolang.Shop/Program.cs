using Giaolang.Shop.Entities;

namespace Giaolang.Shop
//~ package com.microsoft.sqlserver.
//đều có tên thương hiệu, chủ sở hữu sản phẩm
//dấu chấm chia tầng thư mục quản lí cho gọn gàng
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            CreateFruits();
        }

        public static void CreateFruits()
        {
            //tạo trái Mãng Cầu, y chang bên Java, import thay bằng using
            //in thông tin qua ToString()
            Fruit cau = new Fruit(); //object tạo ra, tốn ram, nhung vùng _ chứa giá trị default
            Console.WriteLine("MÃNG CẦU details: " + cau.ToString());

            Fruit sung = new Fruit("SS", "SUNG SƯỚNG", "SUNG LÀ TRÁI ĐẦU THỨ HAI TRONG MÂM NGŨ QUẢ", 5.0);//object tạo ra, tốn ram, nhung vùng _ chứa giá trị ĐC FILL QUA CONSTRUCTOR 

            Console.WriteLine("SUNG details: " + sung.ToString());

            //ko thấy định nghĩa document thì mình phải chuột vào property vào phần out chọn document file và click vào là xong
            //trái dừa
            Fruit dua = new Fruit("DD", "DỪA DỪA CX CX", "TRÁI DỪA LÀ...", 6.0);
            Console.WriteLine("DUA details: " + dua.ToString());

            //trái ĐU ĐỦ
            //tham số hàm, phải đưa đúng số thứ stt khai báo biến, data type 
            //Fruit du = new Fruit(7.0, "DU", "ĐU ĐỦ", "TRÁI DỪA LÀ..."); //ERROR LIỀN
            Fruit du = new Fruit(price: 7.0, id: "DU", description: "ĐU ĐỦ", name: "TRÁI DỪA LÀ...");
            //named-argument: truyền tham số cho hàm ko theo thứ tự đc yêu cầu
            //nhưng chỉ rõ biến nào của hàm nhận value nào, là okie
            //LỘN XỘN THỨ TỰ NHƯNG RÕ TÊN BIẾN THÌ OKIE

            Console.WriteLine("DU details: " + du.ToString());

            cau.SetId("MC");
            cau.SetDesc("MÃNG CẦU LÀ ĐẦU CÂU CHUYỆN...");
            cau.SetName("MÃNG CẦU");
            cau.SetPrice(4.0);

            Console.WriteLine("MÃNG CẦU details AFTER SETTING: " + cau.ToString());

            /*
            + Object có quyền thay đổi
            + Mỗi vùng new là new 1 chỗ mới trong RAM để chứa biến
            + Biến Object
            + 2 vùng khác nhau
            + Get, Set, Constructor
            + new qua con đường truyền thống, new rỗng và sửa lại
            + new qua cách truyền tham số full theo đúng thứ tự 
            + new qua name argument
            + DONE OOP: CĂN BẢN
            + HỌC GET, SET KIỂU MỚI, KO LÀM THEO KIỂU CŨ NÀY NỮA !!!
            + TƯƠNG ĐƯƠNG VÀ HAY HƠN JAVA GIẤU ĐI BIẾN _ ĐI VÀ HAY HƠN JAVA
            + CÁI GET, SET NÀY TRONG NGHỀ GỌI LÀ BOILER PLACE đoạn code rất nhàm chắc
            + Thật ra cần phải có ko có nó thì ko điều chỉnh đc thông tin, vấn đề là code này là rất nhàm chán, nó ko có hay
            + Cho nên lý do thằng C# phải ở đầu class mới spam ra đc vì nó biết là cái này cùi!!!
            + Java ko coi đó là điều tốn công
            + C# sẽ che, ẩn cái phần Get, Set lại
             */
        }
    }
}
