
using ImagineAppsPayCloud.Utils;

namespace ImagineAppsPayCloud.Models
{
    public class Header: IRecord
    {        
        public string RecordType { get; set; }

        public string CheckNumber { get; set; }
        public string BankId { get; set; }
        public string AccountID { get; set; }
        public string CheckDate { get; set; }
        public string PayeeID { get; set; }
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
        public string TemplateID { get; set; }

        public string CurrencyID { get; set; }

        public string InvoiceDate { get; set; }

        public string VoucherNumber { get; set; }
        public string VoucherDate { get; set; }
        public string GrossAmount { get; set; }

        public string DiscountAmount { get; set; }

        public string NetAmount { get; set; }

        public string Concept { get; set; }

        public string BenefitDescription { get; set; }

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
            AccountID = SafeSubstring(line, 19, 15);
            CheckDate = Convert.ToDateTime(SafeSubstring(line, 34, 10)).ToString("dd/MM/yyyy");
            PayeeID = SafeSubstring(line, 44, 10);
            PayeeName1 = SafeSubstring(line, 54, 35);
            PayeeName2 = SafeSubstring(line, 89, 35);
            Address1 = SafeSubstring(line, 124, 35);
            Address2 = SafeSubstring(line, 159, 35);
            Address3 = SafeSubstring(line, 194, 35);
            Address4 = SafeSubstring(line, 229, 35);
            Address5 = SafeSubstring(line, 264, 35);
            Checkamount = SafeSubstring(line, 532, 14);
            PayorID = SafeSubstring(line, 546, 10);
            AmountString = SafeSubstring(line, 591, 120);
            TemplateID = SafeSubstring(line, 711, 1);

            CurrencyID = CurrenyRules.GetCurrencuyID(AccountID);
        }

    }
}
