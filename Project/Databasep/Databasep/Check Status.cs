using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Databasep
{
    public partial class Check_Status : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=system;Password=ali;Unicode=True");
        public Check_Status()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Status s = new Status();
            s.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try {
                OleDbDataAdapter cmd = new OleDbDataAdapter("select status from HR.status1 where roomno='" + txtrmno.Text + "' and studentnm = '" + txtstdname.Text + "'", con);

                DataTable dt = new DataTable();

                cmd.Fill(dt);
                string status = dt.Rows[0][0].ToString();
                OleDbDataAdapter cmd1 = new OleDbDataAdapter("select description from HR.status1 where roomno='" + txtrmno.Text + "' and studentnm = '" + txtstdname.Text + "'", con);

                DataTable dt1 = new DataTable();

                cmd1.Fill(dt1);
                string desc= dt1.Rows[0][0].ToString();
                txtstatus.Text = status;
                txtdesc.Text = desc;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
