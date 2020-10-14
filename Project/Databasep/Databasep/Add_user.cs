using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Databasep.Repositry;
namespace Databasep
{
    public partial class Add_user : Form
    {
        public Add_user()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void brnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = new Person();
                var srv = new Personservices();
                if (!string.IsNullOrEmpty(txtuserid.Text.ToString()) && !string.IsNullOrEmpty(txtpass.Text.ToString()) && !string.IsNullOrEmpty(txthint.Text.ToString()) && !string.IsNullOrEmpty(txtconfrmpass.Text.ToString()))
                {
                    obj.adduser_id = txtuserid.Text.ToString();
                    obj.addPass = txtpass.Text.ToString();
                    obj.addcnfrmPass = txtconfrmpass.Text.ToString();
                    obj.addhint = txthint.Text.ToString();
                    srv.adduser(obj);
                    MessageBox.Show("User Added Successfully");
                    obj.adduser_id = "";
                    obj.addPass = "";
                    obj.addcnfrmPass = "";
                    obj.addhint = "";
                }
                else
                {
                    MessageBox.Show("Enter values in all fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
