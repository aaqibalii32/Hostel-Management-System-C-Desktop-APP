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
    public partial class confirm_admin : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=system;password=ali;Unicode=True");
        public confirm_admin()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void brnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                
                OleDbDataAdapter cmd = new OleDbDataAdapter("select count(*) from HR.admin where pass = '" + txtuserid.Text + "'", connection);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Add_user j = new Add_user();
                    this.Hide();
                    j.Show();
                   
                }
                else
                {
                    MessageBox.Show("Invalid ID/Password");
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}
    }
}
