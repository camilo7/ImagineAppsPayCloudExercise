using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class IelayoutLineItemX
{
    public string GeneralCode { get; set; } = null!;

    public string? RecordType { get; set; }

    public string FieldCode { get; set; } = null!;

    public string? IeXdescription { get; set; }

    public string? IeXtype { get; set; }

    public short? IeXlength { get; set; }

    public short? IeXoffset { get; set; }

    public short IeXkey { get; set; }

    public string IeXparentCode { get; set; } = null!;

    public string? IeXoperatorX { get; set; }

    public string? XdataOperand { get; set; }

    public string? XFiller { get; set; }

    public string? Col1 { get; set; }

    public string? Col2 { get; set; }

    public string? Col3 { get; set; }
}
