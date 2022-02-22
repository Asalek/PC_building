using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : System.Windows.Forms.Form
    {
        PCEntities pc = new PCEntities();
        public int CPUID = 0;
        public int cartmere = 0;
        public int GPU = 0;
        public int RAM = 0;
        public decimal ramCapacity = 0;
        public int stockage = 0;
        public int cooling = 0;
        public int powerS = 0;
        public int case1 = 0;
        public Form4( )
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cpUcooling1.Visible = false;
            casee1.Visible = false;
            userControl11.Visible = true;
            pictureBox10.Visible = false;
            pictureBox11.Visible = true;
            cartmerEuser1.Visible = false;
            graphiCard1.Visible = false;
            raMuser1.Visible = false;
            ssdHDD1.Visible = false;
            power1.Visible = false;
            cpUcooling1.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cpUcooling1.Visible = false;
            casee1.Visible = false;
            userControl11.Visible = false;
            graphiCard1.Visible = false;
            raMuser1.Visible = false;
            ssdHDD1.Visible = false;
            power1.Visible = false; 
            cartmerEuser1.Visible = true;
            pictureBox11.Visible = false;
            pictureBox12.Visible = true;
            using (UserControl1 uc = new UserControl1())
            {
                this.CPUID = userControl11.aaa;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cpUcooling1.Visible = false;
            casee1.Visible = false;
            userControl11.Visible = false;
            graphiCard1.Visible = false;
            ssdHDD1.Visible = false;
            power1.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = true;
            raMuser1.Visible = true;
            cartmerEuser1.Visible = false;
            using (CARTMEREuser cv = new CARTMEREuser())
            {
                this.cartmere = cartmerEuser1.mmm;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cpUcooling1.Visible = false;
            casee1.Visible = false;
            userControl11.Visible = false;
            raMuser1.Visible = false;
            ssdHDD1.Visible = false;
            power1.Visible = false;

            pictureBox13.Visible = false;
            pictureBox14.Visible = true;
            using (RAMuser ra = new RAMuser())
            {
                this.ramCapacity = raMuser1.capacity;
                this.RAM = raMuser1.rrr; 
            }
            graphiCard1.Visible = true;
            cartmerEuser1.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cpUcooling1.Visible = false;
            casee1.Visible = false;
            cartmerEuser1.Visible = false;
            userControl11.Visible = false;
            raMuser1.Visible = false;
            power1.Visible = false;
            pictureBox14.Visible = false;
            graphiCard1.Visible = false;
            pictureBox15.Visible = true;
            ssdHDD1.Visible = true;
            using (graphiCard gf = new graphiCard())
            {
                this.GPU = graphiCard1.ggg;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            cpUcooling1.Visible = false;
            casee1.Visible = false;
            cartmerEuser1.Visible = false;
            userControl11.Visible = false;
            graphiCard1.Visible = false;
            raMuser1.Visible = false;
            ssdHDD1.Visible = false;
            power1.Visible = true;
            pictureBox15.Visible = false;
            pictureBox16.Visible = true;
            using (ssdHDD st = new ssdHDD())
            {
                this.stockage = ssdHDD1.stok;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            casee1.Visible = false;
            cpUcooling1.Visible = true;
            cartmerEuser1.Visible = false;
            userControl11.Visible = false;
            graphiCard1.Visible = false;
            raMuser1.Visible = false;
            ssdHDD1.Visible = false;
            power1.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = true;
            using (power st = new power())
            {
                this.powerS = power1.pow;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
            cpUcooling1.Visible = false;
            cartmerEuser1.Visible = false;
            userControl11.Visible = false;
            graphiCard1.Visible = false;
            raMuser1.Visible = false;
            ssdHDD1.Visible = false;
            power1.Visible = false;
            pictureBox17.Visible = false;
            using (CPUcooling cc = new CPUcooling())
            {
                this.cooling = cpUcooling1.cpufan;
            }
                if (CPUID != 0 && cartmere != 0 && RAM != 0 && stockage != 0 && cooling != 0 && powerS != 0)
                {
                casee1.Visible = true;
                button1.Visible = true;
                    pictureBox18.Visible = true;
                    pictureBox17.Visible = false;

                }//GPU optionnell 
             if (CPUID == 0){ pictureBox10.Visible = true; MessageBox.Show("choisir les pièces hardware nécessaire suivez les flèches");
            }
            if (cartmere == 0) { pictureBox11.Visible = true; MessageBox.Show("choisir les pièces hardware nécessaire suivez les flèches");
            }
            if (RAM == 0) { pictureBox12.Visible = true; MessageBox.Show("choisir les pièces hardware nécessaire suivez les flèches");
            }
            if (stockage == 0) { pictureBox14.Visible = true; MessageBox.Show("choisir les pièces hardware nécessaire suivez les flèches");
            }
            if (cooling == 0) { pictureBox16.Visible = true; MessageBox.Show("choisir les pièces hardware nécessaire suivez les flèches");
            }
            if (powerS == 0) { pictureBox15.Visible = true; MessageBox.Show("choisir les pièces hardware nécessaire suivez les flèches");
            }
            

        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("le Processeur", pictureBox2);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Red;
            toolTip1.BackColor = Color.Yellow;
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
            toolTip1.Show("le Stockage/SSD_HDD", pictureBox6);
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
            toolTip1.Show("CPU FAN/Cooler", pictureBox8);
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

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            cartmerEuser1.Visible = false;
            userControl11.Visible = false;
            graphiCard1.Visible = false;
            raMuser1.Visible = false;
            ssdHDD1.Visible = false;
            power1.Visible = false;
            casee1.Visible = false;
            cpUcooling1.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void raMuser1_Load(object sender, EventArgs e)
        {

        }

        private void cartmerEuser1_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (casee ca = new casee())
            {
                this.case1 = casee1.caseID;
            }
            try
            {
                var CPU = pc.CPUs.Where(x => x.id == CPUID).Select(x => new { x.name }).ToList();
                var ram = pc.RAMs.Where(x => x.id == RAM).Select(x => new { x.name }).ToList();
                var MB = pc.motherboards.Where(x => x.id == cartmere).Select(x => new { x.name }).ToList();
                var GC = pc.graphicCards.Where(x => x.id == GPU).Select(x => new { x.name }).ToList();
                var SSD = pc.stockages.Where(x => x.id == stockage).Select(x => new { x.name }).ToList();
                var PS = pc.powerSupplies.Where(x => x.id == powerS).Select(x => new { x.name }).ToList();
                var Fan = pc.coolings.Where(x => x.id == cooling).Select(x => new { x.name }).ToList();
                var Case = pc.case1.Where(x => x.id == case1).Select(x => new { x.name }).ToList();
                pc.Demands.Add(new Demand
                {
                    id = 2,
                    cpu = CPU.ToString(),
                    motherboard = MB.ToString(),
                    ram = ram.ToString(),
                    graphiccard = GC.ToString(),
                    stockage = SSD.ToString(),
                    powerSupplay = PS.ToString(),
                    cooling = Fan.ToString(),
                    case1 = Case.ToString(),
                    price = 0
                });
                pc.SaveChanges();
                MessageBox.Show("ajoute avec succes");
            }
            catch (Exception) { throw new Exception("ajoute errone"); }
                //pc.Database.ExecuteSqlCommand("insert into Demand values({0},{1},{2},{3},{4},{5},{6},{7},{8},{9})",2,CPU, MB,ram,GC,SSD,PS,Fan,Case,99);
            
        }
    }
}
