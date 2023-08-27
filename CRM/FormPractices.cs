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
    public partial class FormPractices : Form
    {
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataReader reader;
        public FormPractices()
        {
            InitializeComponent();
            //populate the dataviewgrid
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @" SELECT Practice.ID, Practice.[Practice Name], CCG.[CCG Name], Practice.[Postcode] FROM Practice INNER JOIN CCG";
            cmd.CommandText += @" ON Practice.[CCG ID] = CCG.ID WHERE Practice.[CCG ID] = CCG.ID; ";
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvPractices.DataSource = bindingSource;
            dgvPractices.Columns[0].Width = 25;
            dgvPractices.Columns[1].Width = 200;
            dgvPractices.Columns[2].Width = 130;
            dgvPractices.Columns[3].Width = 200;
            con.Close();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
