using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class EAlertEvent
{
    public short? DatabaseId { get; set; }

    public string? AuditPattern { get; set; }

    public short IdentityId { get; set; }

    public string? SourceTable { get; set; }

    public bool? AuditTrailBypassQ { get; set; }

    public bool? PurgeBypassQ { get; set; }

    public string? EfillerW { get; set; }
}
