using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class IesortDefinit
{
    public string IesGenCode { get; set; } = null!;

    public string IesRecType { get; set; } = null!;

    public string IesFieldCode { get; set; } = null!;

    public string? IesDescript { get; set; }

    public string? IesMask { get; set; }

    public short? IeFieldLength { get; set; }

    public short? IesCharPosition { get; set; }

    public short? IesKey { get; set; }

    public string? IesDataType { get; set; }

    public bool? IesOmitPauseOnChange { get; set; }

    public string? IesFiller { get; set; }

    public string? IesSortType { get; set; }
}
