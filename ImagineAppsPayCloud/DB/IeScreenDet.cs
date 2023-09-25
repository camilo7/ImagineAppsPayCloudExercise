using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class IeScreenDet
{
    public string GenCode { get; set; } = null!;

    public string RecType { get; set; } = null!;

    public string IeidFieldCode { get; set; } = null!;

    public string? IeidDescription { get; set; }

    public string? Ieidtype { get; set; }

    public short? IeidLengthInFile { get; set; }

    public short? IeidPosition { get; set; }

    public short? IesdKey { get; set; }

    public string? IesdMask { get; set; }

    public string? IesdFiller { get; set; }
}
