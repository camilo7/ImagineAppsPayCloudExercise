using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class GenSysUser
{
    public string NumberOfUsers { get; set; } = null!;

    public DateTime? LicenseDateTime { get; set; }
}
