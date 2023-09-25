using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class CustomFont
{
    public short CfeEntity { get; set; }

    public short ProjectKey { get; set; }

    public string? CfeRecType { get; set; }

    public short? CfeKeyCode { get; set; }

    public int? FontId { get; set; }

    public short? CfeOperand1Entity { get; set; }

    public string? CfeOperator { get; set; }

    public string? CfeData { get; set; }

    public string? CfeFiller { get; set; }
}
