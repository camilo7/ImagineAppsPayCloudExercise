using ImagineAppsPayCloud.DB;
using ImagineAppsPayCloud.Models;

namespace ImagineAppsPayCloud.Models.Respond
{
    public class DbQuerys: IDbQuerys
    {
        public BankFromDB GetBankById(string bankId)
        {
            var context = new CheckPlus235Context();

            var bank = from c in context.Banks
                       where c.BankId == bankId
                       select new
                       {
                           c.BankName,
                           c.Address1,
                           c.Address2
                       };

            var bankData = bank.FirstOrDefault();

            if (bankData != null)
            {
                var bankFromDB = new BankFromDB
                {
                    Name = bankData.BankName,
                    Address1 = bankData.Address1,
                    Address2 = bankData.Address2
                };

                return bankFromDB;
            }

            return null;
        }
    }
}
