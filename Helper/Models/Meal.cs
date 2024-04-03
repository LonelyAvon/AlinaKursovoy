using System;
using System.Collections.Generic;

namespace Helper;

public partial class Meal
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Eat> Eats { get; set; } = new List<Eat>();
}
