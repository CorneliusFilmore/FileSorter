using FileSorter;

namespace SortFile
{
    public class CustomFileSort
    {
        public void Sort(string path,List<CustomFileType> fileTypes)
        {
            List<string> files = Directory.GetFiles(path).ToList();

            try
            {
                Parallel.ForEach(files, file =>
                {
                    string fileWithoutExt = Path.GetExtension(file);

                    foreach (CustomFileType fileType in fileTypes)
                    {
                        var b = fileType.Extenstions.Contains(fileWithoutExt);
                        var a = fileWithoutExt;
                        if (fileType.Extenstions.Contains(fileWithoutExt))
                        {
                            string directoryPath = $"{path}{Path.DirectorySeparatorChar}{fileType.DirectoryName}";

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Move(file, $"{directoryPath}{Path.DirectorySeparatorChar}{Path.GetFileName(file)}");
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}