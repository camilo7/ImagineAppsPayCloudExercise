﻿using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class ReconcImportHeader
{
    public string? Filenameih { get; set; }

    public decimal? Filesizeih { get; set; }

    public int? Importdate { get; set; }

    public int? Importtime { get; set; }

    public long BatchId { get; set; }

    public string? Filefilter { get; set; }

    public string? Recordcode { get; set; }

    public string? RecordType { get; set; }

    public string? Filler { get; set; }
}
