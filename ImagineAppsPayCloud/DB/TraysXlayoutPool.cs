using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class TraysXlayoutPool
{
    public string LayoutId { get; set; } = null!;

    public short? TrayNumberP { get; set; }

    public string? MarginNameP { get; set; }

    public bool? OmitInitializationQp { get; set; }

    public short? OrderNumberP { get; set; }

    public string? AssignedPrinterP { get; set; }

    public string? OrientationP { get; set; }

    public string? PaperSizeP { get; set; }

    public bool? SelectedQp { get; set; }

    public string? InitStringP { get; set; }

    public short? ProjectKey { get; set; }
}
