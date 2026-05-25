using System;
using System.Collections.Generic;
using System.Text;

namespace Giaolang.Shop.Prop.Entities
{
    public class Fruit
    {
        private string _id;
        private string _name; //chống lưng cho thằng đại diện Name
                              //backing field

        private string _description;
        public double _price;
        //get set kiểu mới
        public string Name //property of a class/object
        {                   //là biến chữ hoa từ backing field 
                            //đóng 2 vai get set, giúp chơi gọi set get tự nhiên như xài biến bình thường
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public override string? ToString()
        {
            return $"{_id} | {_name} | {Description} | {Price}";
        }
    } 
}
