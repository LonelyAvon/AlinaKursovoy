using System;
using System.Collections.Generic;

namespace Helper;

public partial class User
{
    public string Uuid { get; set; } = null!;

    public int? Gender { get; set; }

    public int? Height { get; set; }

    public int? Weight { get; set; }

    public DateOnly? Birthday { get; set; }

    public int? Activity { get; set; }

    public int? Purpose { get; set; }

    public virtual Activity? ActivityNavigation { get; set; }

    public virtual ICollection<Day> Days { get; set; } = new List<Day>();

    public virtual Gender? GenderNavigation { get; set; }

    public virtual Purpose? PurposeNavigation { get; set; }
}
