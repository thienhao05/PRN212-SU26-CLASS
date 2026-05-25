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

        private double _price;              //_price: _____.__ //thập phân

        //hàm Get() trả về info lẻ, ToString() trả full, trả sỉ
        //y chang: tên bạn là gì, học ngành gì, sinh năm bao nhiêu?

        public string GetName()
        {
            return _name; //ko cần this. nếu thích cứ làm, ko sai!!!
        }
        public string GetDesc() => _description; //ko cần this. nếu thích cứ làm, ko sai!!!
        //cú pháp rút gọn hàm chỉ có 1 câu lệnh: expression bodied

        public double GetPrice() => _price;

        //HÀM SET, NHẬN ĐẦU VÀO ĐÈ VÀO BÊN TRONG TƯƠNG ỨNG NHƯ BÊN JAVA
        //TẤY, XÓA, SỬA BÀI LÀM TRƯỚC KHI NỘP, SETTING CÁI CẤU HÌNH ĐIỆN THOẠI MỚI MUA
        public void SetName(string name)
        {
            this._name = name; // ko cần do đã khác tên biến
        }

        public void SetDesc(string desc) => _description = desc; // ko cần do đã khác tên biến

        public void SetPrice(double price) => _price = price;

        public void SetId(string id) => _id = id;

        public Fruit()
        {
        }

        /// <summary>
        /// Tạo mới thông tin trái cây
        /// </summary>
        /// <param name="id">mã số trái cây max 5 ký tự</param>
        /// <param name="name">tên trái cây max 50</param>
        /// <param name="description">mô tả trái cây max 255</param>
        /// <param name="price">giá tiền số thực .</param>
        public Fruit(string id, string name, string description, double price)
        {
            _id = id; //ko gây xung đột tên
            this._name = name;  //thừa this. dù luôn có this
                                //con trỏ trỏ chính mình, cái tui cá nhân
                                //dùng nó khi có sự nhầm lẫn giữa biến bên ngoài / tham số hàm và biến nội tại của object, class
                                //members of a class (_id, _name, _desc, _price)
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

        //C# đưa ra 1 cơ chế, get, set đặt biệt

    }
}
