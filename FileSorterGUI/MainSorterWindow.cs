using FileSorter;
using SortFile;
using System.Security.Cryptography.X509Certificates;
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


            customFileSort.Sort(_directoryPath, _fileFilters);

        }

        private void EditFilterButton_Click(object sender, EventArgs e)
        {
            if (FileFiltersList.SelectedItems.Count != 1)
            {
                MessageBox.Show("You can edit only one position", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AddFilterDialog addFilterDialog = new AddFilterDialog();
                ListViewItem listViewItem = FileFiltersList.SelectedItems[0];

                addFilterDialog._directoryName = listViewItem.Text;
                addFilterDialog._extentionList = listViewItem.SubItems[1].Text.Split(",").ToList();

                addFilterDialog.UpdateData();
                addFilterDialog.ShowDialog();

                listViewItem.Text = addFilterDialog._directoryName;

                string extensions = string.Join(",", addFilterDialog._extentionList);

                listViewItem.SubItems[1].Text = extensions;

                addFilterDialog._extentionList = extensions.Split(",").ToList();

                var updateObject = _fileFilters.FirstOrDefault(x => x.DirectoryName == listViewItem.Text);

                updateObject.Extenstions = addFilterDialog._extentionList;
                

                FileFiltersList.Refresh();
            }
        }

        private void DeleteFilterButton_Click(object sender, EventArgs e)
        {
            var selectedItems = FileFiltersList.SelectedItems;

            foreach (ListViewItem item in selectedItems)
            {
                FileFiltersList.Items.Remove(item);
                _fileFilters.RemoveAll(x => x.DirectoryName == item.Text);
            }
        }
    }
}