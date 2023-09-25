using ImagineAppsPayCloud.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagineAppsPayCloud.Models.Respond
{
    public class DetailsResponse: IRecordResponse
    {
        public string Response {  get; set; }
        public DetailsResponse(IRecord record)
        {
            Response = record.RecordType + Values.SpecialSymbol
                + record.InvoiceDate + Values.SpecialSymbol
                + record.VoucherNumber + Values.SpecialSymbol
                + record.VoucherDate + Values.SpecialSymbol
                + record.GrossAmount + Values.SpecialSymbol
                + record.DiscountAmount + Values.SpecialSymbol
                + record.NetAmount + Values.SpecialSymbol
                + record.Concept + Values.SpecialSymbol
                + record.BenefitDescription;
        }
    }
}
