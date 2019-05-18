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
    public partial class Skins : Form
    {
        public static PictureBox terka;

        public Skins()
        {
            InitializeComponent();
        }

        private void Skins_Load(object sender, EventArgs e)
        {
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
            InitializeComponent();

            int x = 0;
            DirectoryInfo dir = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath) +
                "\\Terochki");
            foreach (FileInfo fl in dir.GetFiles())
            {
                if (fl.Extension == ".png")
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(x, 100);
                    pb.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) +
                "\\Terochki\\" + fl.Name);
                    pb.Size = new Size(200, 200);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Click += new System.EventHandler(pictureBox3_Click);
                    this.Controls.Add(pb);
                    System.Drawing.Drawing2D.GraphicsPath blueTerkaOblast = Terochka.BuildTransparencyPath(pb);
                    pb.Region = new Region(blueTerkaOblast);
                    x = x + 200;
                }
            }

            System.Drawing.Drawing2D.GraphicsPath gp = Terochka.BuildTransparencyPath(pictureBox1);
            pictureBox1.Region = new Region(gp);

        }

        private void blueTerkaPictureBox_Click(object sender, EventArgs e)
        {
            //terka = blueTerkaPictureBox;

           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы изменили скин");
            terka = (PictureBox)sender;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //terka = pictureBox4;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
