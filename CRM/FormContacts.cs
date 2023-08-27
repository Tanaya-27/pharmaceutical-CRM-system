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
    public partial class FormContacts : Form
    {
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataReader reader;
        static OleDbConnection con2;
        static OleDbCommand cmd2;
        static OleDbDataReader reader2;

        public FormContacts()
        {
            InitializeComponent();
            //populate the dataviewgrid
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @" SELECT Contact.ID, Contact.[Contact Name], Practice.[Practice Name], Contact.[Position], Contact.Email ";
            cmd.CommandText += @" FROM Contact INNER JOIN Practice ON Contact.[Practice ID] = Practice.ID WHERE Contact.[Practice ID] = Practice.ID";
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvContacts.DataSource = bindingSource;
            dgvContacts.Columns[0].Width = 25;
            dgvContacts.Columns[1].Width = 132;
            dgvContacts.Columns[2].Width = 125;
            dgvContacts.Columns[3].Width = 100;
            dgvContacts.Columns[4].Width = 175;
            con.Close();


        }

        private void FormContacts_Load(object sender, EventArgs e)
        {

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //insights
        //when mouse is over cell

        private void dgvContacts_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvContacts[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightBlue;
                dgvContacts.CurrentCell = dgvContacts.Rows[e.RowIndex].Cells[0];
                int contactID = Convert.ToInt32(dgvContacts.CurrentCell.Value);

                //num of samples + amount spent
                List<int> samples = new List<int>();
                decimal amountSpent = 0;
                con = new OleDbConnection();
                con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"SELECT ID FROM Sample WHERE [Contact ID] = @cid";
                cmd.Parameters.AddWithValue("@cid", contactID);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //for num of samples
                    samples.Add(reader.GetInt32(0));

                    //for amount spent
                    con2 = new OleDbConnection();
                    con2.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                    cmd2 = new OleDbCommand();
                    cmd2.Connection = con2;
                    cmd2.CommandText = @"SELECT SUM([Product].[Price]*[Sample Items].[Quantity]) FROM Product INNER JOIN [Sample Items] ON Product.[ID] = [Sample Items].[Product ID] WHERE [Sample Items].[Sample ID] = @sid";
                    cmd2.Parameters.AddWithValue("@sid", Convert.ToString(reader.GetInt32(0)));
                    con2.Open();
                    reader2 = cmd2.ExecuteReader();
                    reader2.Read();
                    amountSpent += Convert.ToDecimal(reader2[0]);
                    con2.Close();

                    //for fav product
                    //loop foreach product??
                }
                con.Close();
                int numOfSamples = samples.Count();

                //most recent sample
                con = new OleDbConnection();
                con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"SELECT MAX(ID) FROM Sample HAVING [Contact ID] = @cid";
                cmd.Parameters.AddWithValue("@cid", contactID);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if(reader[0] != DBNull.Value)
                    {
                    int recentSampID = Convert.ToInt32(reader[0]);
                    }
                }
                con.Close();

                con = new OleDbConnection();
                con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"SELECT [Status] FROM Sample WHERE [Contact ID] = @cid";
                cmd.Parameters.AddWithValue("@cid", contactID);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                reader.Read();
                string recentSampStat = Convert.ToString(reader[0]);
                }
                con.Close();

                //num of activities
                List<int> activities = new List<int>();
                con = new OleDbConnection();
                con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"SELECT ID FROM Activity WHERE [Contact ID] = @cid";
                cmd.Parameters.AddWithValue("@cid", contactID);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //for num of samples
                    activities.Add(reader.GetInt32(0));
                }
                con.Close();
                int numOfActivities = activities.Count();

                //most recent(ly created?) activity
                int recentActivID = 0;
                string recentActivDate = "";
                string recentActivType = "";
                string recentActivNotes = "";
                con = new OleDbConnection();
                con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"SELECT MAX(ID) FROM Activity HAVING [Contact ID] = @cid";
                cmd.Parameters.AddWithValue("@cid", contactID);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)//need to make sure no error occurs when contact has no activities
                {
                    reader.Read();
                    if (reader[0] != DBNull.Value)
                    {
                        recentActivID = Convert.ToInt32(reader[0]);
                    }

                }
                con.Close();
                con = new OleDbConnection();
                con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"SELECT [Date Of], [Type], [Notes] FROM Activity WHERE [Contact ID] = @cid";
                cmd.Parameters.AddWithValue("@cid", contactID);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    recentActivDate = Convert.ToString(reader[0]);
                    recentActivType = Convert.ToString(reader[1]);
                    recentActivNotes = Convert.ToString(reader[2]);
                }
                con.Close();

                //favourite product (?)

                lblContInsights.Text = "Number of Samples: " + numOfSamples + "\r\rTotal Spent: £" + amountSpent + "\r\rNumber of Activities: " + numOfActivities + "\r\rMost Recent Activity:\r   ID - " + recentActivID + "\r   Date - " + recentActivDate + "\r   Type - " + recentActivType + "\r   Notes - " + recentActivNotes;
            }
        }

        //when mouse is leaving cell
        private void dgvContacts_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvContacts[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                lblContInsights.Text = "HOVER TO VIEW INSIGHTS";
            }
        }
    }
}
