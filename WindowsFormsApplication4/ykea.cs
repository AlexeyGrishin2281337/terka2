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
    public partial class ykea : Form
    {
        /// <summary>
        /// Вся мебель, которую можно купить
        /// </summary>
        public static List<PictureBox> vse_mebel = new List<PictureBox>();
        /// <summary>
        /// Купленная мебель
        /// </summary>
        public static List<PictureBox> kypi_mebel = new List<PictureBox>();
        public ykea()
        {
            InitializeComponent();
            //vse_tovary.Clear();
            int x = 0;
            DirectoryInfo dir = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath) +
                "\\mebel\\");
            foreach (FileInfo fl in dir.GetFiles())
            {
                if (fl.Extension == ".png")
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) +
                "\\mebel\\" + fl.Name);
                    int width = pb.Image.Width;
                    int height = pb.Image.Height;

                    string[] split = fl.Name.Split(new Char[] { '_', '.' });
                    pb.Size = new Size(width, height);
                    pb.Tag = split[1];
                    pb.AccessibleDescription = split[2];
                    pb.AccessibleName = split[3];
                    pb.Location = new Point(x, 300 - height);
                    pb.Name = fl.Name;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Click += new System.EventHandler(pictureBox3_Click);


                    vse_mebel.Add(pb);
                    /*if (vse_tovary.Count <= 4)
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
                    }*/
                    this.Controls.Add(pb);

                    x = x + width;

                    /*if (vse_tovary.Count % 4 == 0)
                    {
                        x = x - 560;
                    }*/

                }
            }

            System.Drawing.Drawing2D.GraphicsPath oz = Terochka.BuildTransparencyPath(pictureBox10);
            pictureBox10.Region = new Region(oz);
        }

        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            //Проверяем, что была мебель с таким же тегом
            bool nadoDobavit = true;
            foreach (PictureBox pb1 in kypi_mebel)
            {
                if (pb1.Name.ToString() == pb.Name.ToString())
                {
                    nadoDobavit = false;
                }
            }
            int price = Convert.ToInt32(pb.Tag.ToString());

            if (nadoDobavit && MagazinForm.money >= price + 80)
            {
                kypi_mebel.Add(pb);
                MagazinForm.money = MagazinForm.money - price;
                saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
            }
        }

        private void ykea_Load(object sender, EventArgs e)
        {
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
        }
    }
}
