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

		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		//prop tab tab
		//Tìm hiểu thử propfull và prop
		//propfull sẽ sinh ra _backing field và get set, còn prop chỉ sinh ra get set
		//propfull sẽ giúp ta có thể tùy chỉnh get set, còn prop thì không thể tùy chỉnh get set, nó chỉ có thể tự động sinh ra get set
		//propfull sẽ giúp ta có thể tùy chỉnh get set, còn prop thì không thể tùy chỉnh get set, nó chỉ có thể tự động sinh ra get set
		/// <summary>
		/// Tên của loại trái cây	
		/// </summary>
	}
}
