using ImagineAppsPayCloud.Constant;
using ImagineAppsPayCloud.Models;
using ImagineAppsPayCloud.Models.Respond;
using ImagineAppsPayCloud.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace ImagineAppsPayCloud.Factory
{
    public class ResponseFactory
    {
        public static IRecordResponse CreateResponseRecord(IRecord record)
        {
            var serviceProvider = new ServiceCollection()
               .AddTransient<IDbQuerys, DbQuerys>()
               .BuildServiceProvider();

            if (record.RecordType.Equals(Values.Header))
            {
                var dbQuerys = serviceProvider.GetService<IDbQuerys>();

                return new HeaderResponse(record, dbQuerys);
            }
            if (record.RecordType.Equals(Values.Details))
            {
                return new DetailsResponse(record);
            }

            return null;
        }
    }
}
