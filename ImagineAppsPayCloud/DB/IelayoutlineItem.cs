using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class IelayoutlineItem
{
    public string GeneralCode { get; set; } = null!;

    public string RecordType { get; set; } = null!;

    public string FieldCode { get; set; } = null!;

    public string? IeidDescription { get; set; }

    public string? IeidType { get; set; }

    public short? IeidLength { get; set; }

    public short? IeidOffsetpos { get; set; }

    public short Kkey { get; set; }

    public string KparentCode { get; set; } = null!;

    public string? Constant { get; set; }

    public string? Col1 { get; set; }

    public string? Col2 { get; set; }
}
