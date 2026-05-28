using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace Giaolang.Shop.PropAuto.Entities
{
    public class Fruit
    {
		public int Id { get; set; } //_id tự gen
		public string Name { get; set; } //_name tự gen
		public string Desc { get; set; }
		public double Price {  get; set; }

        //TỰ ĐỘNG LÚC BUILD APP, .NET SDK SẼ GENERATE GIÚP 1 BIẾN _id, _name, _desc, _price
        //KĨ THUẬT NÀY GIẤU ĐI BACKING FIELD NHƯNG NÓ VẪN TỒN TẠI
        //KĨ THUẬT NÀY ĐC GỌI LÀ AUTO IMPLEMENTED PROPERTY

        //EM LỠ QUÊN CÚ PHÁP: EM GÕ PROP TAB TAB
        //GIỜ ĐÃ HIỂU TẠI SAO C# KO CÓ PHÍM GENERATE GET SET TRUYỀN THỐNG VÌ ĐÃ CHUYỂN SANG 
        //PROFULL TAB TAB 
        //PROP TAB
        //JAVA CHÍNH HÃNG KO CÓ
        //NHƯNG 1 NHÓM DEV THỨ 3 CHẾ RA THƯ VIỆN KIỂU KIỂU NÀY, TRÁNH BOILDER PLATE GET SET TOSTRING CONSTRUCTOR NEW KIỂU MỚI LUÔN - BUILDER
        //CHÍNH LÀ LOMBOK




        //      private int _id;

        //private string _name;

        //public string Name
        //{
        //	get =>  _name; 
        //	set => _name = value;
        //}

        //      public int Id
        //      {
        //          get => _id;
        //          set => _id = value;
        //      }

    }
}
