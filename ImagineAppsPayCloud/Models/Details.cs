
namespace ImagineAppsPayCloud.Models
{
    public class Details: IRecord
    {
        public string RecordType { get; set; }
        public string CheckNumber { get; set; }
        public string BankId { get; set; }
        public string BankAccountNo { get; set; }
        public string CheckDate { get; set; }
        public string Invoicenumber { get; set; }
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

        public string AccountID { get; set; }

        public string CurrencyID { get; set; }

        public static string SafeSubstring(string line, int startIndex, int length)
        {
            if (startIndex < 0)
            {
                return string.Empty;
            }
            if (startIndex >= line.Length)
            {
                return string.Empty;
            }
            if (startIndex + length > line.Length)
            {
                length = line.Length - startIndex;
            }

            return line.Substring(startIndex, length).Trim();
        }

        public void Parse(string line)
        {
            RecordType = SafeSubstring(line, 0, 1);
            CheckNumber = SafeSubstring(line, 1, 8);
            BankId = SafeSubstring(line, 9, 10);
            BankAccountNo = SafeSubstring(line, 19, 15);
            CheckDate = Convert.ToDateTime(SafeSubstring(line, 34, 10)).ToString("dd/MM/yyyy");
            Invoicenumber = SafeSubstring(line, 44, 30);
            InvoiceDate = SafeSubstring(line, 74, 10);
            VoucherNumber = SafeSubstring(line, 84, 16);
            VoucherDate = Convert.ToDateTime(SafeSubstring(line, 100, 10)).ToString("dd/MM/yyyy");
            GrossAmount = SafeSubstring(line, 110, 14);
            DiscountAmount = SafeSubstring(line, 124, 14);
            NetAmount = SafeSubstring(line, 138, 14);
            Concept = SafeSubstring(line, 152, 30);
            BenefitDescription = SafeSubstring(line, 182,22);
        }
    }
}
