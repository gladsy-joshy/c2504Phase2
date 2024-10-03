namespace Birds
{
    partial class Duck
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
            this.pbDuck = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDuck)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDuck
            // 
            this.pbDuck.Image = global::Birds.Properties.Resources.Duck;
            this.pbDuck.Location = new System.Drawing.Point(72, 12);
            this.pbDuck.Name = "pbDuck";
            this.pbDuck.Size = new System.Drawing.Size(660, 402);
            this.pbDuck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDuck.TabIndex = 0;
            this.pbDuck.TabStop = false;
            // 
            // Duck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbDuck);
            this.Name = "Duck";
            this.Text = "Duck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Duck_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbDuck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDuck;
    }
}