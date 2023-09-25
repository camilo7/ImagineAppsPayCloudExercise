using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class Ietemplate
{
    public string Tapplication2run { get; set; } = null!;

    public string TrecordType { get; set; } = null!;

    public short Tkey { get; set; }

    public string? Tdescription { get; set; }

    public string? Ttype { get; set; }

    public short? Tlength { get; set; }

    public bool? TessentialQ { get; set; }

    public bool? TselectedQ { get; set; }

    public string? Tclassifier { get; set; }
}
