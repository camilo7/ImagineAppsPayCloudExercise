using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class ImpCheckLog
{
    public long BatchId { get; set; }

    public int? PrintDate { get; set; }

    public int? PrintTime { get; set; }

    public string AccountId { get; set; } = null!;

    public string? CheckNumber { get; set; }

    public string BankId { get; set; } = null!;
}
