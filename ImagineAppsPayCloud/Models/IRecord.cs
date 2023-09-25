
namespace ImagineAppsPayCloud.Models
{
    public interface IRecord
    {
        public string RecordType { get; set; }

        public string CheckNumber { get; set; }

        public string BankId { get; set; }

        public string AccountID { get; set; }

        public string CheckDate { get; set; }

        public string CurrencyID { get; set; }

        public string PayeeName1 { get; set; }

        public string PayeeName2 { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string Address4 { get; set; }

        public string Address5 { get; set; }

        public string Checkamount { get; set; }

        public string PayorID { get; set; }

        public string AmountString { get; set; }

        public string InvoiceDate { get; set; }

        public string VoucherNumber { get; set; }

        public string VoucherDate { get; set; }

        public string GrossAmount { get; set; }

        public string DiscountAmount { get; set; }

        public string NetAmount { get; set; }

        public string Concept { get; set; }

        public string BenefitDescription { get; set; }

        public void Parse(string line);
    }
}
