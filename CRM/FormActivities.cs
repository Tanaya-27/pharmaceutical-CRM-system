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
using System.Text.RegularExpressions;

namespace FontusHealthCRM
{
    public partial class FormActivities : Form
    {
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataReader reader;

        Activity newActivity;
        Activity currentActivity;
        public FormActivities()
        {
            InitializeComponent();
            //populate the dataviewgrid
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @" SELECT Activity.ID, Contact.[Contact Name], Activity.[Date Of], Activity.[Date Created], Activity.Type, Activity.Notes ";
            cmd.CommandText += @" FROM Activity INNER JOIN Contact ON Activity.[Contact ID] = Contact.ID WHERE Activity.[Contact ID] = Contact.ID;";
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvActivities.DataSource = bindingSource;
            dgvActivities.Columns[0].Width = 25;
            dgvActivities.Columns[1].Width = 125;
            dgvActivities.Columns[2].Width = 100;
            dgvActivities.Columns[3].Width = 100;
            dgvActivities.Columns[4].Width = 100;
            dgvActivities.Columns[5].Width = 200;
            con.Close();

            //filling combo box options
            List<string> contNames = new List<string>();
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT [Contact Name] FROM Contact";
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                contNames.Add(reader.GetString(0));
            }
            foreach (var item in contNames)
            {
                comboContName.Items.Add(item);
            }
            con.Close();

        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            if(comboContName.Text != "" && dtpDateOf.Text != "" && txtType.Text != "")
            {
                string contNameEntered = comboContName.Text;

                OleDbConnection con;
                OleDbCommand cmd;
                OleDbDataReader reader;
                con = new OleDbConnection();
                con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"SELECT ID FROM Contact WHERE [Contact Name] = @cn";
                cmd.Parameters.AddWithValue("@cn", contNameEntered);
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    int contIdEntered = Convert.ToInt32(reader[0]);
                    con.Close();

                    string dateOfEntered = dtpDateOf.Text;
                    string typeEntered = txtType.Text;
                    string notesEntered = txtNotes.Text;

                    newActivity = new Activity(contIdEntered, dateOfEntered, typeEntered, notesEntered);

                    newActivity.AddActivity(contIdEntered, dateOfEntered, typeEntered, notesEntered);
                    MessageBox.Show("Activity added successfully");

                    //REMOVE TEXT FROM TXT BOXES
                    comboContName.Text = "";
                    dtpDateOf.Text = "";
                    txtType.Text = "";
                    txtNotes.Text = "";

                    //refresh
                    picRefresh_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Please type an existing contact name");
                }
            }

            else
            {
                MessageBox.Show("Please type into the given fields");
            }

        }

        private void btnEditActivity_Click(object sender, EventArgs e)
        {
            string contNameSelected = dgvActivities.SelectedCells[1].Value.ToString();
            string dateOfSelected = dgvActivities.SelectedCells[2].Value.ToString();
            string typeSelected = dgvActivities.SelectedCells[4].Value.ToString();
            string notesSelected = dgvActivities.SelectedCells[5].Value.ToString();
            MessageBox.Show("Please update as needed in the text boxes below; click 'OK' to update successfully.");
            comboContName.Text = contNameSelected;
            dtpDateOf.Text = dateOfSelected;
            txtType.Text = typeSelected;
            txtNotes.Text = notesSelected;
            btnOK.Enabled = true;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string contNameSelected = comboContName.Text;

            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader reader;
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT ID FROM Contact WHERE [Contact Name] = @cn";
            cmd.Parameters.AddWithValue("@cn", contNameSelected);
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            int contIdSelected = Convert.ToInt32(reader[0]);
            con.Close();

            object selectedID = dgvActivities.SelectedCells[0].Value;
            string dateOfSelected = dtpDateOf.Text;
            string typeSelected = txtType.Text;
            string notesSelected = txtNotes.Text;

            currentActivity = new Activity(Convert.ToInt32(contIdSelected), dateOfSelected, typeSelected, notesSelected);
            currentActivity.EditActivity(Convert.ToInt32(contIdSelected), dateOfSelected, typeSelected, notesSelected, selectedID);
            MessageBox.Show("Activity "+selectedID+" has been updated.");

            //REMOVE TEXT FROM TXT BOXES
            comboContName.Text = "";
            dtpDateOf.Text = "";
            txtType.Text = "";
            txtNotes.Text = "";

            //Refresh!!
            picRefresh_Click(sender, e);


        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            FormActivities newFormActivities = new FormActivities();
            newFormActivities.Show();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
