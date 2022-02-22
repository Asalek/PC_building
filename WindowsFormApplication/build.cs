using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        
        //Class1 pcPC { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("le processeur",pictureBox1);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("la cart mere", pictureBox3);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("la Ram", pictureBox4);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("la cart graphic", pictureBox5);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("le Stockage/SSD-HDD", pictureBox6);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("la boit d'allumentation", pictureBox7);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Cooler", pictureBox8);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Case", pictureBox9);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
        }
    }
}
