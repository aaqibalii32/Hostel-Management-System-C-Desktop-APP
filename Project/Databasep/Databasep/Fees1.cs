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
    public partial class Fees1 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=system;Password=ali;Unicode=True");
        public Fees1()
        {
            InitializeComponent();
        }

        private void brnAddUser_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter cmd = new OleDbDataAdapter("select * from HR.Fees ", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            datagridreg.DataSource = dt;
            con.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete from HR.Fees where receiptno='" + txtreceiptno.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            brnAddUser_Click(null, null);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {


            con.Open();
            OleDbDataAdapter cmd = new OleDbDataAdapter("select * from HR.Fees where receiptno='" + txtreceiptno.Text + "' ", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            datagridreg.DataSource = dt;
            con.Close();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Fees f = new Fees();
            f.Show();
            this.Hide();
        }
    }
}
