using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class AuthSignBank
{
    public int FontId { get; set; }

    public string BankId { get; set; } = null!;

    public bool? AssignedQbnk { get; set; }

    public short ProjectKey { get; set; }

    public string? AcoountId { get; set; }

    public string? Filler1 { get; set; }
}
