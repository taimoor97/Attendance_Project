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
    public partial class Adminpage : Form
    {
        public Adminpage()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            teachersdata frm = new teachersdata();
            frm.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            homepage frm = new homepage();
            frm.Show();
            this.Hide();

        }

        private void btnclasses_Click(object sender, EventArgs e)
        {
            Addclasses frm = new Addclasses();
            frm.Show();
            this.Hide();
        }
    }
}
