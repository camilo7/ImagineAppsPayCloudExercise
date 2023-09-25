using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class AuthSignCompany
{
    public int FontId { get; set; }

    public string PayorId { get; set; } = null!;

    public bool? AssignedQ { get; set; }

    public short ProjectKey { get; set; }

    public string? Filler1 { get; set; }
}
