namespace Q1
{
    //1 hàm, 1 dịch vụ chuyên việc in ấn thiết kế poster, banner
    //chỉ yêu cầu, muốn in gì thì đưa info, 1 con số (dv làm số nhà, số xe)

    public delegate void PrintNumberFunc(double num);
    //                    cứ đưa số, in theo nhu cầu

    //CHALLENGE: VIẾT CLASS BANKACCOUNT VA IN SỐ DƯ KHI RÚT TIỀN, VIỆC IN GỌI HÀM TỪ BÊN NGOÀI ĐỂ IN

    //VIẾT CLASS NGAY ĐÂY KO TÁCH, LÀM BIẾNG TÁCH FILE RIÊNG THÔI
    public class BankAccount
    {
        private PrintNumberFunc _notiMsgHandler; //chưa gán hàm cụ thể; nhưng sure mày là hàm nhận 1 con double và làm gì đó!


        private string _owner; //tên, còn bổ sung số tk .. tạm thời bỏ qua
        private double _balance; //số dư, thối thiểu 50k, tạm thời chưa làm cho đơn giản

        //ctor tab ra constructor rỗng
        public BankAccount(string owner, double balance, PrintNumberFunc notiFunc)
        {
            _owner = owner;
            _balance = balance;
            _notiMsgHandler = notiFunc;
        }

        //hàm quan trọng nhất, rút tiền, tạm bỏ qua việc check số dư
        public void Withdraw(double amount)
        {
            //đưa vào số tiền rút, trừ với balance
            _balance -= amount;

            //gọi hàm in ấn, outsource bên ngoài thay vì tự in!!!!!!
            //Console.WriteLine("SỐ DƯ HIỆN TẠI " + _balance);
            //tor browser

            //callback here gọi giật lại 1 hàm từ nơi khác, ko phải trong class này!!!, y chang mình gửi link callback của mình cho vnpay, payos gọi ngược lại mình

            //hàm: tạo hàm ở bên ngoài, gọi hàm ở đây
            //1. tạo hàm in ở bên ngoài class này
            //2. gọi hàm thì ở đây!!!
            //đang chơi hệ outsource: mình chỉ gọi thôi, để họ làm
            _notiMsgHandler(_balance); //xong việc in ra bên ngoài

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //có dịch vụ in ấn đã, vì bank nó outsource
            PrintNumberFunc f = x => Console.WriteLine("SỐ DƯ QUÝ KHÁCH LÀ: " + x);
            //đưa f vào bank!!! QUA CON ĐƯỜNG CONSTRUCTOR, HOẶC SET 


            BankAccount hoangNT = new BankAccount("HOANG NGOC TRINH", 2350000, f);

            //rút tiền đổi ngành
            hoangNT.Withdraw(2350000);
            hoangNT.Withdraw(3000000);

        }

        public static void TestDelegete()
        {
            //in thử số nhà:
            //PrintNumberFunc fAddress = delegate (double x)
            //{
            //    Console.WriteLine("Số nhà là: " + x);    
            //};

            PrintNumberFunc fAddress = x => Console.WriteLine("Số nhà là: " + x);

            // đây mới là hàm, viết style mới thôi, chư gọi
            //y chang như mình tạo hàm lẻ rồi mới gọi
            //gọi có 2 cách, tên hàm(tham số)
            //               tenham.Invoke(tham số)

            //hàm có 1 tham số nhận vào con số, và làm gì với con số đó
            //tạo hàm và gọi hàm
            //tạo hàm trước và gọi hàm viết ngay cùng chỗ
            fAddress(2350000);


            //LÍ THUYẾT CHUNG: TẠO HÀM, GỌI HÀM (2 VIỆC)

            //in số dư tài khoản, xài biến mới

            PrintNumberFunc fBalance = x => Console.WriteLine($"SỐ DƯ LÀ: x");
            fBalance(30000000);
        }
    }
}

//lẻ ra mình làm đc việc, nhưng mà mình outsource đẩy ra ngoài, cho nên cần 1 hàm bên ngoài để gọi
//callback function: Đây chính là thanh toán online, yêu cầu đưa URL yêu cần gọi ngược lại
//gọi ngược lại VNPay làm xong thì nó báo ngược lại cho mình, báo đã thanh toán thành công
//mình đưa cho nó cái trang, nó gọi ngược lại cho mình