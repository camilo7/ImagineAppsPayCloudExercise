﻿using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class GenParBlank
{
    public string? PayorId { get; set; }

    public string? BankId { get; set; }

    public string? AccountId { get; set; }

    public string? PayeeId { get; set; }

    public string? CurrencyId { get; set; }

    public string StyleDescriptiongpb { get; set; } = null!;

    public string FormIdgpb { get; set; } = null!;

    public int? DateDefgpb { get; set; }

    public short? ProjectKey { get; set; }

    public string? UserMicrvaluegpb { get; set; }

    public string? CostCentergpb { get; set; }

    public string? Fillergpb { get; set; }
}
