using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class GroupRight
{
    public string GroupId { get; set; } = null!;

    public string RightId { get; set; } = null!;

    public bool? GrAssignedQ { get; set; }
}
