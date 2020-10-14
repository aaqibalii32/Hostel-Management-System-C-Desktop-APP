using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databasep
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confirm_admin ca = new confirm_admin();
            ca.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password chn = new Change_Password();
            chn.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Fees f = new Fees();
            f.Show();

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Status s = new Status();
            s.Show();

        }

        private void leaveMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leave_Message lm = new Leave_Message();
            lm.Show();

        }

        private void showMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Message sm = new Show_Message();
            sm.Show();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Add_Employee ae = new Add_Employee();
            ae.Show();

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Add_Visitor av = new Add_Visitor();
            av.Show();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Display d = new Display();
            d.Show();
        }
    }
}
