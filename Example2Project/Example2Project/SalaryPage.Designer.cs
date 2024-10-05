namespace Example2Project
{
    partial class SalaryPage
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
            lblTitle = new Label();
            btnLoad = new Button();
            lblTitleNewSalary = new Label();
            lblTitleEditSalary = new Label();
            lblJobTitle = new Label();
            lblSalary = new Label();
            txtJobTitle = new TextBox();
            txtSalary = new TextBox();
            btnClear = new Button();
            lblEditJobTitle = new Label();
            lblEditSalary = new Label();
            txtEditJobTitle = new TextBox();
            txtEditSalary = new TextBox();
            btnAdd = new Button();
            btnEditSave = new Button();
            grdSalaries = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnDelete = new Button();
            cmbSalaries = new ComboBox();
            lstSalaries = new ListBox();
            ((System.ComponentModel.ISupportInitialize)grdSalaries).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Verdana", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1300, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Salary";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ButtonFace;
            btnLoad.Location = new Point(36, 73);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click_1;
            // 
            // lblTitleNewSalary
            // 
            lblTitleNewSalary.BackColor = SystemColors.ControlDark;
            lblTitleNewSalary.Location = new Point(36, 138);
            lblTitleNewSalary.Name = "lblTitleNewSalary";
            lblTitleNewSalary.Size = new Size(306, 25);
            lblTitleNewSalary.TabIndex = 2;
            lblTitleNewSalary.Text = "New Salary";
            // 
            // lblTitleEditSalary
            // 
            lblTitleEditSalary.BackColor = SystemColors.ControlDark;
            lblTitleEditSalary.Location = new Point(496, 138);
            lblTitleEditSalary.Name = "lblTitleEditSalary";
            lblTitleEditSalary.Size = new Size(273, 25);
            lblTitleEditSalary.TabIndex = 2;
            lblTitleEditSalary.Text = "Edit Salary";
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Location = new Point(34, 246);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(96, 25);
            lblJobTitle.TabIndex = 3;
            lblJobTitle.Text = "Job Title";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(34, 299);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(77, 25);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "Salary";
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(217, 246);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(125, 32);
            txtJobTitle.TabIndex = 4;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(217, 299);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(125, 32);
            txtSalary.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ButtonFace;
            btnClear.Location = new Point(130, 198);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblEditJobTitle
            // 
            lblEditJobTitle.AutoSize = true;
            lblEditJobTitle.Location = new Point(494, 236);
            lblEditJobTitle.Name = "lblEditJobTitle";
            lblEditJobTitle.Size = new Size(96, 25);
            lblEditJobTitle.TabIndex = 5;
            lblEditJobTitle.Text = "Job Title";
            // 
            // lblEditSalary
            // 
            lblEditSalary.AutoSize = true;
            lblEditSalary.Location = new Point(494, 299);
            lblEditSalary.Name = "lblEditSalary";
            lblEditSalary.Size = new Size(77, 25);
            lblEditSalary.TabIndex = 5;
            lblEditSalary.Text = "Salary";
            // 
            // txtEditJobTitle
            // 
            txtEditJobTitle.Location = new Point(644, 236);
            txtEditJobTitle.Name = "txtEditJobTitle";
            txtEditJobTitle.Size = new Size(125, 32);
            txtEditJobTitle.TabIndex = 6;
            // 
            // txtEditSalary
            // 
            txtEditSalary.Location = new Point(644, 292);
            txtEditSalary.Name = "txtEditSalary";
            txtEditSalary.Size = new Size(125, 32);
            txtEditSalary.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 40);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEditSave
            // 
            btnEditSave.Location = new Point(496, 376);
            btnEditSave.Name = "btnEditSave";
            btnEditSave.Size = new Size(94, 40);
            btnEditSave.TabIndex = 7;
            btnEditSave.Text = "Save";
            btnEditSave.UseVisualStyleBackColor = true;
            btnEditSave.Click += btnEditSave_Click;
            // 
            // grdSalaries
            // 
            grdSalaries.AllowUserToAddRows = false;
            grdSalaries.AllowUserToDeleteRows = false;
            grdSalaries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSalaries.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            grdSalaries.Location = new Point(34, 440);
            grdSalaries.Name = "grdSalaries";
            grdSalaries.ReadOnly = true;
            grdSalaries.RowHeadersWidth = 51;
            grdSalaries.Size = new Size(421, 244);
            grdSalaries.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Title";
            Column1.HeaderText = "Title";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Salary";
            Column2.HeaderText = "Salary";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Display";
            Column3.HeaderText = "Display";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            Column3.Width = 125;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(68, 706);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(134, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(273, 706);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbSalaries
            // 
            cmbSalaries.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSalaries.FormattingEnabled = true;
            cmbSalaries.Location = new Point(938, 136);
            cmbSalaries.Name = "cmbSalaries";
            cmbSalaries.Size = new Size(151, 33);
            cmbSalaries.TabIndex = 10;
            // 
            // lstSalaries
            // 
            lstSalaries.FormattingEnabled = true;
            lstSalaries.ItemHeight = 25;
            lstSalaries.Location = new Point(948, 248);
            lstSalaries.Name = "lstSalaries";
            lstSalaries.Size = new Size(150, 104);
            lstSalaries.TabIndex = 11;
            // 
            // SalaryPage
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 762);
            Controls.Add(lstSalaries);
            Controls.Add(cmbSalaries);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(grdSalaries);
            Controls.Add(btnEditSave);
            Controls.Add(btnAdd);
            Controls.Add(txtEditSalary);
            Controls.Add(txtEditJobTitle);
            Controls.Add(lblEditSalary);
            Controls.Add(lblEditJobTitle);
            Controls.Add(txtSalary);
            Controls.Add(txtJobTitle);
            Controls.Add(lblSalary);
            Controls.Add(lblJobTitle);
            Controls.Add(lblTitleEditSalary);
            Controls.Add(lblTitleNewSalary);
            Controls.Add(btnClear);
            Controls.Add(btnLoad);
            Controls.Add(lblTitle);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "SalaryPage";
            Text = "SalaryPage";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)grdSalaries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnLoad;
        private Label lblTitleNewSalary;
        private Label lblTitleEditSalary;
        private Label lblJobTitle;
        private Label lblSalary;
        private TextBox txtJobTitle;
        private TextBox txtSalary;
        private Button btnClear;
        private Label lblEditJobTitle;
        private Label lblEditSalary;
        private TextBox txtEditJobTitle;
        private TextBox txtEditSalary;
        private Button btnAdd;
        private Button btnEditSave;
        private DataGridView grdSalaries;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnEdit;
        private Button btnDelete;
        private ComboBox cmbSalaries;
        private ListBox lstSalaries;
    }
}