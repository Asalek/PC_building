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
    public partial class power : UserControl
    {
        public int pow {get;set;}
        PCEntities pc = new PCEntities();
        public power()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pow < 1 || pow > 3)
            { MessageBox.Show("choisir la boite d'alumentation "); }
            else
            {
                MessageBox.Show("le choix bien effectuer");
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.powerSupplies.Where(x => x.id == 1).ToList();
            pow = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.powerSupplies.Where(x => x.id == 2).ToList();
            pow = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.powerSupplies.Where(x => x.id == 3).ToList();
            pow = 3;
        }
    }
}
