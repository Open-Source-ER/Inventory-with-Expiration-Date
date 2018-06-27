using System.IO;

using prototype.Services.FileProvider;

namespace prototype.Droid.Services.FileProvider
{
    class FileProvider : IFileProvider
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}