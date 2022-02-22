using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserControl1 : UserControl
    {
        public int aaa { get; set; }
        
        PCEntities pc = new PCEntities();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.CPUs.Where(x => x.id == 1).ToList();
            aaa = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.CPUs.Where(x => x.id == 2).ToList();
            aaa = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.CPUs.Where(x => x.id == 3).ToList();
            aaa = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.CPUs.Where(x => x.id == 4).ToList();
            aaa = 4;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.CPUs.Where(x => x.id == 5).ToList();
            aaa = 5;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.CPUs.Where(x => x.id == 6).ToList();
            aaa = 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form4 f;
            //f= new Form4();
            //f.pictureBox10.Visible = false;
            //f.pictureBox11.Visible = true;
            //f.ShowDialog();
            //  Form4 f = new Form4(a);
            if (aaa < 1 || aaa >6 )
            {
                MessageBox.Show("choix inconuue");
            }
            else
            {
                MessageBox.Show(" bien enregistre");
                this.Hide();
                
            }
        }
    }
}
