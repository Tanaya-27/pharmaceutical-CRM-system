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
    public partial class FormSamples : Form
    {
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataReader reader;
        Sample currentSample;
        public FormSamples()
        {
            InitializeComponent();
            //populate the dataviewgrid
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @" SELECT Sample.ID, Contact.[Contact Name], Sample.[Creation Date], Sample.Status FROM Sample INNER JOIN Contact";
            cmd.CommandText += @" ON Sample.[Contact ID] = Contact.ID WHERE Sample.[Contact ID] = Contact.ID  ";
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvSamples.DataSource = bindingSource;
            dgvSamples.Columns[0].Width = 25;
            dgvSamples.Columns[1].Width = 125;
            dgvSamples.Columns[2].Width = 100;
            dgvSamples.Columns[3].Width = 100;
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

            //filling combo box options
            List<string> prodNames = new List<string>();
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT [Product Name] FROM Product";
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                prodNames.Add(reader.GetString(0));
            }
            foreach (var item in prodNames)
            {
                comboProduct.Items.Add(item);
            }
            con.Close();


            //instantiating current sample
            int contIdEntered = 0;
            currentSample = new Sample(contIdEntered, "Placed");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAddSample_Click(object sender, EventArgs e)
        {
            string contNameEntered = comboContName.Text;
            //checking that the contact entered exists
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

                currentSample.AddSample(contIdEntered, "Placed");
                MessageBox.Show("Sample added successfully. Total: £" + currentSample.CalcTotal());

                //REMOVE TEXT FROM TXT BOXES
                comboContName.Text = "";
                //refresh
                picRefresh_Click(sender, e);
            }
            else
            {
                con.Close();
                MessageBox.Show("Please type an existing contact name");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string contNameSelected = dgvSamples.SelectedCells[1].Value.ToString();

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

            object selectedID = dgvSamples.SelectedCells[0].Value;
            string statusSelected = dgvSamples.SelectedCells[3].Value.ToString();
            string updatedStatus = comboStatus.Text;

            currentSample = new Sample(contIdSelected, statusSelected);
            currentSample.EditSample(updatedStatus, selectedID);
            MessageBox.Show("Sample " + selectedID + " has been updated.");

            //refresh
            picRefresh_Click(sender, e);
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSamples newFormSamples = new FormSamples();
            newFormSamples.Show();
        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            int productID;

            //checking that the product entered exists
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader reader;
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT [ID] FROM Product WHERE [Product Name] = @prd";
            cmd.Parameters.AddWithValue("@prd", comboProduct.Text);
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                productID = Convert.ToInt32(reader[0]);
                con.Close();
                int quantity = Convert.ToInt32(nudQuantity.Text);
                //finding out price of each item for running total
                OleDbConnection con2;
                OleDbCommand cmd2;
                OleDbDataReader reader2;
                con2 = new OleDbConnection();
                con2.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd2 = new OleDbCommand();
                cmd2.Connection = con2;
                cmd2.CommandText = @"SELECT Price FROM Product WHERE [ID] = @pr";
                cmd2.Parameters.AddWithValue("@pr", productID);
                con2.Open();
                reader2 = cmd2.ExecuteReader();
                reader2.Read();
                decimal price = Convert.ToDecimal(reader2[0]);
                con2.Close();

                OleDbConnection con3;
                OleDbCommand cmd3;
                OleDbDataReader reader3;
                con3 = new OleDbConnection();
                con3.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd3 = new OleDbCommand();
                cmd3.Connection = con3;
                cmd3.CommandText = @"SELECT [Product Name] FROM Product WHERE [ID] = @pr";
                cmd3.Parameters.AddWithValue("@pr", productID);
                con3.Open();
                reader3 = cmd3.ExecuteReader();
                reader3.Read();
                string productName = Convert.ToString(reader3[0]);
                con3.Close();


                string itemSummary = productName + " * " + quantity;
                SampleItem sampleItem = new SampleItem(productID, 0, quantity, itemSummary, price); //ID does not matter until wiritng to database
                currentSample.addItem(sampleItem);
                BindingList<SampleItem> currentSampleItems = new BindingList<SampleItem>(currentSample.listOfSampleItems);
                lsbBasket.DataSource = currentSampleItems;
                lsbBasket.DisplayMember = "SampleItemSummary";
            }
            else
            {
                con.Close();
                MessageBox.Show("Please type an existing product name");
            }

        }
    }
}
