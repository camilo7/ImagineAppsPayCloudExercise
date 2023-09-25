using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class SignComboH
{
    public int SeqNo { get; set; }

    public string? Description { get; set; }

    public decimal? FromAmount { get; set; }

    public decimal? ToAmount { get; set; }

    public string? Reference { get; set; }

    public decimal? SuggestedFromValue { get; set; }

    public decimal? SuggestedToValue { get; set; }

    public string PayorId { get; set; } = null!;

    public string? FillerCh { get; set; }
}
