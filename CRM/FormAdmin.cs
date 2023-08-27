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
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace FontusHealthCRM
{
    public partial class FormAdmin : Form
    {
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataReader reader;
        static OleDbConnection con2;
        static OleDbCommand cmd2;
        static OleDbDataReader reader2;
        string selectedTable = "";
        
        CCG newCCG;
        CCG currentCCG;
        Practice newPractice;
        Practice currentPractice;
        Contact newContact;
        Contact currentContact;
        Sample currentSample;
        Activity currentActivity;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnCCGs_Click(object sender, EventArgs e)
        {
            selectedTable = "CCG";
            lblSelectedTable.Text = selectedTable;
            //populate the dataviewgrid
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @" SELECT ID, [CCG Name], [Responsible HDE], [CCG Region] FROM CCG;";
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvSelectedTable.DataSource = bindingSource;
            dgvSelectedTable.Columns[0].Width = 25;
            dgvSelectedTable.Columns[1].Width = 230;
            dgvSelectedTable.Columns[2].Width = 100;
            dgvSelectedTable.Columns[3].Width = 200;
            con.Close();
            //
            btnCreateNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnPractices_Click(object sender, EventArgs e)
        {
            selectedTable = "Practice";
            lblSelectedTable.Text = selectedTable;
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
            dgvSelectedTable.DataSource = bindingSource;
            dgvSelectedTable.Columns[0].Width = 25;
            dgvSelectedTable.Columns[1].Width = 200;
            dgvSelectedTable.Columns[2].Width = 130;
            dgvSelectedTable.Columns[3].Width = 200;
            con.Close();
            //
            btnCreateNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            selectedTable = "Contact";
            lblSelectedTable.Text = selectedTable;
            //populate the dataviewgrid
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @" SELECT Contact.ID, Contact.[Contact Name], Practice.[Practice Name], Contact.[Position], Contact.Email ";
            cmd.CommandText += @" FROM Contact INNER JOIN Practice ON Contact.[Practice ID] = Practice.ID WHERE Contact.[Practice ID] = Practice.ID;";
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvSelectedTable.DataSource = bindingSource;
            dgvSelectedTable.Columns[0].Width = 25;
            dgvSelectedTable.Columns[1].Width = 150;
            dgvSelectedTable.Columns[2].Width = 150;
            dgvSelectedTable.Columns[3].Width = 123;
            dgvSelectedTable.Columns[4].Width = 175;
            con.Close();
            //
            btnCreateNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            selectedTable = "Activity";
            lblSelectedTable.Text = selectedTable;
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
            dgvSelectedTable.DataSource = bindingSource;
            dgvSelectedTable.Columns[0].Width = 25;
            dgvSelectedTable.Columns[1].Width = 125;
            dgvSelectedTable.Columns[2].Width = 100;
            dgvSelectedTable.Columns[3].Width = 100;
            dgvSelectedTable.Columns[4].Width = 100;
            dgvSelectedTable.Columns[5].Width = 200;
            con.Close();
            //
            btnCreateNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = true;
        }

        private void btnSamples_Click(object sender, EventArgs e)
        {
            selectedTable = "Sample";
            lblSelectedTable.Text = selectedTable;
            //populate the dataviewgrid
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @" SELECT Sample.ID, Contact.[Contact Name], Sample.[Creation Date], Sample.Status FROM Sample INNER JOIN Contact";
            cmd.CommandText += @" ON Sample.[Contact ID] = Contact.ID WHERE Sample.[Contact ID] = Contact.ID;";
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvSelectedTable.DataSource = bindingSource;
            dgvSelectedTable.Columns[0].Width = 25;
            dgvSelectedTable.Columns[1].Width = 125;
            dgvSelectedTable.Columns[2].Width = 100;
            dgvSelectedTable.Columns[3].Width = 100;
            con.Close();
            btnCreateNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteYN = MessageBox.Show("Are you sure you want to delete the selected row?", "Delete Row", MessageBoxButtons.YesNo);
            if (deleteYN == DialogResult.Yes)
            {
                object selectedID = dgvSelectedTable.SelectedCells[0].Value;
                if(selectedTable == "CCG")
                {
                    currentCCG = new CCG("", "", "");
                    currentCCG.DeleteCCG(selectedID);
                }
                else if (selectedTable == "Practice")
                {
                    currentPractice = new Practice("", 0, "");
                    currentPractice.DeletePractice(selectedID, false);
                }
                else if(selectedTable == "Contact")
                {
                    currentContact = new Contact("", 0, "", "");
                    currentContact.DeleteContact(selectedID, false);
                }
                else if (selectedTable == "Activity")
                {
                    currentActivity = new Activity(0, "", "", "");
                    currentActivity.DeleteActivity(selectedID, false);
                }
                else if (selectedTable == "Sample")
                {
                    currentSample = new Sample(0, "");
                    currentSample.DeleteSample(selectedID, false);
                }
                else //for user
                {
                    con2 = new OleDbConnection();
                    con2.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                    cmd2 = new OleDbCommand();
                    cmd2.Connection = con2;
                    cmd2.CommandText = string.Format(@"DELETE FROM {0} WHERE ID = @id", "[" + selectedTable + "]");
                    cmd2.Parameters.AddWithValue("@id", selectedID);
                    con2.Open();
                    reader2 = cmd2.ExecuteReader();
                    con2.Close();
                }
                MessageBox.Show("Row Deleted Successfully");
                //refresh
                picRefresh_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Row Not Deleted");
            }

        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (selectedTable == "CCG")
            {
                //input boxes using the Visual Basic .NET runtime library
                string CCGName = Interaction.InputBox("Enter CCG Name: ", "CCG: Name", "Enter Name");
                string HDE = Interaction.InputBox("Enter Responsible HDE: ", "CCG: HDE", "Enter Name");
                string CCGRegion = Interaction.InputBox("Enter CCG Region: ", "CCG: Region", "Enter Region");

                if (CCGName != "" && HDE != "" && CCGRegion != "")
                {
                    newCCG = new CCG(CCGName, HDE, CCGRegion);
                    newCCG.AddCCG(CCGName, HDE, CCGRegion);
                    MessageBox.Show("CCG added successfully");
                    //refresh
                    btnCCGs_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Please type in all fields");
                }
            }
            else if (selectedTable == "Practice")
            {
                //input boxes using the Visual Basic .NET runtime library
                string pracName = Interaction.InputBox("Enter Practice Name: ", "Practice: Name", "Enter Name");
                string CCGName = Interaction.InputBox("Enter CCG Name: ", "Practice: CCG Name", "Enter Name");
                string pracAddress = Interaction.InputBox("Enter Practice Postcode: ", "Practice: Postcode", "e.g. AB1 2CD");


                if (CCGName != "" && pracName != "" && pracAddress != "") 
                {
                    if (Regex.Match(pracAddress, @"[A-Z]{1,2}\d{1,2} \d[A-Z][A-Z]").Success) //regEx to validate postcode
                    {
                        OleDbConnection con;
                        OleDbCommand cmd;
                        OleDbDataReader reader;
                        con = new OleDbConnection();
                        con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                        cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = @"SELECT ID FROM CCG WHERE [CCG Name] = @cn;";
                        cmd.Parameters.AddWithValue("@cn", CCGName);
                        con.Open();
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            int CCGIdEntered = Convert.ToInt32(reader[0]);
                            con.Close();
                            newPractice = new Practice(pracName, CCGIdEntered, pracAddress);
                            newPractice.AddPractice(pracName, CCGIdEntered, pracAddress);
                            MessageBox.Show("Practice added successfully");
                            //refresh
                            btnPractices_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Please type an existing CCG name");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please type a valid postcode");
                    }

                }
                else
                {
                    MessageBox.Show("Please type into all given fields");
                }
            }
            else if (selectedTable == "Contact")
            {
                //input boxes using the Visual Basic .NET runtime library
                string contactName = Interaction.InputBox("Enter Contact Name: ", "Contact: Name", "Enter Name");
                string pracName = Interaction.InputBox("Enter Practice Name: ", "Contact: Practice Name", "Enter Name");
                string contactPosition = Interaction.InputBox("Enter Contact Position: ", "Contact: Position", "Enter Position");
                string contactEmail = Interaction.InputBox("Enter Contact Email: ", "Contact: Email", "Enter Email Address");

                if (contactName != "" && pracName != "" && contactPosition != "" && contactEmail != "" )
                {
                    if (Regex.Match(contactEmail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success) //regEx to validate email address
                    {
                        OleDbConnection con;
                        OleDbCommand cmd;
                        OleDbDataReader reader;
                        con = new OleDbConnection();
                        con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                        cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = @"SELECT ID FROM Practice WHERE [Practice Name] = @pn;";
                        cmd.Parameters.AddWithValue("@pn", pracName);
                        con.Open();
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            int PracIdEntered = Convert.ToInt32(reader[0]);
                            con.Close();
                            newContact = new Contact(contactName, PracIdEntered, contactPosition, contactEmail);
                            newContact.AddContact(contactName, PracIdEntered, contactPosition, contactEmail);
                            MessageBox.Show("Contact added successfully");
                            //refresh
                            btnContacts_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Please type an existing Practice name");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please type a valid email address");
                    }

                }
                else
                {
                    MessageBox.Show("Please type into all given fields");
                }
            }
            else if (selectedTable == "User")
            {
                //create with just username (unique), generate temp password T3mporary
                //input boxes using the Visual Basic .NET runtime library
                string newUserName = Interaction.InputBox("Enter Username: ", "User: Username", "Enter Username");
                string jobTitle = Interaction.InputBox("Enter Job Title: ", "User: Job", "Enter Job"); 
                string tempPass = "T3mporary";
                string ColumnName = "ID";
                var SingleRow = (
                    from Rows in dgvSelectedTable.Rows.Cast<DataGridViewRow>()
                    where !Rows.IsNewRow && Rows.Cells[ColumnName].Value.ToString().ToUpper() == newUserName.ToUpper()
                    select Rows).FirstOrDefault();
                if (SingleRow == null && newUserName != "")
                {
                    //unsername is unique

                    con = new OleDbConnection();
                    con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                    cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"INSERT INTO [User] ([ID], [Password], [Job]) VALUES (@un, @pw, @jb)";
                    cmd.Parameters.AddWithValue("@un", newUserName);
                    cmd.Parameters.AddWithValue("@pw", tempPass);
                    cmd.Parameters.AddWithValue("@jb", jobTitle);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    con.Close();

                    btnUser_Click(sender, e);
                }
                else
                {
                    //username is not unique
                    MessageBox.Show("User not added. Please type a username that has not already been used.");
                }
            }
            else
            {
                MessageBox.Show("Please select 'CCG', 'Practice', 'Contact' or 'User'");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedTable == "CCG")
            {
                object selectedID = dgvSelectedTable.SelectedCells[0].Value;
                //input boxes using the Visual Basic .NET runtime library
                string CCGName = Interaction.InputBox("Enter CCG Name: ", "CCG: Name", dgvSelectedTable.SelectedCells[1].Value.ToString());
                string HDE = Interaction.InputBox("Enter Responsible HDE: ", "CCG: HDE", dgvSelectedTable.SelectedCells[2].Value.ToString());
                string CCGRegion = Interaction.InputBox("Enter CCG Region: ", "CCG: Region", dgvSelectedTable.SelectedCells[3].Value.ToString());

                if (CCGName != "" && HDE != "" && CCGRegion != "")
                {
                    currentCCG = new CCG(CCGName, HDE, CCGRegion);
                    currentCCG.EditCCG(CCGName, HDE, CCGRegion, selectedID);
                    MessageBox.Show("CCG " + selectedID + " has been updated.");
                    //refresh
                    btnCCGs_Click(sender, e);
                }
            }
            else if (selectedTable == "Practice")
            {
                object selectedID = dgvSelectedTable.SelectedCells[0].Value;
                //input boxes using the Visual Basic .NET runtime library
                string pracName = Interaction.InputBox("Enter Practice Name: ", "Practice: Name", dgvSelectedTable.SelectedCells[1].Value.ToString());
                string CCGName = Interaction.InputBox("Enter CCG Name: ", "Practice: CCG Name", dgvSelectedTable.SelectedCells[2].Value.ToString());
                string pracAddress = Interaction.InputBox("Enter Practice Address: ", "Practice: Address", dgvSelectedTable.SelectedCells[3].Value.ToString());

                if (CCGName != "" && pracName != "" && pracAddress != "")
                {
                    if (Regex.Match(pracAddress, @"[A-Z]{1,2}\d{1,2} \d[A-Z][A-Z]").Success)
                    {
                        OleDbConnection con;
                        OleDbCommand cmd;
                        OleDbDataReader reader;
                        con = new OleDbConnection();
                        con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                        cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = @"SELECT ID FROM CCG WHERE [CCG Name] = @cn";
                        cmd.Parameters.AddWithValue("@cn", CCGName);
                        con.Open();
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                        int ccgIdSelected = Convert.ToInt32(reader[0]);
                        con.Close();

                        currentPractice = new Practice(pracName, Convert.ToInt32(ccgIdSelected),pracAddress);
                        currentPractice.EditPractice(pracName, Convert.ToInt32(ccgIdSelected),pracAddress, selectedID);
                        MessageBox.Show("Practice " + selectedID + " has been updated.");
                        //refresh
                        btnPractices_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Please type and existing CCG name");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please type a valid postcode");
                    }

                    
                }
                else
                {
                    MessageBox.Show("Please type into all given fields");
                }
            }
            else if (selectedTable == "Contact")
            {
                object selectedID = dgvSelectedTable.SelectedCells[0].Value;
                //input boxes using the Visual Basic .NET runtime library
                string contactName = Interaction.InputBox("Enter Contact Name: ", "Contact: Name", dgvSelectedTable.SelectedCells[1].Value.ToString());
                string pracName = Interaction.InputBox("Enter Practice Name: ", "Contact: Practice Name", dgvSelectedTable.SelectedCells[2].Value.ToString());
                string contactPosition = Interaction.InputBox("Enter Contact Position: ", "Contact: Position", dgvSelectedTable.SelectedCells[3].Value.ToString());
                string contactEmail = Interaction.InputBox("Enter Contact Email: ", "Contact: Email", dgvSelectedTable.SelectedCells[4].Value.ToString());

                if (contactName != "" && pracName != "" && contactPosition != "" && contactEmail != "")
                {
                    if (Regex.Match(contactEmail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
                    {
                        OleDbConnection con;
                        OleDbCommand cmd;
                        OleDbDataReader reader;
                        con = new OleDbConnection();
                        con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                        cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = @"SELECT ID FROM Practice WHERE [Practice Name] = @pn";
                        cmd.Parameters.AddWithValue("@pn", pracName);
                        con.Open();
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                        int pracIdSelected = Convert.ToInt32(reader[0]);
                        con.Close();

                        currentContact = new Contact(contactName, Convert.ToInt32(pracIdSelected), contactPosition, contactEmail);
                        currentContact.EditContact(contactName, Convert.ToInt32(pracIdSelected), contactPosition, contactEmail, selectedID);
                        MessageBox.Show("Contact " + selectedID + " has been updated.");
                        //refresh
                        btnContacts_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Please type and existing Practice name");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please type a valid email address");
                    }


                }
            
                else
                {
                    MessageBox.Show("Please type into all given fields");
                }
            }

            else
            {
                MessageBox.Show("Please select 'CCG', 'Practice' or 'Contact'");
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin newFormAdmin = new FormAdmin();
            newFormAdmin.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            selectedTable = "User";
            lblSelectedTable.Text = selectedTable;
            //populate the dataviewgrid
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT [ID] FROM [User];";
            con.Open();
            reader = cmd.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = reader;
            dgvSelectedTable.DataSource = bindingSource;
            dgvSelectedTable.Columns[0].Width = 600;
            con.Close();
            btnCreateNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = true;
        }
    }
    }
