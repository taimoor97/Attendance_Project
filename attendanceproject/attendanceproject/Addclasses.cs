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
    public partial class Addclasses : Form
    {
        public Addclasses()
        {
            InitializeComponent();
        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Adminpage frm = new Adminpage();
            frm.Show();
            this.Hide();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            taimoor_net.Service1 ser = new taimoor_net.Service1();
            bool chk = true;
            bool spec = true;
            ser.addclass(chk,spec,comboclass.Text, txtsubject.Text);
            BindingSource source = new BindingSource();
            source.DataSource = ser.d();
            dataGV.DataSource = source;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            for ( int i = dataGV.Rows.Count-1; i>= 0; i--)
            {
                bool delete = (bool)dataGV.Rows[i].Cells[1].Value;
                if (delete == true)
                {
                    bool a = false;
                    taimoor_net.Service1 ser = new taimoor_net.Service1();
                    ser.delete(i,a);


                }
            }
        }

      
    }
           
    
}
