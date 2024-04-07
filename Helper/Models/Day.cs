using System;
using System.Collections.Generic;

namespace Helper;

public partial class Day
{
    public int Id { get; set; }

    public string? Uuid { get; set; }

    public DateOnly? Datenow { get; set; }

    public int? Ccal { get; set; }

    public int? Proteins { get; set; }

    public int? Fats { get; set; }

    public int? Carbohydrates { get; set; }

    public double? Water { get; set; }

    public double? Weight { get; set; }

    public int? Ccaleat { get; set; }

    public int? Proteinseat { get; set; }

    public int? Fatseat { get; set; }

    public int? Carbohydrateseat { get; set; }

    public virtual ICollection<Eat> Eats { get; set; } = new List<Eat>();

    public virtual User? Uu { get; set; }
}
