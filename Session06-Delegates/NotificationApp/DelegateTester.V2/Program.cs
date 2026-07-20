namespace DelegateTester.V2
{
    //CHỖ NÀY CHỨA CHẤP: public class Student { ... }
    //                   public interface IRepository { ... }
    //                   public delegate ??? là 1 loại class dùng để lưu info các hàm
    //                                              thay vì info object bình thường
    //LỜI KHUYÊN NHA SĨ: NÊN TÁCH CÁC CLASS RA NHỮNG TẬP TIN RIÊNG!!!!

    public class Student //tách thành 1 tập tin riêng, đã học rồi
    {
        //prop tab tab
        private string id;
        //....
    }

    public delegate void NotificationFunction(string to, string msg);
    //public class NotificationFunctions {
    //      private string tenHam, traVe-void, soThamSo, body
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //GỬI TIN NHẮN, GỌI HÀM Ở DƯỚI, NHƯNG CẤM XÀI TRỰC TIẾP HÀM!!!
            //PHẢI LÀM VIỆC QUA LUẬT SƯ, QUA GÃ ỦY QUYỀN - DELEGATE


            //SendWhatsApp("MESSI", "MÃI MÃI MỘT TÌNH YÊU <3");

            NotificationFunction f;
            //vietsub: f là 1 hàm bất kì nào đó và có style void 2 tham số chuỗi!!! y chang int yob là con số nguyên bất kì và ....

            f = SendWhatsApp; //ko ngoặc nhen!!!! 
            //gán giá trị
            //luật sư = thân chủ, kế từ nay hàm SendWhatsApp còn gọi là f
            //chạy hàm WhatsApp cũng là chạy f và ngược lại
            f("MESSI", "MÃI MÃI MỘT TÌNH YÊU (by delegate)!!!");
        }

        //hàm gửi tin nhắn lên WhatsApp
        public static void SendWhatsApp(string id, string message)
        {
            //interpolation
            Console.WriteLine($"SEND WHATSAP | TO {id} | MSG: {message}");
        }


    }
}
