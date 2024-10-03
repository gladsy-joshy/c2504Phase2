namespace Birds
{
    partial class Crow
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
            this.pbCrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrow)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCrow
            // 
            this.pbCrow.Image = global::Birds.Properties.Resources.Crow;
            this.pbCrow.Location = new System.Drawing.Point(87, 26);
            this.pbCrow.Name = "pbCrow";
            this.pbCrow.Size = new System.Drawing.Size(664, 359);
            this.pbCrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrow.TabIndex = 0;
            this.pbCrow.TabStop = false;
            // 
            // Crow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCrow);
            this.Name = "Crow";
            this.Text = "Crow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Crow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCrow;
    }
}