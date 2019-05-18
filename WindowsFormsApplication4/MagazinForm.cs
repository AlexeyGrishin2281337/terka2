using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class MagazinForm : Form
    {
        /// <summary>
        /// Товары, которые купили
        /// </summary>
        public static List<PictureBox> tovary = new List<PictureBox>();
        /// <summary>
        /// Товары в магазине
        /// </summary>
        public static List<PictureBox> vse_tovary = new List<PictureBox>();

        /// <summary>
        /// Сумма салокоинов
        /// </summary>
        public static int money = 100000;

        public MagazinForm()
        {
            InitializeComponent();
            vse_tovary.Clear();
            int x = 0;          
            DirectoryInfo dir = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath) +
                "\\arhiv.zip");
            foreach (FileInfo fl in dir.GetFiles())
            {
                if (fl.Extension == ".png")
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(x, 0);
                    pb.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) +
                "\\arhiv.zip\\" + fl.Name);
                    pb.Size = new Size(150, 200);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Click += new System.EventHandler(pictureBox3_Click);

                    vse_tovary.Add(pb);
                    if (vse_tovary.Count <= 4)
                    {
                        productsPanel1.Controls.Add(pb);
                    }
                    else if (vse_tovary.Count <= 8)
                    {
                        productsPanel2.Controls.Add(pb);
                    }
                    else if (vse_tovary.Count <= 16)
                    {
                        productsPanel3.Controls.Add(pb);
                    }
                    
                    x = x + 140;

                    if (vse_tovary.Count % 4 == 0)
                    {
                        x = x - 560;
                    }
                }
            }

            System.Drawing.Drawing2D.GraphicsPath oz = Terochka.BuildTransparencyPath(pictureBox10);
            pictureBox10.Region = new Region(oz);
        }

        private void MagazinForm_Load(object sender, EventArgs e)
        {
           
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
            this.Controls.Clear();
            this.Controls.Add(pictureBox10);
            this.Controls.Add(saloLabel);
            this.Controls.Add(productsPanel1);
            MagazinForm_Resize(null, null);

            //vse_tovary.Add(pictureBox2);
            //vse_tovary.Add(pictureBox3);
            //vse_tovary.Add(pictureBox4);
        }

        /// <summary>
        /// 1 страница
        /// </summary>
        private void page1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(pictureBox10);
            this.Controls.Add(saloLabel);
            this.Controls.Add(productsPanel1);
            MagazinForm_Resize(null, null);
        }

        /// <summary>
        /// 2 страница
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(pictureBox10);
            this.Controls.Add(saloLabel);
            this.Controls.Add(productsPanel2);
            MagazinForm_Resize(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(pictureBox10);
            this.Controls.Add(saloLabel);
            this.Controls.Add(productsPanel3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(pictureBox10);
            this.Controls.Add(saloLabel);
            this.Controls.Add(productsPanel2);
        }

        private void productsPanel3_Click(object sender, EventArgs e)
        {

        }

        private void productsPanel4_Click(object sender, EventArgs e)
        {

        }


       

        private void productsPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void productsPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(productsPanel2);
        }

        private void MagazinForm_Resize(object sender, EventArgs e)
        {
            productsPanel1.Height = this.Height - 100;
            productsPanel2.Height = this.Height - 100;
            productsPanel3.Height = this.Height - 100;

            buttonDalshe1.Location = new Point(
                productsPanel1.Width - buttonDalshe1.Size.Width, 
                productsPanel1.Height - buttonDalshe1.Size.Height);
            buttonDalshe2.Location = new Point(
                productsPanel2.Width - buttonDalshe2.Size.Width, 
                productsPanel2.Height - buttonDalshe2.Size.Height);
            buttonNazad2.Location = new Point(
                0,
                productsPanel2.Height - buttonNazad2.Size.Height);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (tovary.Contains(pb) == false && MagazinForm.money >= 80)
            {
                tovary.Add(pb);
                MagazinForm.money = MagazinForm.money - 80;
                saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
