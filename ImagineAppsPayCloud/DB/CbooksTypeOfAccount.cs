using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class CbooksTypeOfAccount
{
    public int RecordNo { get; set; }

    public string TypeOfaccount { get; set; } = null!;

    public string LayoutId { get; set; } = null!;

    public string CheckLayoutNo { get; set; } = null!;

    public string ApplF { get; set; } = null!;

    public short ProjectKey { get; set; }

    public int SetStartingChkNo { get; set; }

    public short NoChecks2Print { get; set; }

    public string? FillerT { get; set; }

    public string PageNumbering { get; set; } = null!;

    public decimal? PriceStyle1 { get; set; }

    public decimal? PriceStyle2 { get; set; }

    public decimal? PriceStyle3 { get; set; }

    public string? SelectedStyle { get; set; }

    public int? TotalsChecksPerCbook { get; set; }
}
