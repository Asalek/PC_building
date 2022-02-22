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
    public partial class casee : UserControl
    {
        PCEntities pc = new PCEntities();
        public int caseID { get; set; }
        public casee()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.case1.Where(x => x.id == 2).ToList();
            caseID = 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.case1.Where(x => x.id == 1).ToList();
            caseID = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.case1.Where(x => x.id == 3).ToList();
            caseID = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (caseID < 1 || caseID > 3)
            {
                MessageBox.Show("choisir votre case !");
            }
            else
            {
                MessageBox.Show("votre demande bien enregistrer");
                this.Hide();
            }
        }
    }
}
