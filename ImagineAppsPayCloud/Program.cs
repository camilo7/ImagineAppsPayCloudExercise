using ImagineAppsPayCloud.Models;
using ImagineAppsPayCloud.Models.Respond;
using ImagineAppsPayCloud.Utils;
using Microsoft.Extensions.DependencyInjection;


namespace ImagineAppsPayCloud
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddTransient<IReader, Reader>()
            .AddTransient<IDbQuerys, DbQuerys>()
            .BuildServiceProvider();

            var reader = serviceProvider.GetService<IReader>();

            var fileContent = reader.GetFile();

            FileWritter.SaveFile(fileContent);
        }
    }
}