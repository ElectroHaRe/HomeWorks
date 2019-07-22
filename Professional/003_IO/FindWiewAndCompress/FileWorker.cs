using System.IO;
using System.IO.Compression;
using System.Text;

namespace FindWiewAndCompress
{
    static class FileWorker
    {
        //рекурсивный метод поиска файла в конкретной директории
        private static string FindFileInDirectory(DirectoryInfo d_info, string fileName)
        {
            try
            {
                if (d_info.GetFileSystemInfos(fileName).Length > 0)
                {
                    return d_info.GetFileSystemInfos(fileName)[0].FullName;
                }
            }
            catch { return null; }

            DirectoryInfo[] temp = new DirectoryInfo[0];

            var directories = d_info.GetDirectories();

            if (directories.Length > 0)
            {
                for (int i = 0; i < directories.Length; i++)
                {
                    string path = FindFileInDirectory(directories[i], fileName);
                    if (path != null)
                        return path;
                }
            }
            return null;
        }

        public static string FindFile(string name, string path)
        {
            DirectoryInfo d_info = new DirectoryInfo(path);

            if (!d_info.Exists)
                return null;

            if (Path.GetExtension(name) == string.Empty)
            {
                name += ".*";
            }

            return FindFileInDirectory(d_info, name);

        }

        public static bool CompressToZip(string filePath, string zipFileName)
        {
            var file = new FileInfo(filePath);

            if (!file.Exists)
                return false;

            if (Path.HasExtension(zipFileName))
                Path.ChangeExtension(zipFileName, ".zip");
            else zipFileName += ".zip";
            string path = file.DirectoryName + zipFileName;

            FileStream source = File.Open(filePath, FileMode.Open);
            GZipStream compressor = new GZipStream(File.Create(path), CompressionMode.Compress);
            int theByte = source.ReadByte();
            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }
            compressor.Close();
            source.Close();
            return true;
        }

        public static string DecompressToString(string zipFilePath)
        {
            if (!Path.HasExtension(zipFilePath))
                zipFilePath += ".zip";

            var file = new FileInfo(zipFilePath);

            if (!file.Exists || Path.GetExtension(zipFilePath) != ".zip")
                return null;

            GZipStream decompressor = new GZipStream(File.Open(zipFilePath, FileMode.Open), CompressionMode.Decompress);
            FileInfo destination_file = new FileInfo(@"\DestinationTempFile.txt");
            FileStream destination = destination_file.Create();

            int theByte = decompressor.ReadByte();
            while (theByte != -1)
            {
                destination.WriteByte((byte)theByte);
                theByte = decompressor.ReadByte();
            }

            decompressor.Close();
            destination.Close();


            var source = new StreamReader(destination_file.Open(FileMode.Open),Encoding.Default);
            string result = source.ReadToEnd();

            source.Close();
            destination_file.Delete();

            return result;
        }

        public static string GetText(string filePath)
        {
            var file = new FileInfo(filePath);

            if (!file.Exists)
                return null;

            StreamReader source = new StreamReader(File.Open(filePath, FileMode.Open), Encoding.Default);
            string result = source.ReadToEnd();
            source.Close();
            return result;
        }

        //todo : Разобраться в BinaryReader и BinaryWrighter, а также понять, почему это всё не работает нормально (Как и стри врайтер и риадер) с архивированием
        //public static string CompressToZipAndDecompressToString(string filePath, string zipFileName)
        //{
        //    string result = "";
        //    var file = new FileInfo(filePath);

        //    if (!file.Exists)
        //        return result;

        //    if (Path.HasExtension(zipFileName))
        //        Path.ChangeExtension(zipFileName, ".zip");
        //    else zipFileName += ".zip";
        //    string path = file.DirectoryName + zipFileName;

        //    FileStream source = File.Open(filePath, FileMode.Open);
        //    GZipStream compressor = new GZipStream(File.Create(path), CompressionMode.Compress);
        //    int theByte = source.ReadByte();
        //    while (theByte != -1)
        //    {
        //        compressor.WriteByte((byte)theByte);
        //        theByte = source.ReadByte();
        //    }
        //    compressor.Close();
        //    source.Close();

        //    GZipStream decompressor = new GZipStream(File.Open(path, FileMode.Open), CompressionMode.Decompress);
        //    FileStream destination = File.Open(Path.GetDirectoryName(path) + "test.txt", FileMode.OpenOrCreate);
        //    theByte = decompressor.ReadByte();
        //    while (theByte != -1)
        //    {
        //        destination.WriteByte((byte)theByte);
        //        theByte = decompressor.ReadByte();
        //        result += (char)theByte;
        //    }
        //    decompressor.Close();
        //    destination.Close();

        //    return result;
        //}
    }
}
