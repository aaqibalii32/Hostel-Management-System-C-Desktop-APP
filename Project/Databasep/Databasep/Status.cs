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
    public partial class Status : Form
    {
        Person obj = new Person();
        public Status()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try { 
            var srv = new Personservices();
            if (!string.IsNullOrEmpty(txtRmNo.Text.ToString()) && !string.IsNullOrEmpty(txtdesc.Text.ToString()) && !string.IsNullOrEmpty(txtstdname.Text.ToString()) && !string.IsNullOrEmpty(txtstdno.Text.ToString()) )
            {
               
                obj.s_rmno = txtRmNo.Text.ToString();
                obj.s_stdname = txtstdname.Text.ToString();
                string j = txtstdno.Text.ToString();
                obj.s_stdno = Convert.ToDouble(j);
                obj.s_desc = txtdesc.Text.ToString();

                    obj.s_in = timein.Text.ToString();
                obj.s_out = timeout.Text.ToString();
                obj.s_to = to.Text.ToString();
                obj.s_from = from.Text.ToString();
                    obj.s_leavetype = leavetype.selectedValue.ToString();
                srv.addstatus(obj);
                MessageBox.Show("Data Entered Successfully");

            }

            else
            {
                MessageBox.Show("Enter data in mandatory fields");
            } }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            obj.s_status = "In";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            obj.s_status = "Out";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Check_Status cs = new Check_Status();
            cs.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
