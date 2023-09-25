using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class Format
{
    public string LayoutId { get; set; } = null!;

    public string? Description { get; set; }

    public bool? OverflowQ { get; set; }

    public short? LinesStub { get; set; }

    public string? Appearance { get; set; }

    public short? ProjectKey { get; set; }

    public bool? SelectedQ { get; set; }

    public string? Filler { get; set; }
}
