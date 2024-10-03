namespace Birds
{
    partial class Peacock
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
            this.pbPeacock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeacock)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPeacock
            // 
            this.pbPeacock.Image = global::Birds.Properties.Resources.Peacock;
            this.pbPeacock.Location = new System.Drawing.Point(128, 46);
            this.pbPeacock.Name = "pbPeacock";
            this.pbPeacock.Size = new System.Drawing.Size(552, 340);
            this.pbPeacock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPeacock.TabIndex = 0;
            this.pbPeacock.TabStop = false;
            // 
            // Peacock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPeacock);
            this.Name = "Peacock";
            this.Text = "Peacock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Peacock_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbPeacock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPeacock;
    }
}