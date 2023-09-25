using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class ElegiblePrinter
{
    public string UserId { get; set; } = null!;

    public short? TrayNumber { get; set; }

    public string MarginName { get; set; } = null!;

    public bool? SecurePrinterQ { get; set; }

    public short? AvailablePrinters { get; set; }

    public bool? LoadBalanceQ { get; set; }

    public bool? OmitInitQ { get; set; }

    public short PrinterId { get; set; }

    public string AssignedPrinter { get; set; } = null!;

    public string? Orientation { get; set; }

    public string? PaperSize { get; set; }

    public bool? SelectedQ { get; set; }

    public string InitString { get; set; } = null!;

    public short? ProjectKey { get; set; }
}
