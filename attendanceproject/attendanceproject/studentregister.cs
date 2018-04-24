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
    public partial class studentregister : Form
    {
        public studentregister()
        {
            InitializeComponent();
        }

        

        private void btnhome_Click_1(object sender, EventArgs e)
        {
            homepage frm = new homepage();
            frm.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtpassword.Text = "";
            txtemail.Text = "";
            txtanswer.Text = "";
            comboclass.ResetText();
            comboquestion.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            taimoor_net.Service1 ser = new taimoor_net.Service1();
            ser.registerstudent(txtname.Text, txtpassword.Text,txtemail.Text,comboquestion.Text,txtanswer.Text,comboclass.Text);
            MessageBox.Show("User Registered");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtanswer_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtname_OnValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtname.Text)) // This will prevent exception when textbox is empty   
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtname.Text, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Enter Valid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtname.Text.Remove(txtname.Text.Length - 1);
                    txtname.Text = "";
                    txtname.Focus();
                }
            }
        }

        private void comboclass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboquestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
