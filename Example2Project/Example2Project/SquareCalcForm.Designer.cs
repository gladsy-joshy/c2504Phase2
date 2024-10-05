namespace Example2Project
{
    partial class SquareCalcForm
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
            lblSquare = new Label();
            txtNumber1 = new TextBox();
            txtSquare = new TextBox();
            btnFindSquare = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Verdana", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1300, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Square Calc";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Location = new Point(137, 145);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(112, 25);
            lblNumber1.TabIndex = 1;
            lblNumber1.Text = "Number 1";
            // 
            // lblSquare
            // 
            lblSquare.AutoSize = true;
            lblSquare.Location = new Point(137, 195);
            lblSquare.Name = "lblSquare";
            lblSquare.Size = new Size(84, 25);
            lblSquare.TabIndex = 1;
            lblSquare.Text = "Square";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(280, 148);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(180, 32);
            txtNumber1.TabIndex = 2;
            // 
            // txtSquare
            // 
            txtSquare.Location = new Point(280, 192);
            txtSquare.Name = "txtSquare";
            txtSquare.ReadOnly = true;
            txtSquare.Size = new Size(180, 32);
            txtSquare.TabIndex = 2;
            // 
            // btnFindSquare
            // 
            btnFindSquare.Location = new Point(280, 273);
            btnFindSquare.Name = "btnFindSquare";
            btnFindSquare.Size = new Size(180, 32);
            btnFindSquare.TabIndex = 3;
            btnFindSquare.Text = "Find Square";
            btnFindSquare.UseVisualStyleBackColor = true;
            btnFindSquare.Click += btnFindSquare_Click;
            // 
            // SquareCalcForm
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 562);
            Controls.Add(btnFindSquare);
            Controls.Add(txtSquare);
            Controls.Add(txtNumber1);
            Controls.Add(lblSquare);
            Controls.Add(lblNumber1);
            Controls.Add(lblTitle);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "SquareCalcForm";
            Text = "SquareCalcForm";
            WindowState = FormWindowState.Maximized;
             ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNumber1;
        private Label lblSquare;
        private TextBox txtNumber1;
        private TextBox txtSquare;
        private Button btnFindSquare;
    }
}