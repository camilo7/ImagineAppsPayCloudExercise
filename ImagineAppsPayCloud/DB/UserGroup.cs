using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class UserGroup
{
    public string GroupId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public bool? UgAssignedQ { get; set; }

    public virtual User User { get; set; } = null!;
}
