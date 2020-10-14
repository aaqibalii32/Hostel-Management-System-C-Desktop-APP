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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=system;Password=ali;Unicode=True");
        private void btndisplay_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from HR.register",con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            displayDataGrid.DataSource = dt;
           
            con.Close();
        }

        private void displayDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
