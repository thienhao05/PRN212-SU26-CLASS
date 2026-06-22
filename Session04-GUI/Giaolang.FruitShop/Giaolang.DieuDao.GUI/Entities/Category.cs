using System;
using System.Collections.Generic;
using System.Text;

namespace Giaolang.DieuDao.GUI.Entities
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        //table | ID  | Name               | Desc         |
        //      | 1   | Trái cây VietGAP   | Canh tác ... |
        //      | 2   | Trái cây nhập khẩu | ..........   |
    }
}
