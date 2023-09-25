using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class SignatCostCenter
{
    public string TypeOfAccount { get; set; } = null!;

    public int FontId { get; set; }

    public decimal? MaxValue { get; set; }

    public short ProjectKey { get; set; }

    public string? Filler { get; set; }
}
