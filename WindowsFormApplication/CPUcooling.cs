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
    public partial class CPUcooling : UserControl
    {
        PCEntities pc = new PCEntities();
        public int cpufan { get; set; }
        public CPUcooling()
        {
            InitializeComponent();
        }

        private void CPUcooling_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= pc.coolings.Where(x => x.id == 1).ToList();
            cpufan = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.coolings.Where(x => x.id == 2).ToList();
            cpufan = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.coolings.Where(x => x.id == 3).ToList();
            cpufan = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cpufan == 0)
            {
                MessageBox.Show("choisir un Cooler !!!");

            }
            else
            {
                MessageBox.Show("bien enregistrer");
                this.Hide();
            }
        }
    }
}
