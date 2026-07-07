using System;
using System.Collections.Generic;
using System.Text;

namespace Giaolang.Shop.PropFull.Entities
{
    public class Fruit
    {
        //profull -> tab tab
		//NẾU QUÊN CÚ PHÁP _BACKING FIELD VÀ GET SET STYLE MỚI
		//TA GÕ PROFULL TAB TAB TỰ SINH _BACKING FIELD VÀ GET, SET, TA TỰ ĐỘ LẠI
		//ctrol H thay thế code

		private int _id;                    //id:    ______________
		private string _name;               //name:  ______________
		private string _description;        //desc:  ____________________
		private double _price;

        public Fruit() //new trống trơn và gọi hàm set() style Prop
        {               //.Id =         .Name =      .Price = 
        }

        public Fruit(int id, string name, string description, double price)
        {
            _id = id;
            _name = name;
            _description = description;
            _price = price;
        }





        //constructor: phải chuột trên tên class chọn Quick Actions | Generate
        //ko có generate get/set như Java vì C# chơi trò get set mới - PROPERTY
        //phóm nóng hỗ trợ là profull tab tab: full: có backing và Property
        //backing: nhà bếp, Property: tiếp tân, bồi bàn


        public double Price //Property
        {
            get => _price; //string GetPrice() {...}
            set => _price = value;
        }

        public string Description
        {
            get => _description; //string GetDescription() {...}
            set => _description = value; 
        }

        public string Name
        {
            get => _name; //string GetName() {...}
            set => _name = value;
        }



        public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

        //prop tab tab
        //Tìm hiểu thử propfull và prop
        //propfull sẽ sinh ra _backing field và get set, còn prop chỉ sinh ra get set
        //propfull sẽ giúp ta có thể tùy chỉnh get set, còn prop thì không thể tùy chỉnh get set, nó chỉ có thể tự động sinh ra get set
        //prop tab tab

        //@Override
        public override string ToString()
        {
            return $"{Id} | {_name} | {Description} | {_price}";
        }
        
    }
}
