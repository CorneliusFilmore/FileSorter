using FileSorter;
using SortFile;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomFileSort customFileSort = new CustomFileSort();
        string path = "c:\\Users\\Reszt\\Desktop";

        List<CustomFileType> files = new List<CustomFileType>();

        CustomFileType fileType = new CustomFileType()
        {
            DirectoryName = "Zdjecia",
            Extenstions = new List<string>() {".jpg",".png"}
        };

        files.Add(fileType);

        customFileSort.Sort(path,files);
    }
}