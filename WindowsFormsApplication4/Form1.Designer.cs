namespace WindowsFormsApplication4
{
    partial class Ya_Terochka
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ya_Terochka));
            this.Magazin = new System.Windows.Forms.Button();
            this.Тёрочка = new System.Windows.Forms.Button();
            this.Мой_кабинет = new System.Windows.Forms.Button();
            this.Скины = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saloLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Magazin
            // 
            this.Magazin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Magazin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Magazin.Location = new System.Drawing.Point(0, 0);
            this.Magazin.Margin = new System.Windows.Forms.Padding(0);
            this.Magazin.Name = "Magazin";
            this.Magazin.Size = new System.Drawing.Size(143, 25);
            this.Magazin.TabIndex = 0;
            this.Magazin.Text = "Магазин";
            this.Magazin.UseVisualStyleBackColor = true;
            this.Magazin.Click += new System.EventHandler(this.Магазин_Click);
            // 
            // Тёрочка
            // 
            this.Тёрочка.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Тёрочка.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Тёрочка.Location = new System.Drawing.Point(143, 0);
            this.Тёрочка.Margin = new System.Windows.Forms.Padding(0);
            this.Тёрочка.Name = "Тёрочка";
            this.Тёрочка.Size = new System.Drawing.Size(143, 25);
            this.Тёрочка.TabIndex = 1;
            this.Тёрочка.Text = "Тёрочка";
            this.Тёрочка.UseVisualStyleBackColor = true;
            this.Тёрочка.Click += new System.EventHandler(this.Тёрочка_Click);
            // 
            // Мой_кабинет
            // 
            this.Мой_кабинет.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Мой_кабинет.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Мой_кабинет.Location = new System.Drawing.Point(286, 0);
            this.Мой_кабинет.Margin = new System.Windows.Forms.Padding(0);
            this.Мой_кабинет.Name = "Мой_кабинет";
            this.Мой_кабинет.Size = new System.Drawing.Size(143, 25);
            this.Мой_кабинет.TabIndex = 2;
            this.Мой_кабинет.Text = "Мой кабинет";
            this.Мой_кабинет.UseVisualStyleBackColor = true;
            this.Мой_кабинет.Click += new System.EventHandler(this.Мой_кабинет_Click);
            // 
            // Скины
            // 
            this.Скины.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Скины.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Скины.Location = new System.Drawing.Point(429, 0);
            this.Скины.Margin = new System.Windows.Forms.Padding(0);
            this.Скины.Name = "Скины";
            this.Скины.Size = new System.Drawing.Size(143, 25);
            this.Скины.TabIndex = 4;
            this.Скины.Text = "Скины";
            this.Скины.UseVisualStyleBackColor = true;
            this.Скины.Click += new System.EventHandler(this.Скины_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Magazin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Тёрочка, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Мой_кабинет, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Скины, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 291);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.Salocoin;
            this.pictureBox1.Location = new System.Drawing.Point(372, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // saloLabel
            // 
            this.saloLabel.AutoSize = true;
            this.saloLabel.Location = new System.Drawing.Point(426, 18);
            this.saloLabel.Name = "saloLabel";
            this.saloLabel.Size = new System.Drawing.Size(57, 13);
            this.saloLabel.TabIndex = 6;
            this.saloLabel.Text = "салоcoin :";
            // 
            // Ya_Terochka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.ytrk_mini;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(572, 342);
            this.Controls.Add(this.saloLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Ya_Terochka";
            this.Text = "Ya_Terochka";
            this.Load += new System.EventHandler(this.Ya_Terochka_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Magazin;
        private System.Windows.Forms.Button Тёрочка;
        private System.Windows.Forms.Button Мой_кабинет;
        private System.Windows.Forms.Button Скины;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label saloLabel;
    }
}

