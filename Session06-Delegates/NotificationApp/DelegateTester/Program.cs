namespace DelegateTester
{
    //class here
    //public int yob = 2005; //ăn đòn, biến backing field phải nằm trong class
    //trong 1 package thì chứa class, delegate
    //trong namespace, hay còn lại package - thư mục chứa source code thì chỉ đc duyền khai báo, chứa chấp: class, interface, delegate (class đặc biệt gom chung tên hàm!!!)

    public class Student
    {
        //...prop tab tab
    }

    public interface IRepository
    {
        //hàm abstract ko có code
    }

    public delegate void Notification(string to, string msg);
    //public class Notification  ~~~~~ class Student
    //{
    //   _fName, _fReturned, _noOfParams, ...
    //}
    //vietsub: Notification là tên gọi chung cho 1 nhóm hàm có style
    //                                                          void F(string, string)
    //    ~~~  Student      là tên gọi cung cho 1 nhóm objet có style
    //                                                          (id, name, yob, gpa,...)
    //                                                           int, string, int, double

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");

        //    //data-type  biến = value;
        //    //Student      s1 = new Student(?, ?, ?, ?)
        //    //int         yob = 2005;
        //    //Notification f1 = ???; hàm nào đó cụ thể nào đó ở dưới miễn cùng style
        //    Notification f1 = SendSms;  //() thì nó hiểu là run hàm, trong khi mình chỉ gán hàm thôi
        //    //vietsub: f1 là hàm thuộc nhóm data type Notication 
        //    //            là hàm có style void F string string
        //    //            và cụ thể nó là hàm SendSms;
        //    //ko xài ngoặc tròn, vì đang gán value cho biến;
        //    //xài ngoặc tròn hiểu là run hàm

        //    //int yob = 2005; là gán value cho biến
        //    //cw(yob) mới là dùng biến

        //    //làm sao chạy hàm SendSms ???
        //    //thì ngoặc tròn
        //    //SendSms("090xxxx", "PE sít đát!!!");
        //    f1("090xxx", "PE sít đát!!!"); //mới ngầu!!!!!!!!!!!!!

        //    //f1 là 1 hàm thuộc nhóm noti nhận vào 2 hàm này

        //    //delegates: ủy quyền
        //    //Notification f1 = SendSms; 
        //    //        luật sự = thân chủ
        //    //        1 hàm gốc SendSms còn đc gọi là f1, ủy quyền, nick name là f1
        //    //luật sự nói cx là thân chủ nói
        //    //SendSms() run hàm thì f1() run hàm!!!

        //    //int yob = 2005;  yob = 2006;
        //    f1 = SendEmail; //luật sư có thân chủ mới
        //    f1("@.com", "Gửi mail nè");
        //    //delegate là class gom tên hàm

        //}


        //svm tab
        static void Main(string[] args)
        {
            Notification f = SendSms;

            f += SendEmail; //int a = 5; a += 10; 
            //1 luật sư 2 thân chủ 
            f("To ai đó", "Tin nhắn gì đó");
            //delegate multicast - lan truyền, quảng bá, tới nhiều,...

            //biểu thức landa

        }

        public static void SendSms(string phone, string msg) 
        {
            Console.WriteLine($"SMS, send to: {phone} | msg: {msg}");
        }
        public static void SendEmail(string email, string content) 
        {
            Console.WriteLine($"EMAIL, send to: {email} | msg: {content}");
        }
    }

    //class here
}
