namespace WindowsFormsApplication4
{
    partial class My_Kabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(My_Kabinet));
            this.saloLabel = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // saloLabel
            // 
            this.saloLabel.AutoSize = true;
            this.saloLabel.Location = new System.Drawing.Point(426, 18);
            this.saloLabel.Name = "saloLabel";
            this.saloLabel.Size = new System.Drawing.Size(57, 13);
            this.saloLabel.TabIndex = 12;
            this.saloLabel.Text = "салоcoin :";
            this.saloLabel.Click += new System.EventHandler(this.saloLabel_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Image = global::WindowsFormsApplication4.Properties.Resources.Salocoin;
            this.pictureBox10.Location = new System.Drawing.Point(373, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(46, 47);
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.ykea;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(226, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 50);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // My_Kabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.ytrk_mini;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(596, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saloLabel);
            this.Controls.Add(this.pictureBox10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "My_Kabinet";
            this.Text = "My_Kabinet";
            this.Load += new System.EventHandler(this.My_Kabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saloLabel;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button button1;
    }
}