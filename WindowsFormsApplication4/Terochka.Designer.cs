namespace WindowsFormsApplication4
{
    partial class Terochka
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terochka));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ovoshKotoryiTrut = new System.Windows.Forms.PictureBox();
            this.saloLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovoshKotoryiTrut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.animeTer;
            this.pictureBox1.Location = new System.Drawing.Point(241, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ovoshKotoryiTrut
            // 
            this.ovoshKotoryiTrut.BackColor = System.Drawing.Color.White;
            this.ovoshKotoryiTrut.Image = global::WindowsFormsApplication4.Properties.Resources.brocoli;
            this.ovoshKotoryiTrut.Location = new System.Drawing.Point(174, 90);
            this.ovoshKotoryiTrut.Name = "ovoshKotoryiTrut";
            this.ovoshKotoryiTrut.Size = new System.Drawing.Size(127, 132);
            this.ovoshKotoryiTrut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovoshKotoryiTrut.TabIndex = 1;
            this.ovoshKotoryiTrut.TabStop = false;
            this.ovoshKotoryiTrut.Visible = false;
            // 
            // saloLabel
            // 
            this.saloLabel.AutoSize = true;
            this.saloLabel.Location = new System.Drawing.Point(426, 18);
            this.saloLabel.Name = "saloLabel";
            this.saloLabel.Size = new System.Drawing.Size(57, 13);
            this.saloLabel.TabIndex = 8;
            this.saloLabel.Text = "салоcoin :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::WindowsFormsApplication4.Properties.Resources.Salocoin;
            this.pictureBox3.Location = new System.Drawing.Point(373, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 47);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Terochka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.ytrk_mini;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(572, 342);
            this.Controls.Add(this.saloLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ovoshKotoryiTrut);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Terochka";
            this.Text = "Terochka";
            this.Load += new System.EventHandler(this.Terochka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovoshKotoryiTrut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ovoshKotoryiTrut;
        private System.Windows.Forms.Label saloLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}