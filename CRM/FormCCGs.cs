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

namespace FontusHealthCRM
{
    public partial class FormCCGs : Form
    {
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataReader reader;
        public FormCCGs()
        {
            InitializeComponent();
            //populate the dataviewgrid
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT ID, [CCG Name], [Responsible HDE], [CCG Region] FROM CCG";
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvCCG.DataSource = bindingSource;
            dgvCCG.Columns[0].Width = 25;
            dgvCCG.Columns[1].Width = 230;
            dgvCCG.Columns[2].Width = 100;
            dgvCCG.Columns[3].Width = 200;
            con.Close();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCCG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
