using Giaolang.Shop.Property.Entities;

namespace Giaolang.Shop.Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit cau = new Fruit();
            cau._name = "MÃNG CẦU"; //hàm set rồi đó
            cau._id = "MC";

            //in thử thì phải xài Get do mình chưa làm ToString();
            //lấy tên biến là Get đó nhen, get giá trị của biến
            Console.WriteLine("ID: " + cau._id);
            Console.WriteLine("NAME: " + cau._name);
        }
    }
}
