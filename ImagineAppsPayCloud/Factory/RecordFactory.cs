using ImagineAppsPayCloud.Constant;
using ImagineAppsPayCloud.Models;

namespace ImagineAppsPayCloud.Factory
{
    public class RecordFactory
    {
        public static IRecord CreateRecord(string line)
        {
            if (line.StartsWith(Values.Header))
            {
                return new Header();
            }
            else if (line.StartsWith(Values.Details))
            {
                return new Details();
            }

            return null;
        }
    }
}
