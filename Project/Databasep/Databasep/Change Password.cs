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
    public partial class Change_Password : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=system;Password=ali;Unicode=True");
        public Change_Password()
        {
            InitializeComponent();
        }

        private void brnAddUser_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter cmd1 = new OleDbDataAdapter("select password from HR.login where user_id='" + txtuserid.Text + "' ", con);


            DataTable dt = new DataTable();
            cmd1.Fill(dt);
            string password = dt.Rows[0][0].ToString();
            if (password.Equals(txtoldpass.Text.ToString()))
            {

                con.Open();
                OleDbCommand cmd = new OleDbCommand("update HR.login set password='" + txtpass.Text + "' where user_id='" + txtuserid.Text + "' and password='" + txtoldpass.Text + "' and '" + txtpass.Text + "'='" + txtcnfrmpass.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Changed Successfully");
            }
            else {
                MessageBox.Show("Old Password not found");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
