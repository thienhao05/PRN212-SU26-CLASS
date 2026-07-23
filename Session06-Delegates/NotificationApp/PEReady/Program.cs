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
    }

}

hàm truyền vào hàm

 */
