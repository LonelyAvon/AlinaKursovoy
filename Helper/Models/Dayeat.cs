using System;
using System.Collections.Generic;

namespace Helper;

public partial class Dayeat
{
    public int Id { get; set; }

    public int? IdDay { get; set; }

    public int? IdEat { get; set; }

    public virtual Day? IdDayNavigation { get; set; }

    public virtual Eat? IdEatNavigation { get; set; }
}
