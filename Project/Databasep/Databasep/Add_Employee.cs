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
    public partial class Add_Employee : Form
    {
        Person obj = new Person();
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try {
                
                var srv = new Personservices();
                if (!string.IsNullOrEmpty(txteno.Text.ToString()) && !string.IsNullOrEmpty(txtemname.Text.ToString()) && !string.IsNullOrEmpty(txtemsal.Text.ToString()))
                {
                    obj.emp_nam = txtemname.Text.ToString();
                    obj.emp_dob = txtemdob.Text.ToString();
                    obj.emp_qua = txtemqua.Text.ToString();
                    obj.emp_no = txteno.Text.ToString();
                    string q = txtemsal.Text.ToString();
                    obj.emp_sal = Convert.ToDouble(q);
                    obj.emp_cit =txtemcit.Text.ToString();
                    obj.emp_des = txtemdes.Text.ToString();
                    obj.emp_add = txtemadd.Text.ToString();
                    obj.emp_joi = txtemjoi.Text.ToString();
                    string s= txtempho.Text.ToString();
                    obj.emp_ph = Convert.ToDouble(s);
                    srv.addemployee(obj);
                    MessageBox.Show("Data Entered Successfully");

                }
                else {

                    MessageBox.Show("Enter data in all mandatory fields");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            obj.emp_sex = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            obj.emp_sex = "Female";
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            add_employee1 ae = new add_employee1();
            ae.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            add_employee1 ae = new add_employee1();
            ae.Show();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            add_employee1 ae = new add_employee1();
            ae.Show();
            this.Hide();
        }
    }
}
