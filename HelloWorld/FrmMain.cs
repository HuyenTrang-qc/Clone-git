using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void danhMụcKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.ShowDialog();
        }

        private void táchTênNgườiViệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Chức năng tách tên người Việt"; 
            Form a = new FrmTachTen();
            a.ShowDialog();
            status1.Text = "Ready!";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.ShowDialog();
        }

        private void kếtThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.ShowDialog();
        }

        private void táchTênNgườiViệtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form a = new FrmTachTen();
            a.ShowDialog();
        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void status3_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status3.Text = System.DateTime.Now.ToString();
        }

        private void status1_Click(object sender, EventArgs e)
        {

        }
    }
}
