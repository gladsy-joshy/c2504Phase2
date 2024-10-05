namespace Example2Project
{
    partial class ContactList
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
            lblContacts = new Label();
            lstContactList = new ListBox();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblContacts
            // 
            lblContacts.BackColor = SystemColors.ControlDark;
            lblContacts.Dock = DockStyle.Top;
            lblContacts.Font = new Font("Verdana", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacts.Location = new Point(0, 0);
            lblContacts.Name = "lblContacts";
            lblContacts.Size = new Size(800, 66);
            lblContacts.TabIndex = 0;
            lblContacts.Text = "Contacts";
            lblContacts.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstContactList
            // 
            lstContactList.FormattingEnabled = true;
            lstContactList.Location = new Point(272, 123);
            lstContactList.Name = "lstContactList";
            lstContactList.Size = new Size(279, 164);
            lstContactList.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(279, 343);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 35);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(453, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // ContactList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lstContactList);
            Controls.Add(lblContacts);
            Name = "ContactList";
            Text = "ContactList";
            ResumeLayout(false);
        }

        #endregion

        private Label lblContacts;
        private ListBox lstContactList;
        private Button btnEdit;
        private Button btnDelete;
    }
}