using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTester
{
    /// <summary>
    /// CLB của những gã co giãn...
    /// </summary>
    public interface IResizable
    {
        //interface là 1 dạng class Cha đặc biệt, chỉ chứa hàm ko có code - gọi là abstract method
        //nó giống như CLB chiêu dụ có nội quy, hành động (abstract method)
        //chờ Anh Em class Con tham gia dk member =>
        //Anh Em hành động nội quy theo cách của họ => implementation, viết code cho hàm abtract ko code
        //Xài: Khai Cha new Con...
        //Interface hóa giải đa kế thừa, Con nhiều Cha
        //Java C# giống nhau: Con chỉ có tối đa 1 Cha (kế thừa máu mủ họ hàng) và có thể tham gia nhiều CLB - interface

        public void Resize(double size); //mỗi cạnh tăng lên mấy lần...

        
    }
}
