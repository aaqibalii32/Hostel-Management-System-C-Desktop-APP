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
    public partial class Forgot_Password : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=system;Password=ali;Unicode=True");
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void brnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataAdapter cmd = new OleDbDataAdapter("select password from HR.login where user_id='" + txtuserid.Text + "' and hint = '" + txthint.Text + "'", con);
                

                DataTable dt = new DataTable();
                cmd.Fill(dt);
                string password = dt.Rows[0][0].ToString();
                OleDbDataAdapter cmd1 = new OleDbDataAdapter("select count(*) from HR.login where user_id='" + txtuserid.Text + "' and hint = '" + txthint.Text + "'", con);
                DataTable c = new DataTable();
                cmd1.Fill(c);
                if (c.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Your Password Is: "+"\""+ password+"\"");
                    
                }
                else
                {
                    MessageBox.Show("Invalid ID/Hint");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid ID/Hint");
            }




        }
    }
}
