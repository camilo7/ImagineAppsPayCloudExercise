﻿using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class TemplxPrinterSecurityFeat
{
    public string PrinterSecurityFeatu { get; set; } = null!;

    public string? Description { get; set; }

    public string? Pclprefix { get; set; }

    public string? Pclsuffix { get; set; }

    public string Micrprefix { get; set; } = null!;

    public string? Micrsufix { get; set; }

    public string? AmtPrefix { get; set; }

    public string? AmtSufix { get; set; }

    public string? Pclinitialization { get; set; }
}
