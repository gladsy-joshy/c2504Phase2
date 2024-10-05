namespace Example2Project
{
    partial class SumCalcForm
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
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            lblSum = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            txtSum = new TextBox();
            btnFindSum = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Verdana", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1300, 76);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sum Calc";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Location = new Point(103, 146);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(112, 25);
            lblNumber1.TabIndex = 1;
            lblNumber1.Text = "Number 1";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Location = new Point(103, 215);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(112, 25);
            lblNumber2.TabIndex = 1;
            lblNumber2.Text = "Number 2";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(103, 284);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(58, 25);
            lblSum.TabIndex = 1;
            lblSum.Text = "Sum";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(253, 142);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(228, 32);
            txtNumber1.TabIndex = 2;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(253, 211);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(228, 32);
            txtNumber2.TabIndex = 2;
            // 
            // txtSum
            // 
            txtSum.Location = new Point(253, 280);
            txtSum.Name = "txtSum";
            txtSum.ReadOnly = true;
            txtSum.Size = new Size(228, 32);
            txtSum.TabIndex = 2;
            // 
            // btnFindSum
            // 
            btnFindSum.Location = new Point(253, 349);
            btnFindSum.Name = "btnFindSum";
            btnFindSum.Size = new Size(228, 32);
            btnFindSum.TabIndex = 3;
            btnFindSum.Text = "Find Sum";
            btnFindSum.UseVisualStyleBackColor = true;
            btnFindSum.Click += btnFindSum_Click_1;
            // 
            // SumCalcForm
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 562);
            Controls.Add(btnFindSum);
            Controls.Add(txtSum);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(lblSum);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Controls.Add(lblTitle);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "SumCalcForm";
            Text = "Sum Calc";
            WindowState = FormWindowState.Maximized;
            FormClosing += SumCalcForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNumber1;
        private Label lblNumber2;
        private Label lblSum;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private TextBox txtSum;
        private Button btnFindSum;
    }
}