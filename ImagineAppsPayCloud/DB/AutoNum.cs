using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class AutoNum
{
    public short AutonumId { get; set; }

    public long? NextNumber { get; set; }

    public string? AutoDescription { get; set; }
}
