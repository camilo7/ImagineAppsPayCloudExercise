using ImagineAppsPayCloud.Constant;
using ImagineAppsPayCloud.DB;

namespace ImagineAppsPayCloud.Utils
{
    public static class CurrenyRules
    {
        public static string GetCurrencuyID(string account)
        {
            if (account.Equals(Values.Account1) || account.Equals(Values.Account2))
            {
                return Values.CurrencyID;
            }
            else if (account.Equals(Values.Account3) || account.Equals(Values.Account4))
            {
                return Values.CurrencyID2;
            }

            return string.Empty;
        }
    }
}
