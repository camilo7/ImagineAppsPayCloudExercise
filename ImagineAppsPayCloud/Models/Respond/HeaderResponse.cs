using ImagineAppsPayCloud.Constant;
using System.Text.Json;

namespace ImagineAppsPayCloud.Models.Respond
{
    public class HeaderResponse: IRecordResponse
    {
        private readonly IDbQuerys _dbQuerys;

        public BankFromDB bankFromDB { get; set; }

        public string CheckNumber { get; set; }

        public string BankName { get; set; }

        public string BankAddress1 { get; set; }

        public string BankAddress2 { get; set; }

        public string AccountId { get; set; }

        public string Response { get; set; }

        public HeaderResponse(IRecord record, IDbQuerys dbQuerys)
        {
            CheckNumber = record.CheckNumber;
            _dbQuerys = dbQuerys;
            bankFromDB = _dbQuerys.GetBankById(record.BankId);

            BankName = bankFromDB.Name;

            BankAddress1 = bankFromDB.Address1;

            BankAddress2 = bankFromDB.Address2;

            Response = record.RecordType + Values.SpecialSymbol
                + CheckNumber + Values.SpecialSymbol
                + BankName + Values.SpecialSymbol
                + BankAddress1 + Values.SpecialSymbol
                + record.AccountID + Values.SpecialSymbol
                + record.CheckDate + Values.SpecialSymbol
                + record.CurrencyID + Values.SpecialSymbol
                + record.PayeeName1 + Values.SpecialSymbol
                + record.PayeeName2 + Values.SpecialSymbol
                + record.Address1 + Values.SpecialSymbol
                + record.Address2 + Values.SpecialSymbol
                + record.Address3 + Values.SpecialSymbol
                + record.Address4 + Values.SpecialSymbol
                + record.Address5 + Values.SpecialSymbol
                + record.Checkamount + Values.SpecialSymbol
                + record.PayorID + Values.SpecialSymbol
                + record.AmountString;
        }
    }
}
