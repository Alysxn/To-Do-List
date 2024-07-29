namespace ToDoList
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            lblTitle2 = new Label();
            lblTitle1 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lblGrid = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnUpdate = new Button();
            txtTitle = new TextBox();
            checkDone = new CheckBox();
            txtDate = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSearch = new Button();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle2
            // 
            resources.ApplyResources(lblTitle2, "lblTitle2");
            lblTitle2.BackColor = Color.Transparent;
            lblTitle2.Name = "lblTitle2";
            // 
            // lblTitle1
            // 
            resources.ApplyResources(lblTitle1, "lblTitle1");
            lblTitle1.BackColor = Color.Transparent;
            lblTitle1.Name = "lblTitle1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.RoyalBlue;
            label1.Name = "label1";
            label1.Click += label1_Click;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseHover += label1_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTitle1);
            panel1.Controls.Add(lblTitle2);
            panel1.ForeColor = Color.Transparent;
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.OrangeRed;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Date, Description, Status });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = SystemColors.Control;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.UserDeletedRow += dataGridView1_UserDeletedRow;
            // 
            // Title
            // 
            resources.ApplyResources(Title, "Title");
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(Date, "Date");
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(Description, "Description");
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(Status, "Status");
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // lblGrid
            // 
            resources.ApplyResources(lblGrid, "lblGrid");
            lblGrid.BackColor = Color.Transparent;
            lblGrid.Name = "lblGrid";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Transparent;
            resources.ApplyResources(btnRemove, "btnRemove");
            btnRemove.Name = "btnRemove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            resources.ApplyResources(btnUpdate, "btnUpdate");
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtTitle
            // 
            resources.ApplyResources(txtTitle, "txtTitle");
            txtTitle.Name = "txtTitle";
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // checkDone
            // 
            resources.ApplyResources(checkDone, "checkDone");
            checkDone.BackColor = Color.Transparent;
            checkDone.Name = "checkDone";
            checkDone.UseVisualStyleBackColor = false;
            checkDone.CheckedChanged += checkDone_CheckedChanged;
            // 
            // txtDate
            // 
            resources.ApplyResources(txtDate, "txtDate");
            txtDate.Name = "txtDate";
            txtDate.TextChanged += txtDate_TextChanged;
            // 
            // txtDescription
            // 
            resources.ApplyResources(txtDescription, "txtDescription");
            txtDescription.Name = "txtDescription";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.Name = "label4";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            resources.ApplyResources(btnSearch, "btnSearch");
            btnSearch.Name = "btnSearch";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Transparent;
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.Transparent;
            label6.Name = "label6";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(checkDone);
            Controls.Add(txtDescription);
            Controls.Add(txtDate);
            Controls.Add(txtTitle);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblGrid);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            TransparencyKey = SystemColors.Control;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle2;
        private Label lblTitle1;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label lblGrid;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnUpdate;
        private TextBox txtTitle;
        private CheckBox checkDone;
        private TextBox txtDate;
        private TextBox txtDescription;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSearch;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Status;
    }
}
