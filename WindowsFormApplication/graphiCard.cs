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
    public partial class graphiCard : UserControl
    {
        PCEntities pc = new PCEntities();
        public int ggg { get; set; }
        public graphiCard()
        {
            InitializeComponent();
        }

        private void graphiCard_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.graphicCards.Where(x => x.id == 1).ToList();
            ggg = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.graphicCards.Where(x => x.id == 2).ToList();
            ggg = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.graphicCards.Where(x => x.id == 3).ToList();
            ggg = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ggg < 1 || ggg > 4)
            {
                MessageBox.Show("alors tu choisir aucun carte graphic pas de problem c'est optionelle");
                MessageBox.Show("bien enregistrer");
                this.Hide();
            }
            else
            {
                MessageBox.Show("bien enregistrer");
                this.Hide();
            }
        }
    }
}
