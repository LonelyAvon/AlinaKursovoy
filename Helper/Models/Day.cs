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

    public decimal? Water { get; set; }

    public decimal? Weight { get; set; }

    public virtual ICollection<Dayeat> Dayeats { get; set; } = new List<Dayeat>();

    public virtual User? Uu { get; set; }
}
