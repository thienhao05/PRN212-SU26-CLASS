using System;
using System.Collections.Generic;

namespace Giaolang.DieuDao.GUI.Entities;

public partial class Fruit
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;
}
