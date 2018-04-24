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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            Forgetpassword frm = new Forgetpassword();
            frm.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            homepage frm = new homepage();
            frm.Show();
            this.Hide();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            studentregister frm = new studentregister();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            bool isval;
            bool isvalpassed;
            taimoor_net.Service1 ser = new taimoor_net.Service1();
            ser.isvaliduser(txtusername.Text, txtpassword.Text, out isval, out isvalpassed);
            if (txtusername.Text=="Taimoor Ahmad"  && txtpassword.Text== "Blackhawk007" )
            {
                Adminpage frm = new Adminpage();
                frm.Show();
                this.Hide();
            }
            if (isval)
            {
                studentaccount frm = new studentaccount();
                frm.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}
