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
    public partial class Ya_Terochka : Form
    {
        public Ya_Terochka()
        {
            InitializeComponent();
        }

        private void Магазин_Click(object sender, EventArgs e)
        {
            MagazinForm mf = new MagazinForm();
            mf.ShowDialog();
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
        }

        private void Тёрочка_Click(object sender, EventArgs e)
        {
            Terochka mv= new Terochka();
            mv.ShowDialog();
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
        }

        private void Мой_кабинет_Click(object sender, EventArgs e)
        {
            My_Kabinet ms = new My_Kabinet();
            ms.ShowDialog();
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
        }

        private void Скины_Click(object sender, EventArgs e)
        {
            Skins mk = new Skins();
            mk.ShowDialog();
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ya_Terochka_Load(object sender, EventArgs e)
        {
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
            System.Drawing.Drawing2D.GraphicsPath gp2 = Terochka.BuildTransparencyPath(pictureBox1);
            pictureBox1.Region = new Region(gp2);

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
