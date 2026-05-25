using System;
using System.Collections.Generic;
using System.Text;

namespace Giaolang.Shop.Entities
{
    public class Fruit  //class như cái khuôn, biểu mẫu, form, template, blue-print
    {

        private string _id;  //field, đặc tính của class/object dùng _và Con Lạc Đà
                             //ví dụ: _name, _basicSalary
        private string _name;               //_name : ___________

        private string _description;        //_desc : __________________________

        private double _price;              //_price: _____.__

        public Fruit()
        {
        }

        public Fruit(string id, string name, string description, double price)
        {
            _id = id;
            this._name = name;  //thừa this. dù luôn có this
                                //con trỏ trỏ chính mình, cái tui cá nhân
                                //dùng nó khi có sự nhầm lẫn giữa biến bên ngoài / tham số hàm và biến nội tại của object, class
                                //members of a class (_id, _name, _desc, _price
            _description = description;
            _price = price;
        }

        //@Override
        public override string? ToString()
        {
            //return base.ToString();  //~ super. Java
            return $"{_id} | {_name} | {_description} | {_price}";
        }

        //clone biểu mẫu để mỗi người fill vào - construct - constructor
        //hàm nhận vào info, fill vào form để thành 1 object của riêng ai đó
        //tự gõ hoặc nhờ tool generate
        //class có nhiều constructor ~ nhiều cách điền info vào object hay biểu mẫu
        //constructor rỗng, ko nhận vào gì cả, thì ta có 1 form trống - default giá trị

        //get, set: cho xem sau khi đã điền
        //toString(): xem hết, get hết info trong 1 lượt
        //C#: Get, Set, ToString() 



    }
}
