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
    public partial class Add_Visitor : Form
    {
        Person obj = new Person();
        public Add_Visitor()
        {
            InitializeComponent();
        }

        private void Add_Visitor_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try {
              
                var srv = new Personservices();
                if (!string.IsNullOrEmpty(RmNo.Text.ToString()) && !string.IsNullOrEmpty(txtstdnm.Text.ToString()) && !string.IsNullOrEmpty(txtvisname.Text.ToString()))
                {

                    obj.vis_rm = RmNo.Text.ToString();
                    obj.vis_date = vis_date.Text.ToString();
                    obj.vis_stdnt = txtstdnm.Text.ToString();
                    obj.vis_name = txtvisname.Text.ToString();
                    obj.vis_relation = txtvstrelation.Text.ToString();
                    obj.vis_timein = timein.Text.ToString();
                    obj.vis_timeout = timeout.Text.ToString();
                    obj.vis_add = txtvisaddress.Text.ToString();
                    obj.vis_city = txtcity.Text.ToString();

                    string s = txtvisphone.Text.ToString();
                    obj.vis_ph = Convert.ToDouble(s);
                    srv.addvisitor(obj);
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
            obj.vis_sex = "Male";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            obj.vis_sex = "Female";
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            add_visitor1 av = new add_visitor1();
            av.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            add_visitor1 av = new add_visitor1();
            av.Show();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            add_visitor1 av = new add_visitor1();
            av.Show();
            this.Hide();
        }
    }
}
