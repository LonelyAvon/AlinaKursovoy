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

    public int? IdDay { get; set; }

    public string? Uuid { get; set; }

    public virtual Day? IdDayNavigation { get; set; }

    public virtual Meal? IdMealNavigation { get; set; }
}
