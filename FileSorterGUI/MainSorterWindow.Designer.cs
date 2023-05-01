namespace FileSorterGUI
{
    partial class MainSorterWidnow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SortButton = new Button();
            FileFiltersList = new ListView();
            DirectoryName = new ColumnHeader();
            FileFilters = new ColumnHeader();
            label1 = new Label();
            AddFilter = new Button();
            FilePathBox = new TextBox();
            ChoosePathButton = new Button();
            EditFilterButton = new Button();
            DeleteFilterButton = new Button();
            SuspendLayout();
            // 
            // SortButton
            // 
            SortButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SortButton.Location = new Point(890, 552);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(145, 35);
            SortButton.TabIndex = 0;
            SortButton.Text = "Sort";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // FileFiltersList
            // 
            FileFiltersList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FileFiltersList.Columns.AddRange(new ColumnHeader[] { DirectoryName, FileFilters });
            FileFiltersList.Location = new Point(12, 63);
            FileFiltersList.Name = "FileFiltersList";
            FileFiltersList.Size = new Size(837, 524);
            FileFiltersList.TabIndex = 1;
            FileFiltersList.UseCompatibleStateImageBehavior = false;
            // 
            // DirectoryName
            // 
            DirectoryName.Text = "Directory Name";
            DirectoryName.Width = 160;
            // 
            // FileFilters
            // 
            FileFilters.Text = "File Filters";
            FileFilters.Width = 800;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 45);
            label1.TabIndex = 2;
            label1.Text = "File filters";
            // 
            // AddFilter
            // 
            AddFilter.Anchor = AnchorStyles.Right;
            AddFilter.Location = new Point(890, 57);
            AddFilter.Name = "AddFilter";
            AddFilter.Size = new Size(145, 35);
            AddFilter.TabIndex = 3;
            AddFilter.Text = "Add filter";
            AddFilter.UseVisualStyleBackColor = true;
            AddFilter.Click += AddFilter_Click;
            // 
            // FilePathBox
            // 
            FilePathBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FilePathBox.Enabled = false;
            FilePathBox.Location = new Point(175, 23);
            FilePathBox.Name = "FilePathBox";
            FilePathBox.ShortcutsEnabled = false;
            FilePathBox.Size = new Size(674, 23);
            FilePathBox.TabIndex = 4;
            FilePathBox.TabStop = false;
            // 
            // ChoosePathButton
            // 
            ChoosePathButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChoosePathButton.Location = new Point(890, 16);
            ChoosePathButton.Name = "ChoosePathButton";
            ChoosePathButton.Size = new Size(145, 35);
            ChoosePathButton.TabIndex = 5;
            ChoosePathButton.Text = "Choose Path";
            ChoosePathButton.UseVisualStyleBackColor = true;
            ChoosePathButton.Click += ChoosePathButton_Click;
            // 
            // EditFilterButton
            // 
            EditFilterButton.Anchor = AnchorStyles.Right;
            EditFilterButton.Location = new Point(890, 98);
            EditFilterButton.Name = "EditFilterButton";
            EditFilterButton.Size = new Size(145, 35);
            EditFilterButton.TabIndex = 6;
            EditFilterButton.Text = "Edit Filter";
            EditFilterButton.UseVisualStyleBackColor = true;
            EditFilterButton.Click += EditFilterButton_Click;
            // 
            // DeleteFilterButton
            // 
            DeleteFilterButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteFilterButton.Location = new Point(890, 139);
            DeleteFilterButton.Name = "DeleteFilterButton";
            DeleteFilterButton.Size = new Size(145, 35);
            DeleteFilterButton.TabIndex = 7;
            DeleteFilterButton.Text = "Delete Filter";
            DeleteFilterButton.UseVisualStyleBackColor = true;
            DeleteFilterButton.Click += DeleteFilterButton_Click;
            // 
            // MainSorterWidnow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 599);
            Controls.Add(DeleteFilterButton);
            Controls.Add(EditFilterButton);
            Controls.Add(ChoosePathButton);
            Controls.Add(FilePathBox);
            Controls.Add(AddFilter);
            Controls.Add(label1);
            Controls.Add(FileFiltersList);
            Controls.Add(SortButton);
            Name = "MainSorterWidnow";
            Text = "FileSorter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SortButton;
        private ListView FileFiltersList;
        private Label label1;
        private Button AddFilter;
        private TextBox FilePathBox;
        private Button ChoosePathButton;
        private Button EditFilterButton;
        private Button DeleteFilterButton;
        private ColumnHeader DirectoryName;
        private ColumnHeader FileFilters;
    }
}