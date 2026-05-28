using System;
using System.Collections.Generic;
using System.Text;

namespace Giaolang.Shop.PropFull.Entities
{
    public class Category
    {
		private int _id;
		private string _name; //Trái cây nhập khẩu
                              //Trái cây VietGAP
                              //Trái cây sấp khô
                              //...


        //ko cần thiết vội là cst full mà làm constructor rỗng sau đó dùng oject initializer new và set cùng lúc
        //new Category() { Id = ???, Name = ??? };   //mùi JSON

        //phím nóng tạo constructor rỗng
        //ctor tab tab cho nhanh thay vì phải chuột | quick actions | generate...

        public Category()
        {

        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Id
		{
			get => _id; 
			set => _id = value; 
		}


	}
}
