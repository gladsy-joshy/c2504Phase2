namespace Example2Project
{
    partial class MainPageForm
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
            menuStrip1 = new MenuStrip();
            mnuCalc = new ToolStripMenuItem();
            mnuSumCalc = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuSquareCalc = new ToolStripMenuItem();
            mnuSal = new ToolStripMenuItem();
            mnuContact = new ToolStripMenuItem();
            mnuNewContact = new ToolStripMenuItem();
            mnuContactList = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCalc, mnuSal, mnuContact });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuCalc
            // 
            mnuCalc.DropDownItems.AddRange(new ToolStripItem[] { mnuSumCalc, toolStripSeparator1, mnuSquareCalc });
            mnuCalc.Name = "mnuCalc";
            mnuCalc.Size = new Size(90, 24);
            mnuCalc.Text = "&Calculator";
            mnuCalc.Click += mnuCalc_Click;
            // 
            // mnuSumCalc
            // 
            mnuSumCalc.Name = "mnuSumCalc";
            mnuSumCalc.Size = new Size(224, 26);
            mnuSumCalc.Text = "&Sum Calculator";
            mnuSumCalc.Click += mnuSumCalc_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // mnuSquareCalc
            // 
            mnuSquareCalc.Name = "mnuSquareCalc";
            mnuSquareCalc.Size = new Size(224, 26);
            mnuSquareCalc.Text = "S&quare Calculator";
            mnuSquareCalc.Click += mnuSquareCalc_Click;
            // 
            // mnuSal
            // 
            mnuSal.Name = "mnuSal";
            mnuSal.Size = new Size(63, 24);
            mnuSal.Text = "&Salary";
            mnuSal.Click += mnuSal_Click;
            // 
            // mnuContact
            // 
            mnuContact.DropDownItems.AddRange(new ToolStripItem[] { mnuNewContact, mnuContactList });
            mnuContact.Name = "mnuContact";
            mnuContact.Size = new Size(74, 24);
            mnuContact.Text = "C&ontact";
            mnuContact.Click += mnuContact_Click;
            // 
            // mnuNewContact
            // 
            mnuNewContact.Name = "mnuNewContact";
            mnuNewContact.Size = new Size(224, 26);
            mnuNewContact.Text = "&New Contact";
            mnuNewContact.Click += mnuNewContact_Click;
            // 
            // mnuContactList
            // 
            mnuContactList.Name = "mnuContactList";
            mnuContactList.Size = new Size(224, 26);
            mnuContactList.Text = "&Contact  List";
            mnuContactList.Click += mnuContactList_Click;
            // 
            // MainPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainPageForm";
            Text = "Example 2 App";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainPageForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuCalc;
        private ToolStripMenuItem mnuSumCalc;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuSquareCalc;
        private ToolStripMenuItem mnuSal;
        private ToolStripMenuItem mnuContact;
        private ToolStripMenuItem mnuNewContact;
        private ToolStripMenuItem mnuContactList;
    }
}
