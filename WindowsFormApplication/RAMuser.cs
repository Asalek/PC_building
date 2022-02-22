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
    public partial class RAMuser : UserControl
    {
        public decimal capacity { get; set; }
        public int rrr { get; set; }
        PCEntities pc = new PCEntities();
        public RAMuser()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.RAMs.Where(x => x.id == 3).ToList();
            rrr = 3;
            numericUpDown1.Visible = true;
        }

        private void RAMuser_Load(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.RAMs.Where(x => x.id == 2).ToList();
            rrr = 2;
            numericUpDown1.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pc.RAMs.Where(x => x.id == 1).ToList();
            rrr =1;
            numericUpDown1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capacity = numericUpDown1.Value;
            if(rrr<1 || rrr > 3)
            { MessageBox.Show("choisir votre RAM"); }
            else { MessageBox.Show("bien enregistrer"); this.Hide(); }
            
        }
    }
}
