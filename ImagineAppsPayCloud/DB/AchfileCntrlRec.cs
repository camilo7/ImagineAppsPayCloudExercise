using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class AchfileCntrlRec
{
    public string? RecordTypeCode { get; set; }

    public int? BatchCount { get; set; }

    public int? BlockCount { get; set; }

    public int? EntryAddendaCount { get; set; }

    public decimal? EntryHash { get; set; }

    public decimal? TotDebitAmnt { get; set; }

    public decimal? TopCreditAmnt { get; set; }

    public string? Reserved { get; set; }
}
