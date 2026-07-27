using System;
using System.Collections.Generic;

namespace Q2.DieuDao.DAL.Entities;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Fruit> Fruits { get; set; } = new List<Fruit>();
}
