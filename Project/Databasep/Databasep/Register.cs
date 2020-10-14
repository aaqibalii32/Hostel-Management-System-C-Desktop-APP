using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Databasep.Repositry;
using System.Windows.Forms;

namespace Databasep
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            try
            { var obj = new Person();
                var srv = new Personservices();
                if (!string.IsNullOrEmpty(StdNo.Text.ToString()) && !string.IsNullOrEmpty(StdName.Text.ToString()) && !string.IsNullOrEmpty(RmNo.Text.ToString()))
                {
                    string s = StdNo.Text.ToString();
                    obj.SNo = Convert.ToDouble(s);
                    obj.Sname = StdName.Text.ToString();
                    obj.RmNo = RmNo.Text.ToString();
                    obj.date = DateTime.Now.ToString();
                    obj.Dept = UniDept.Text.ToString();
                    obj.floor = HFloor.Text.ToString();
                    obj.B_dt = SDob.Text.ToString();
                    obj.B_group = Bgrp.Text.ToString();
                    obj.Institute = InsName.Text.ToString();
                    obj.GName = GName.Text.ToString();
                    obj.GRelation = GRelation.Text.ToString();
                    obj.GOccup = GOccup.Text.ToString();

                    obj.email = emai.Text.ToString();
                    obj.GAdd = GAddress.Text.ToString();
                    obj.address = SAddress.Text.ToString();
                    string a;
                    a = SPh.Text.ToString();
                    obj.Ph = Convert.ToDouble(a);
                    string b;
                    b = SMobile.Text.ToString();
                    obj.mobile = Convert.ToDouble(b);
                    string c;
                    c = Gph.Text.ToString();
                    obj.Gphone = Convert.ToDouble(c);
                    srv.addperson(obj);
                    MessageBox.Show("Data Entered Successfully");
                    obj.SNo = 0;
                    obj.Sname = "";
                    obj.RmNo = "";
                    obj.date = "";
                    obj.Dept = "";
                    obj.floor = "";
                    obj.B_dt = "";
                    obj.B_group = "";
                    obj.Institute = "";
                    obj.GName = "";
                    obj.GRelation = "";
                    obj.GOccup = "";

                    obj.email = "";
                    obj.GAdd = "";
                    obj.address = "";

                    a = "";
                    obj.Ph = 0;
                    
                    b = "";
                    obj.mobile = 0;

                    c = "";
                    obj.Gphone = 0;

                }
                else {
                    MessageBox.Show("Enter the values in mandatory fields");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SUD s = new SUD();
            s.Show();
            this.Hide();
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            SUD s = new SUD();
            s.Show();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            SUD s = new SUD();
            s.Show();
            this.Hide();
        }
    }
}
