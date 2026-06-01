using Giaolang.Shop.PropAuto.Entities;
using System.Numerics;

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

            //cau = null;

            //Console.WriteLine($"CẦU info: {cau.Id} | {cau.Name} | {cau.Desc} | {cau.Price}");

            //nhân chuyện học null
            //null là thứ của biến object, mang ý nghĩa biến object tạm thời trỏ đấy ram, tạm thời chưa trỏ vùng new nào cả
            //biến-obj = null; hết sức bình thường!!!
            //nhưng int yob = null; ko được 
            //          double price = null; ko đc
            //là biến primitive, value cất thẳng trong biến
            //value phải là con số cụ thể nào đó!!!!
            //Java, C# y chang vụ này
            //int yob = 2005;
            //yob = null; //vỡ mặt

            //JAVA, MUỐN NÓI RẰNG YOB LÀ NULL, TA PHẢI BAO NÓ LẠI THÀNH BIẾN OBJECT, TỐN RAM HƠN
            //Integer yob; -> trỏ vùng new Integer chứ int bên trong => CLASS TRAI BAO, WRAPPER CLASS
            //long/Long, int/Integer, double/Double, char/Character

            //C# BẢO, KO CẦN TRAI BAO, HỖ TRỢ NULL TỪ PRIMITIVE
            int? yob = null; //cột này null, unknown trong DB
            //long? char? bool? double? float?

            //Student? Fruit? -> có ? cx đc, ko có cũng ko sao ???

            //? MỞ RỘNG TẬP DATA, ĐẶC BIỆT PRIMITIVE DATA TYPE: int, long, float, double, boolean, char,..ĐỂ CHỨA THÊM ĐC GIÁ TRỊ NULL => DATA TYPE NÀY ĐC GỌI TÊN MỚI:
            //NULLABLE DATA TYPE - EM CÓ THỂ MANG NULL

            //Student an = new()
            //{
            //    Id = "SE123456",
            //    Name = "AN NGUYEN", 
            //    Yob = null,
            //    Gpa = null,
            //};

            Student an = new()
            {
                Id = "SE123456",
                Name = "AN NGUYEN",
            };

            Console.WriteLine("AN INFO: " + an.ToString());

        }
    }
   
    //CLASS KHÁC THÍ NGHIỆM
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double? Gpa { get; set; }

        //ko nhập là số 0
        public override string ToString()
        {
            return $"{Id} | {Name} | {Yob} | {Gpa}";
        }
    }
}

//PRIMITIVE DATA TYPE TRONG JAVA: int, long, float, double, char, boolean
//C#: VALUE TYPE
//CẢ 2 THẰNG CHỈ TỐN 1 VÙNG RAM, LƯU VALUE NGAY TRONG VÙNG RAM BIẾN
//KHÁC VỚI BIẾN OBJECT, BIẾN CON TRỎ:
//2 VÙNG BIẾN: 1 VÙNG BIẾN CON TRỎ, TỐN THÊM VÙNG NEW ĐỂ CHỨA VALUE/OBJECT
//BIẾN PRIMITVE LẤY VALUE XÀI LUÔN, ĐỨA NÀO MÀ CHẤM -> LỆ PHÍ ĐỔI NGÀNH 2 TRIỆU 3 NĂM CHỤC