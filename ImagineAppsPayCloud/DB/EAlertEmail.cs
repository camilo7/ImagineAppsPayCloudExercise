﻿using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class EAlertEmail
{
    public short DatabaseId { get; set; }

    public short IdentityId { get; set; }

    public int? CreationTime { get; set; }

    public DateTime? CreationDate { get; set; }

    public string EMail { get; set; } = null!;
}
