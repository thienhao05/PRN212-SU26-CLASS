using System;
using System.Collections.Generic;

namespace Giaolang.DieuDao.GUI.Entities;

public partial class Fruit
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int CategoryId { get; set; } //cột FK góc nhìn DB

    public virtual Category Category { get; set; } = null!;
    //             Major    major; (id, name, desc)
    //             góc nhìn object. Tui, Bạn, có Ba, Má (id, name, ....)

    //Book { id, title, pages, nxb, price, author_id (FK), Author author }


}
