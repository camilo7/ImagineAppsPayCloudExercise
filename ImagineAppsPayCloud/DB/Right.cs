using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class Right
{
    public string RightId { get; set; } = null!;

    public string? RDescription { get; set; }

    public bool? RDisableAlertsL { get; set; }

    public short? RReqAuth { get; set; }

    public string? DescrptMainMenu { get; set; }

    public string? DescrptSubMenu { get; set; }

    public string? Descrption1 { get; set; }

    public string? Descrption2 { get; set; }
}
