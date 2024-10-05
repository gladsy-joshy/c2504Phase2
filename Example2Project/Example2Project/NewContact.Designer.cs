namespace Example2Project
{
    partial class NewContact
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
            lblNewContact = new Label();
            lblName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblNewContact
            // 
            lblNewContact.BackColor = SystemColors.ControlDark;
            lblNewContact.Dock = DockStyle.Top;
            lblNewContact.Font = new Font("Verdana", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewContact.Location = new Point(0, 0);
            lblNewContact.Name = "lblNewContact";
            lblNewContact.Size = new Size(800, 78);
            lblNewContact.TabIndex = 0;
            lblNewContact.Text = "New Contact";
            lblNewContact.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Location = new Point(111, 122);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 31);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(110, 166);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(110, 215);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(250, 124);
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 27);
            txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(250, 163);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(177, 27);
            txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(249, 215);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 27);
            txtEmail.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(250, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(177, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // NewContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(lblNewContact);
            Name = "NewContact";
            Text = "NewContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewContact;
        private Label lblName;
        private Label lblPhone;
        private Label lblEmail;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnSave;
    }
}