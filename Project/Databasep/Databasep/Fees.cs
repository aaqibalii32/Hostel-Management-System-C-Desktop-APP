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
    public partial class Fees : Form
    {
        Person obj = new Person();
        public Fees()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                
                var srv = new Personservices();
                if (!string.IsNullOrEmpty(txtreno.Text.ToString()) && !string.IsNullOrEmpty(txtreceviedby.Text.ToString()) && !string.IsNullOrEmpty(txtstdno.Text.ToString()) && !string.IsNullOrEmpty(txtpaidfee.Text.ToString()) && !string.IsNullOrEmpty(txttotalfee.Text.ToString()))
                {
                    string s = txtreno.Text.ToString();
                    obj.f_receipt = Convert.ToDouble(s);
                    string f = txtstdno.Text.ToString();
                    obj.f_stdno = Convert.ToDouble(f);
                    string g = txtded.Text.ToString();
                    obj.f_ded = Convert.ToDouble(g);
                    string h = txttotalfee.Text.ToString();
                    obj.f_total = Convert.ToDouble(h);
                    string j = txtpaidfee.Text.ToString();
                    obj.f_paid = Convert.ToDouble(j);
                    obj.f_received = txtreceviedby.Text.ToString();
                    obj.f_date = dateTimePicker1.Text.ToString();
                    srv.addfees(obj);
                    MessageBox.Show("Data Entered Successfully");

                }

                else
                {
                    MessageBox.Show("Enter data in mandatory fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            obj.f_type = "Monthly";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            obj.f_type = "Yearly";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Fees1 f = new Fees1();
            f.Show();
            this.Hide();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Fees1 f = new Fees1();
            f.Show();
            this.Hide();

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Fees1 f = new Fees1();
            f.Show();
            this.Hide();

        }
    }
}
