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
    public partial class teachersdata : Form
    {
        public teachersdata()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            homepage frm = new homepage();
            frm.Show();
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtemail.Text = "";
            txtpassword.Text = "";
            txtqualification.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            taimoor_net.Service1 ser = new taimoor_net.Service1();
            ser.registerteacher(txtname.Text, txtpassword.Text, txtemail.Text, txtqualification.Text);
            MessageBox.Show("Teacher is registered Successfully Registered");
        }

        private void btnaddclasses_Click(object sender, EventArgs e)
        {
            Addclasses frm = new Addclasses();
            frm.Show();
            this.Hide();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            teachersdata frm = new teachersdata();
            frm.Show();
            this.Hide();
        }
    }
}
