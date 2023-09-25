using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class PclStub
{
    public string LayoutId { get; set; } = null!;

    public short GroupS { get; set; }

    public short? EntityIdS { get; set; }

    public string? DescriptionS { get; set; }

    public string? NoteS { get; set; }

    public string? FlagsS { get; set; }

    public string? MaskS { get; set; }

    public short Order2PrintS { get; set; }

    public string? LinePropertiesS { get; set; }
}
