using System;
using System.Collections.Generic;

namespace Helper;

public partial class Eat
{
    public int Id { get; set; }

    public int? IdMeal { get; set; }

    public string? Name { get; set; }

    public int? Ccal { get; set; }

    public int? Weight { get; set; }

    public int? Proteins { get; set; }

    public int? Fats { get; set; }

    public int? Carbohydrates { get; set; }

    public virtual ICollection<Dayeat> Dayeats { get; set; } = new List<Dayeat>();

    public virtual Meal? IdMealNavigation { get; set; }
}
