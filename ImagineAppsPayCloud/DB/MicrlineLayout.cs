using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class MicrlineLayout
{
    public string BankId { get; set; } = null!;

    public string? Micrline { get; set; }

    public short? SerialLength { get; set; }

    public short? AccountLength { get; set; }

    public short? TransLength { get; set; }

    public short? AmtLength { get; set; }

    public short? Dummy1 { get; set; }

    public short? Dummy2 { get; set; }

    public short? ProjectKey { get; set; }

    public short? UserLength { get; set; }

    public bool? AccountLeftJustifyQ { get; set; }

    public bool? UserFieldLeftJustify { get; set; }

    public string? Filler1 { get; set; }

    public virtual Bank Bank { get; set; } = null!;
}
