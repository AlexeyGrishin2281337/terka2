namespace WindowsFormsApplication4
{
    partial class MagazinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazinForm));
            this.label1 = new System.Windows.Forms.Label();
            this.productsPanel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDalshe1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.productsPanel2 = new System.Windows.Forms.Panel();
            this.buttonDalshe2 = new System.Windows.Forms.Button();
            this.buttonNazad2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.productsPanel3 = new System.Windows.Forms.Panel();
            this.buttonNazad3 = new System.Windows.Forms.Button();
            this.saloLabel = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.productsPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.productsPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.productsPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 73);
            this.label1.TabIndex = 0;
            // 
            // productsPanel1
            // 
            this.productsPanel1.Controls.Add(this.label2);
            this.productsPanel1.Controls.Add(this.buttonDalshe1);
            this.productsPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productsPanel1.Location = new System.Drawing.Point(3, -7);
            this.productsPanel1.Name = "productsPanel1";
            this.productsPanel1.Size = new System.Drawing.Size(561, 288);
            this.productsPanel1.TabIndex = 6;
            this.productsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.productsPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Location = new System.Drawing.Point(197, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Все овощи: 80 салоcoin\'ов";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // buttonDalshe1
            // 
            this.buttonDalshe1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDalshe1.Location = new System.Drawing.Point(477, 262);
            this.buttonDalshe1.Name = "buttonDalshe1";
            this.buttonDalshe1.Size = new System.Drawing.Size(75, 23);
            this.buttonDalshe1.TabIndex = 6;
            this.buttonDalshe1.Text = "Дальше";
            this.buttonDalshe1.UseVisualStyleBackColor = true;
            this.buttonDalshe1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 310);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.productsPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.productsPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // productsPanel2
            // 
            this.productsPanel2.Controls.Add(this.buttonDalshe2);
            this.productsPanel2.Controls.Add(this.buttonNazad2);
            this.productsPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productsPanel2.Location = new System.Drawing.Point(3, 0);
            this.productsPanel2.Name = "productsPanel2";
            this.productsPanel2.Size = new System.Drawing.Size(561, 281);
            this.productsPanel2.TabIndex = 0;
            // 
            // buttonDalshe2
            // 
            this.buttonDalshe2.Location = new System.Drawing.Point(486, 259);
            this.buttonDalshe2.Name = "buttonDalshe2";
            this.buttonDalshe2.Size = new System.Drawing.Size(75, 23);
            this.buttonDalshe2.TabIndex = 5;
            this.buttonDalshe2.Text = "Дальше";
            this.buttonDalshe2.UseVisualStyleBackColor = true;
            this.buttonDalshe2.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonNazad2
            // 
            this.buttonNazad2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNazad2.Location = new System.Drawing.Point(0, 258);
            this.buttonNazad2.Name = "buttonNazad2";
            this.buttonNazad2.Size = new System.Drawing.Size(75, 23);
            this.buttonNazad2.TabIndex = 1;
            this.buttonNazad2.Text = "Назад";
            this.buttonNazad2.UseVisualStyleBackColor = true;
            this.buttonNazad2.Click += new System.EventHandler(this.page1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.productsPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(567, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.productsPanel3_Click);
            // 
            // productsPanel3
            // 
            this.productsPanel3.Controls.Add(this.buttonNazad3);
            this.productsPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productsPanel3.Location = new System.Drawing.Point(0, 3);
            this.productsPanel3.Name = "productsPanel3";
            this.productsPanel3.Size = new System.Drawing.Size(567, 281);
            this.productsPanel3.TabIndex = 9;
            this.productsPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.productsPanel3_Paint);
            // 
            // buttonNazad3
            // 
            this.buttonNazad3.Location = new System.Drawing.Point(-1, 258);
            this.buttonNazad3.Name = "buttonNazad3";
            this.buttonNazad3.Size = new System.Drawing.Size(75, 23);
            this.buttonNazad3.TabIndex = 12;
            this.buttonNazad3.Text = "Назад";
            this.buttonNazad3.UseVisualStyleBackColor = true;
            this.buttonNazad3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // saloLabel
            // 
            this.saloLabel.AutoSize = true;
            this.saloLabel.Location = new System.Drawing.Point(426, 18);
            this.saloLabel.Name = "saloLabel";
            this.saloLabel.Size = new System.Drawing.Size(57, 13);
            this.saloLabel.TabIndex = 10;
            this.saloLabel.Text = "салоcoin :";
            this.saloLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Image = global::WindowsFormsApplication4.Properties.Resources.Salocoin;
            this.pictureBox10.Location = new System.Drawing.Point(373, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(46, 47);
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // MagazinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.ytrk_mini;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(572, 342);
            this.Controls.Add(this.saloLabel);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MagazinForm";
            this.Text = "MagazinForm";
            this.Load += new System.EventHandler(this.MagazinForm_Load);
            this.Resize += new System.EventHandler(this.MagazinForm_Resize);
            this.productsPanel1.ResumeLayout(false);
            this.productsPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.productsPanel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.productsPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel productsPanel1;
        private System.Windows.Forms.Button buttonDalshe1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel productsPanel2;
        private System.Windows.Forms.Button buttonNazad2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonDalshe2;
        private System.Windows.Forms.Panel productsPanel3;
        private System.Windows.Forms.Button buttonNazad3;
        private System.Windows.Forms.Label saloLabel;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label2;
    }
}