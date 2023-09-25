using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class UserRight
{
    public string UserId { get; set; } = null!;

    public string RightId { get; set; } = null!;

    public bool? UrAssigned { get; set; }

    public string? GroupId { get; set; }

    public virtual User User { get; set; } = null!;
}
