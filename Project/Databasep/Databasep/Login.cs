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
    public partial class formlogin : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=system;Password=ali;Unicode=True");
        public formlogin()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataAdapter cmd = new OleDbDataAdapter("select count (*) from HR.login where user_id='" + txtuser.Text + "' and password = '" + txtpassword.Text + "'", con);
               
                DataTable dt = new DataTable();
                cmd.Fill(dt);
               if(dt.Rows[0][0].ToString()=="1")
                {
                    Main_Window j = new Main_Window();
                    this.Hide();
                    j.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid ID/Password");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
        }

        private void formlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
