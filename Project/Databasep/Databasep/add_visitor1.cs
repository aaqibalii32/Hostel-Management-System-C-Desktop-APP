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
    public partial class add_visitor1 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=system;Password=ali;Unicode=True");
        public add_visitor1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Add_Visitor av = new Add_Visitor();
            av.Show();
            this.Hide();
        }

        private void datagridreg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void brnAddUser_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbDataAdapter cmd = new OleDbDataAdapter("select * from HR.VISITOR_INFO ", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            datagridreg.DataSource = dt;
            con.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete from HR.VISITOR_INFO where roomno='" + txtrmno.Text + "' and visname='"+txtvisname.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            brnAddUser_Click(null, null);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtrmno.Text.ToString()) && !string.IsNullOrEmpty(txtvisname.Text.ToString()))
            {
                con.Open();
                OleDbDataAdapter cmd1 = new OleDbDataAdapter("select * from HR.VISITOR_INFO where roomno='" + txtrmno.Text + "' and visname='" + txtvisname.Text + "' ", con);
                DataTable dt1 = new DataTable();
                cmd1.Fill(dt1);
                datagridreg.DataSource = dt1;
                con.Close();
            }
            else if (!string.IsNullOrEmpty(txtrmno.Text.ToString()))
            {
                con.Open();
                OleDbDataAdapter cmd2 = new OleDbDataAdapter("select * from HR.VISITOR_INFO where roomno='" + txtrmno.Text + "' ", con);
                DataTable dt2 = new DataTable();
                cmd2.Fill(dt2);
                datagridreg.DataSource = dt2;
                con.Close();
            }
            else
            {
                con.Open();
                OleDbDataAdapter cmd3 = new OleDbDataAdapter("select * from HR.VISITOR_INFO where visname='" + txtvisname.Text + "' ", con);
                DataTable dt3 = new DataTable();
                cmd3.Fill(dt3);
                datagridreg.DataSource = dt3;
                con.Close();

            }
            
        }
    }
}
