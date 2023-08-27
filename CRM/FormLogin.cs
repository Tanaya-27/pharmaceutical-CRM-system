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
    public partial class FormLogin : Form
    {
        string username;
        string jobTitle;
        public FormLogin()
        {
            InitializeComponent();
            username = "";
            jobTitle = "";
            txtPassword.UseSystemPasswordChar = true;

            //Only show password when holding down button
            picShowPass.MouseDown += new MouseEventHandler(picShowPass_MouseDown);
            picShowPass.MouseUp += new MouseEventHandler(picShowPass_MouseUp);
            picShowNewPass.MouseDown += new MouseEventHandler(picShowNewPass_MouseDown);
            picShowNewPass.MouseUp += new MouseEventHandler(picShowNewPass_MouseUp);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader reader;
            //open dash and close this if user details correct
            //for admin form - allow to add users w temp password - CANT HAVE SAME UNs
            string usrNameEntered = txtUsername.Text;
            string passwordEntered = txtPassword.Text;
            //access connection
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @" SELECT * FROM [User] WHERE ID = @un AND Password = @pw;";
            cmd.Parameters.AddWithValue("@un", usrNameEntered);
            cmd.Parameters.AddWithValue("@pw", passwordEntered);
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                username = reader[0].ToString();
                jobTitle = reader[2].ToString();
                MessageBox.Show("User '" + username + "' logged in successfully");
                btnOpenDash.Enabled = true;
                btnChangePass.Enabled = true;
                if(passwordEntered == "T3mporary")
                {
                    MessageBox.Show("Please change your password from the default in order to secure your account");
                }
            }
            else
            {
                MessageBox.Show("Invalid login.");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            con.Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            lblNewPass.Visible = true;
            txtNewPass.Visible = true;
            btnConfirmNewPass.Visible = true;
            picShowNewPass.Visible = true;
        }

        private void btnConfirmNewPass_Click(object sender, EventArgs e)
        {
            string newPassEntered = txtNewPass.Text;
            if (Regex.Match(newPassEntered, @"^(?=.*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9]).{8,30}$").Success) //1+ uppercase, 1+ special, 2+ digits, 8-30 digits
            {
            OleDbConnection con;
            OleDbCommand cmd;
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE [User] SET [Password] = @npw WHERE [ID] = @id;";
            cmd.Parameters.AddWithValue("@npw", newPassEntered);
            cmd.Parameters.AddWithValue("@id", username);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Password updated successfully");
            }
            else
            {
                MessageBox.Show("Password not updated. Please ensure you have at least one uppercase value and special character, at least two digits, and 8-30 characters");
            }

        }

        private void btnOpenDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm newMainForm = new MainForm(username, jobTitle);
            newMainForm.ShowDialog();
            this.Close();
        }
        private void picShowPass_MouseDown(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void picShowPass_MouseUp(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void picShowNewPass_MouseDown(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = false;
        }

        private void picShowNewPass_MouseUp(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = true;
        }
    }
}
