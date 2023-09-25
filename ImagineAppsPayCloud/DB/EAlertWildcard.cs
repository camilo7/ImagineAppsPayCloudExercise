using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class EAlertWildcard
{
    public short? DatabaseId { get; set; }

    public string? MatchPattern { get; set; }

    public short IdentityId { get; set; }

    public string? Description { get; set; }

    public bool? AuditTrailBypassQ { get; set; }

    public bool? PurgeBypassQ { get; set; }

    public string? EfillerW { get; set; }
}
