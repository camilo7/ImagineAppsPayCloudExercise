using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class PropertyPcl
{
    public string PropertyId { get; set; } = null!;

    public string? PrefixCommand { get; set; }

    public string? SuffixCommand { get; set; }

    public short? PtyDefaultSequence { get; set; }
}
