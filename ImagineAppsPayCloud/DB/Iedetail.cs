using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class Iedetail
{
    public string GeneralCode { get; set; } = null!;

    public string RecordType { get; set; } = null!;

    public string FieldCode { get; set; } = null!;

    public string? IeidDescription { get; set; }

    public bool? IedRealQ { get; set; }

    public string? IeidType { get; set; }

    public short? IeidFieldLengh { get; set; }

    public short? IeidOffset { get; set; }

    public short? IedKey { get; set; }

    public string? ColDet1 { get; set; }

    public string? ColDet2 { get; set; }

    public string? ColDet3 { get; set; }
}
