using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class EAlertAuditLog
{
    public int Idnumber { get; set; }

    public int DatabaseId { get; set; }

    public string? DatabaseName { get; set; }

    public string? Events2Alert { get; set; }

    public string? EventMenu { get; set; }
}
