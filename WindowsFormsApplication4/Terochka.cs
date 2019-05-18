using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Terochka : Form
    {
        
        private int ShowPasswordStart = 0;
        Random rnd = new Random();

        public Terochka()
        {
            InitializeComponent();

            if (Skins.terka != null)
            {
                pictureBox1.Image = Skins.terka.Image;
            }

            System.Drawing.Drawing2D.GraphicsPath gp = BuildTransparencyPath(pictureBox1);
            pictureBox1.Region = new Region(gp);

            System.Drawing.Drawing2D.GraphicsPath gp2 = BuildTransparencyPath(ovoshKotoryiTrut);
            ovoshKotoryiTrut.Region = new Region(gp2);

            System.Drawing.Drawing2D.GraphicsPath gp3 = BuildTransparencyPath(pictureBox3);
            pictureBox3.Region = new Region(gp3);
        }
        
        public static System.Drawing.Drawing2D.GraphicsPath BuildTransparencyPath(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            Image im = pb.Image;
            int x;
            int y;
            if(pb.Image==null)
            {
                return gp;
            }
            Bitmap bmp = new Bitmap(im);
            Color mask = bmp.GetPixel(0, 0);

            for (x = 0; x <= pb.Size.Width - 1; x++)
            {
                for (y = 0; y <= pb.Size.Height - 1; y++)
                {
                    int newX = x * im.Size.Width / pb.Size.Width;
                    int newY = y * im.Size.Height / pb.Size.Height;

                    if (!bmp.GetPixel(newX, newY).Equals(mask))
                    {                                                
                        gp.AddRectangle(new Rectangle(
                            x,
                            y, 1, 1));
                    }
                }
            }
            bmp.Dispose();
            return gp;
        }

       /// <summary>
       /// Трение овоща
       /// </summary>
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            int CurrentTime = Environment.TickCount;
            /*saloLabel.Text = ((10000 + ShowPasswordStart - CurrentTime)/1000).ToString();
            if (CurrentTime - ShowPasswordStart > 10000)
            {

                Close();
            }*/




            bool tovarEst = false;
            foreach (PictureBox pb in MagazinForm.tovary)
            {
                if (ovoshKotoryiTrut.Image == pb.Image)
                {
                    tovarEst = true;
                }
            }

            //Овощ стерся
            if (CurrentTime - ShowPasswordStart >= 3000 && 
                ovoshKotoryiTrut.Visible == true && 
                tovarEst == true)

            {
                ovoshKotoryiTrut.Visible = false;

                //Вернуть бабло
                MagazinForm.money = MagazinForm.money + 110;
                saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();

                //Удалить товар из купленных
                //List<PictureBox> newTovary = MagazinForm.tovary
                foreach (PictureBox pb in MagazinForm.tovary)
                {
                    if (ovoshKotoryiTrut.Image == pb.Image)
                    {
                        MagazinForm.tovary.Remove(pb);
                        Terochka_Load(sender, e);
                        break;
                    }
                }
            }


            ovoshKotoryiTrut.Location = new Point(
                pictureBox1.Location.X + pictureBox1.Size.Width - 220,
                ovoshKotoryiTrut.Location.Y + (rnd.Next() % 4) - (rnd.Next() % 4));

            if (ovoshKotoryiTrut.Location.Y < 0)
            {
                ovoshKotoryiTrut.Location = new Point(ovoshKotoryiTrut.Location.X, 0);
            }
            //Запиши уже, что Y не может уходить вниз
            if (ovoshKotoryiTrut.Location.Y < 0)
            {
                ovoshKotoryiTrut.Location = new Point(ovoshKotoryiTrut.Location.X, 0);
            }
        }

        /// <summary>
        /// Выбор овоща, который будут тереть
        /// </summary>
        private void pictureBoxClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ovoshKotoryiTrut.Image = pb.Image;
            ovoshKotoryiTrut.Size = new Size(127, 127 * pb.Size.Height / pb.Size.Width);
            System.Drawing.Drawing2D.GraphicsPath gp2 = BuildTransparencyPath(ovoshKotoryiTrut);
            ovoshKotoryiTrut.Region = new Region(gp2);

            this.Controls.Remove(pb);

            //MagazinForm.tovary.Remove(pb);
            //ShowPasswordStart = Environment.TickCount;
            ovoshKotoryiTrut.Visible = true;
        }

        /// <summary>
        /// Рисуем все купленные овощи
        /// </summary>
        private void Terochka_Load(object sender, EventArgs e)
        {
            
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
            ShowPasswordStart = Environment.TickCount;           

           
            foreach (PictureBox pb in MagazinForm.tovary)
            {
                pb.Location = new Point(pb.Location.X * 70 / 200 , 250);
                
                pb.Size = new Size(70, 70 * pb.Size.Height / pb.Size.Width);
                pb.Click += pictureBoxClick;
                this.Controls.Add(pb);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ovoshKotoryiTrut.Visible == false)
            {
                ovoshKotoryiTrut.Visible = true;
                ShowPasswordStart = Environment.TickCount;
            }
        }
    }
}
