using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class GenParamManCheck
{
    public string? PayorId { get; set; }

    public string? BankId { get; set; }

    public string? AccountId { get; set; }

    public string? PayeeId { get; set; }

    public string? CurrencyId { get; set; }

    public string DescriptTypegpm { get; set; } = null!;

    public string FormIdgpm { get; set; } = null!;

    public int? DateUsedgpm { get; set; }

    public short? ProjectKey { get; set; }

    public string? UserMicrvaluegpm { get; set; }

    public string? CostCentergpm { get; set; }

    public string? Cdv1gpm { get; set; }

    public string? Cdv2gpm { get; set; }

    public string? ScreenCodegpm { get; set; }

    public decimal? CheckAmountLimitgpm { get; set; }

    public string? ClientLocgpm { get; set; }

    public string? ApplicationTitleRi { get; set; }

    public string? Fillergpm { get; set; }
}
