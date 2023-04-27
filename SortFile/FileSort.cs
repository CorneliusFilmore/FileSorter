using FileSorter;

namespace SortFile
{
    public class CustomFileSort
    {
        public void Sort(string path,List<CustomFileType> fileTypes)
        {
            foreach (CustomFileType fileType in fileTypes)
            {
                string directoryPath = $"{path}{Path.DirectorySeparatorChar}{fileType.DirectoryName}";
                
                if (!Directory.Exists(directoryPath)) 
                {
                   Directory.CreateDirectory(directoryPath);
                }

                List<string> files = Directory.GetFiles(path).ToList();

                foreach (string file in files)
                {
                    string fileWithoutExt = Path.GetExtension(file);

                    foreach(string ext in fileType.Extenstions)
                    {
                        if(fileWithoutExt ==  ext)
                        {
                            File.Move(file, $"{directoryPath}{Path.DirectorySeparatorChar}{Path.GetFileName(file)}");
                        }
                    }

                }
            }
        }
    }
}