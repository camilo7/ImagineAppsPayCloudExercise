
using ImagineAppsPayCloud.Constant;

namespace ImagineAppsPayCloud.Utils
{
    public static class FileWritter
    {
        public static void SaveFile(string fileContent)
        {
            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;

            string fullFolderPath = Path.Combine(projectRoot, Values.FolderName);

            string fullPath = fullFolderPath + "\\" + Values.NewFileName;

            File.WriteAllText(fullPath, fileContent);
        }
    }
}
