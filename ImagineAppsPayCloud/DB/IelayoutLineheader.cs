using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class IelayoutLineheader
{
    public string GeneralCode { get; set; } = null!;

    public string RecordType { get; set; } = null!;

    public string IeidLinecode { get; set; } = null!;

    public string? IeidDescription { get; set; }

    public string? IeidOperation { get; set; }

    public string? Filler { get; set; }

    public string? Col1 { get; set; }

    public string? Col2 { get; set; }
}
