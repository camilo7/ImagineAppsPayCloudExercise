using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class OutDataMapMaindet
{
    public string LayoutId { get; set; } = null!;

    public short FomrItemId { get; set; }

    public short Seq2Print { get; set; }

    public string? PropertyId { get; set; }

    public float? PropValue { get; set; }

    public short DetSequence { get; set; }
}
