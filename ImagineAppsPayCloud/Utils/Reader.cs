using ImagineAppsPayCloud.Constant;
using ImagineAppsPayCloud.Factory;
using ImagineAppsPayCloud.Models;
using ImagineAppsPayCloud.Models.Respond;

namespace ImagineAppsPayCloud.Utils
{
    public class Reader: IReader
    {
        public string FilePath { get; set; }

        public string FileContent { get; set; }

        public string Response { get; set; }

        public string GetFile()
        {
            var projectRoot = AppDomain.CurrentDomain.BaseDirectory;

            var fullFolderPath = Path.Combine(projectRoot, Values.FolderName);

            FilePath = fullFolderPath + "\\" + Values.OriginalFileName;

            string[] lines = File.ReadAllLines(FilePath);

            foreach (string line in lines)
            {
                IRecord record = RecordFactory.CreateRecord(line);

                if (record != null)
                {
                    record.Parse(line);

                    Response = CreateResponse(record);
                }
            }

            return Response;
        }

        public string CreateResponse(IRecord record)
        {
            IRecordResponse _record = ResponseFactory.CreateResponseRecord(record);

            if (_record.Response != null)
            {
                Response = Response + _record.Response.ToString() + "\n";
            }

            return Response;
        }
    }
}
