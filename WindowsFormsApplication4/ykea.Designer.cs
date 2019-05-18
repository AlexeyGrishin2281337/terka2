namespace WindowsFormsApplication4
{
    partial class ykea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ykea));
            this.saloLabel = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // saloLabel
            // 
            this.saloLabel.AutoSize = true;
            this.saloLabel.Location = new System.Drawing.Point(426, 18);
            this.saloLabel.Name = "saloLabel";
            this.saloLabel.Size = new System.Drawing.Size(57, 13);
            this.saloLabel.TabIndex = 14;
            this.saloLabel.Text = "салоcoin :";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Image = global::WindowsFormsApplication4.Properties.Resources.Salocoin;
            this.pictureBox10.Location = new System.Drawing.Point(373, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(46, 47);
            this.pictureBox10.TabIndex = 13;
            this.pictureBox10.TabStop = false;
            // 
            // ykea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.ykea_mini;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(675, 342);
            this.Controls.Add(this.saloLabel);
            this.Controls.Add(this.pictureBox10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ykea";
            this.Text = "Ykea";
            this.Load += new System.EventHandler(this.ykea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saloLabel;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}