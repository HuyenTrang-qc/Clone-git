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
    public partial class FrmTachTen : Form
    {
        public FrmTachTen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Form.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string ht;
            int vtd, vtc;
            ht = txtHoTen.Text.Trim();
            vtd = ht.IndexOf(" ");
            vtc = ht.LastIndexOf(" ");
            try
            {
                if(vtd > 0)
                {
                    txtHo.Text = ht.Substring(0, vtd);
                    txtTen.Text = ht.Substring(vtc + 1);
                    txtDem.Text = ht.Substring(vtd + 1, ht.Length - vtd - txtTen.TextLength - 1 - 1);
                } else
                {
                    txtHo.Text = ht;


                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {
        }

        private void FrmTachTen_Load(object sender, EventArgs e)
        {

        }
    }
}
