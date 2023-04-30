using FileSorter;
using SortFile;
using System.Security.Authentication;
using System.Text;

namespace FileSorterGUI
{
    public partial class MainSorterWidnow : Form
    {
        private string _directoryPath;
        private List<CustomFileType> _fileFilters;
        public MainSorterWidnow()
        {
            _fileFilters = new List<CustomFileType>();
            InitializeComponent();
            FileFiltersList.View = View.Details;
        }

        private void ChoosePathButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    _directoryPath = folderDialog.SelectedPath;
                    FilePathBox.Text = _directoryPath;
                }
            }
        }

        private void AddFilter_Click(object sender, EventArgs e)
        {
            var fileFilter = new AddFilterDialog();
            StringBuilder stringBuilder = new StringBuilder();

            fileFilter.ShowDialog();

            FileFiltersList.Items.Clear();

            _fileFilters.Add(new CustomFileType()
            {
                DirectoryName = fileFilter._directoryName,
                Extenstions = fileFilter._extentionList
            });


            foreach (var customFile in _fileFilters)
            {
                stringBuilder.Clear();

                ListViewItem item = new ListViewItem();

                item.Text = customFile.DirectoryName;


                foreach (var filter in customFile.Extenstions)
                {
                    stringBuilder.Append($"{filter.ToString()},");
                }

                item.SubItems.Add(stringBuilder.ToString());


                FileFiltersList.Items.Add(item);

            }

        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            CustomFileSort customFileSort = new CustomFileSort();

           
            customFileSort.Sort(_directoryPath,_fileFilters);
            
        }
    }
}