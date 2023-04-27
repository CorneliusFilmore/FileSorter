using FileSorter;

namespace FileSorterGUI
{
    public partial class Form1 : Form
    {
        private string _directoryPath;
        private List<CustomFileType> _fileFilters;
        public Form1()
        {
            _fileFilters = new List<CustomFileType>();
            InitializeComponent();
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

        }
    }
}