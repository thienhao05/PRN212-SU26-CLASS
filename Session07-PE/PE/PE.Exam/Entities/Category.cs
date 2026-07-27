using System;
using System.Collections.Generic;

namespace PE.Exam.Entities;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Fruit> Fruits { get; set; } = new List<Fruit>();
}
