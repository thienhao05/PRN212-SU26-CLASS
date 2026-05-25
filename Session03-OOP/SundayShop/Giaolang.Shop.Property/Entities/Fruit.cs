using System;
using System.Collections.Generic;
using System.Text;

namespace Giaolang.Shop.Property.Entities
{
    public class Fruit
    {
        public string _id;
        public string _name;
    } 
    //vi phạm ENCAPSULATION
    //mọi thứ bên trong object public hết
    //ai cx sửa được
    //ngoài đời, nhà mình có chuyện gì, đừng public lên mạng
    //public vi phạm ENCAP, nhưng ko bị boiler-plate get/set
    //CÓ CÁCH NÀO, KO VI PHẠM ENCAP, NHƯNG KO BOILER-PLATE
    //C# ĐƯA RA 1 BIẾN MỚI ĐÓNG VAI GET SET QUA BIẾN NÀY
    //NHƯNG PHÍA SAU LÀ CHƠI VỚI _
    //biến _ trở lại private, 
    //mướn 1 biến khác public đóng vai Get Set (vì biến thì có sẵn get/set)
}
