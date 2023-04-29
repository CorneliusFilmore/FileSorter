namespace FileSorterGUI
{
    partial class AddFilterDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListOfFilters = new ListView();
            Filters = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            DirectoryNameBox = new TextBox();
            FilterNameBox = new TextBox();
            AddFilterToListButton = new Button();
            AddMainFilterButton = new Button();
            SuspendLayout();
            // 
            // ListOfFilters
            // 
            ListOfFilters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListOfFilters.AutoArrange = false;
            ListOfFilters.Columns.AddRange(new ColumnHeader[] { Filters });
            ListOfFilters.Location = new Point(12, 138);
            ListOfFilters.Name = "ListOfFilters";
            ListOfFilters.Size = new Size(379, 178);
            ListOfFilters.TabIndex = 0;
            ListOfFilters.UseCompatibleStateImageBehavior = false;
            // 
            // Filters
            // 
            Filters.Text = "Filters";
            Filters.Width = 1980;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 90);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 1;
            label1.Text = "List of Filters";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopRight;
            label2.Location = new Point(129, 9);
            label2.Name = "label2";
            label2.Size = new Size(159, 30);
            label2.TabIndex = 2;
            label2.Text = "Directory Name";
            // 
            // DirectoryNameBox
            // 
            DirectoryNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DirectoryNameBox.Location = new Point(12, 53);
            DirectoryNameBox.Name = "DirectoryNameBox";
            DirectoryNameBox.Size = new Size(379, 23);
            DirectoryNameBox.TabIndex = 3;
            // 
            // FilterNameBox
            // 
            FilterNameBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FilterNameBox.Location = new Point(12, 338);
            FilterNameBox.Name = "FilterNameBox";
            FilterNameBox.Size = new Size(210, 23);
            FilterNameBox.TabIndex = 4;
            FilterNameBox.KeyPress += FilterNameBox_KeyPress;
            // 
            // AddFilterToListButton
            // 
            AddFilterToListButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddFilterToListButton.Location = new Point(246, 338);
            AddFilterToListButton.Name = "AddFilterToListButton";
            AddFilterToListButton.Size = new Size(145, 23);
            AddFilterToListButton.TabIndex = 5;
            AddFilterToListButton.Text = "Add Filter";
            AddFilterToListButton.UseVisualStyleBackColor = true;
            AddFilterToListButton.Click += AddFilterToListButton_Click;
            // 
            // AddMainFilterButton
            // 
            AddMainFilterButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddMainFilterButton.Location = new Point(12, 392);
            AddMainFilterButton.Name = "AddMainFilterButton";
            AddMainFilterButton.Size = new Size(379, 46);
            AddMainFilterButton.TabIndex = 6;
            AddMainFilterButton.Text = "AddFilter";
            AddMainFilterButton.UseVisualStyleBackColor = true;
            AddMainFilterButton.Click += AddMainFilterButton_Click;
            // 
            // AddFilterDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 450);
            Controls.Add(AddMainFilterButton);
            Controls.Add(AddFilterToListButton);
            Controls.Add(FilterNameBox);
            Controls.Add(DirectoryNameBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ListOfFilters);
            Name = "AddFilterDialog";
            Text = "AddFilterDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListOfFilters;
        private Label label1;
        private Label label2;
        private TextBox DirectoryNameBox;
        private TextBox FilterNameBox;
        private Button AddFilterToListButton;
        private Button AddMainFilterButton;
        private ColumnHeader Filters;
    }
}