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
    public partial class ssdHDD : UserControl
    {
        PCEntities pc = new PCEntities();
        public int stok { get; set; }
        public ssdHDD()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.stockages.Where(x => x.id == 1).ToList();
            stok = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.stockages.Where(x => x.id == 2).ToList();
            stok = 2;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.stockages.Where(x => x.id == 3).ToList();
            stok = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.stockages.Where(x => x.id == 4).ToList();
            stok = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(stok<1 || stok>4)
            { MessageBox.Show("choisir le stockage"); }
            else
            {
                MessageBox.Show("le choix bien effectuer");
                this.Hide();
            }
        }
    }
}
