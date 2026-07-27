namespace PEReady
{
    public delegate void BankNotiFunc(double amount);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            BankNotiFunc t = amount => Console.WriteLine($"Quý khách vừa rút {amount} vnđ");

            t(500); //màn hình sẽ in? Quý khách vừa rút 500000 vnđ
        }
    }
}

//HACK NÃO Ở NHÀ
//MÌNH CÓ 1 Account Class để biểu diễn tài khoản ngân hàng của ai đó
/*
class Account
{
    _name;
    _balance;
    
    hàm Widthdraw(amount)
    {
        if amount < balance 
            _balance = _balance - _amount;
        ngược lại ko cho rút
        
        //nếu rút thành công, thì in ra câu thông báo
        "Quý khác vừa rút amount vnđ"
        //CẤM XÀI cw trong hàm rút tiền
        //NHỜ HÀM KHÁC IN GIÚP - DELEAGATE IN GIÚP
        //CALLBACK!!!!!!!!!!!!!!!!
    }

}

hàm truyền vào hàm

 */

/*
 
class BankAccount 
{
    PrintMsg _pe;

    private string _name;
    private double _balance; //100

    public void void RutTien(double amount)
    {
        _balance = balance - amount;
        //Int + báo: SMSS, Email;
        cw(_balance); ///// Hàm In() gọi

        gọi f(_balance)

        _pe(_balance)
    }


class cứ làm việc của mình, nhờ vả thêm 1 hàm bên ngoài


}


public delegate void PrintMsg(double x); //hàm chỉ nhận vào x,  làm gì ko care


Main() {
    
    1. Dùng hàm
    2. Ẩn danh
    3. Lamda
    4. Dùng object tạo 1 class

    PrintMsg f = amount => cw("Số dư là: " + amount);


}


 
 */