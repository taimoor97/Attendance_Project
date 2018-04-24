using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendanceproject
{
    public partial class Forgetpassword : Form
    {
        public Forgetpassword()
        {
            InitializeComponent();
        }

        private void linkLabelslogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                   }

        private void btnhome_Click(object sender, EventArgs e)
        {
            homepage frm = new homepage();
            frm.Show();
            this.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Forgetpassword_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
