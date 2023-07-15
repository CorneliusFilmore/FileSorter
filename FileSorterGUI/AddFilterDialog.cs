using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileSorterGUI
{
    public partial class AddFilterDialog : Form
    {
        public string _directoryName;
        public List<string> _extentionList = new();
        public AddFilterDialog()
        {
            InitializeComponent();
            ListOfFilters.View = View.Details;
            ListOfFilters.Scrollable = true;
            //comment xdxdxxd
        }

        private void AddFilterToListButton_Click(object sender, EventArgs e)
        {
            CheckFilter();
        }

        private void FilterNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CheckFilter();
            }
        }
        private void AddMainFilterButton_Click(object sender, EventArgs e)
        {
            if (DirectoryNameBox.Text != string.Empty)
            {
                if (DirectoryNameBox.Text.Any(Char.IsWhiteSpace))
                {
                    MessageBox.Show("The name of directory can't contain spaces!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ListOfFilters.Items.Count == 0)
                {
                    MessageBox.Show("You have to have at least one filter!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _directoryName = DirectoryNameBox.Text;

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("The name of directory can't be empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckFilter()
        {
            Regex regex = new("^[.][a-zA-Z0-9]+$");

            if (regex.IsMatch(FilterNameBox.Text))
            {
                if (!_extentionList.Contains(FilterNameBox.Text))
                {
                    ListOfFilters.Items.Add(FilterNameBox.Text);
                    _extentionList.Add(FilterNameBox.Text);
                    ListOfFilters.Refresh();
                    FilterNameBox.Text = string.Empty;
                }
                else
                {
                    string message = $"The extension \"{FilterNameBox.Text}\" is aleready added!";

                    MessageBox.Show(message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FilterNameBox.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Incorrect extension!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FilterNameBox.Text = string.Empty;
            }
        }

        public void UpdateData()
        {
            DirectoryNameBox.Text = _directoryName;

            foreach (string filter in _extentionList)
            {
                ListOfFilters.Items.Add(filter);
            }
        }

        private void DeleteFilterButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete selected filters?", "WARNING!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in ListOfFilters.SelectedItems)
                {
                    ListOfFilters.Items.Remove(item);
                    _extentionList.Remove(item.Text);
                }
            }

        }
    }
}
