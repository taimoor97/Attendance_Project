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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
        
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            studentregister frm = new studentregister();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadmin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click_1(object sender, EventArgs e)
        {
            studentregister frm = new studentregister();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void btnadmin_Click_1(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }
    }
}
