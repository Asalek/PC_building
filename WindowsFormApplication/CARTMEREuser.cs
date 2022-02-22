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
    public partial class CARTMEREuser : UserControl
    {
        PCEntities pc = new PCEntities();
        public int mmm { get; set; }
        public CARTMEREuser()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.motherboards.Where(x => x.id == 1).ToList();
            mmm = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.motherboards.Where(x => x.id == 2).ToList();
            mmm = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.motherboards.Where(x => x.id == 3).ToList();
            mmm = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.motherboards.Where(x => x.id == 4).ToList();
            mmm = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(mmm< 1 || mmm>4)
            {
                MessageBox.Show("choisir votre cart mere");
            }
            else
            {
                MessageBox.Show("bien enregistrer");
                this.Hide();
            }
            
        }
    }
}
