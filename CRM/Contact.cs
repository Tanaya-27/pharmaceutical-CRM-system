using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace FontusHealthCRM
{
    class Contact
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader reader;
        OleDbConnection con2;
        OleDbCommand cmd2;
        OleDbDataReader reader2;


        //attributes
        private object ID;
        private string name;
        private int pracID;
        private string position;
        private string email;

        //constructor
        public Contact(string strName, int intPracId, string strPosition, string strEmail)
        {
            name = strName;
            pracID = intPracId;
            position = strPosition;
            email = strEmail;
        }

        //methods
        public void AddContact(string name, int pracID, string position, string email)
        {
            //store data into db via sql
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO Contact ([Contact Name], [Practice ID], [Position], [Email]) VALUES (@nm, @pid, @pos, @em)";
            cmd.Parameters.AddWithValue("@nm", name);
            cmd.Parameters.AddWithValue("@pid", pracID);
            cmd.Parameters.AddWithValue("@pos", position);
            cmd.Parameters.AddWithValue("@em", email);


            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();

            //find out the ContactID (autonumber) that has just been allocated
            cmd.CommandText = "SELECT MAX(ID) FROM Contact";
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            ID = Convert.ToInt32(reader[0]);
            con.Close();
        }

        public void EditContact(string contName, int pracID, string position, string email, object ID)
        {
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE Contact SET [Contact Name] = @nm, [Practice ID] = @pid, [Position] = @pos, [Email] = @em WHERE ID = @id;";
            cmd.Parameters.AddWithValue("@nm", contName);
            cmd.Parameters.AddWithValue("@pid", pracID);
            cmd.Parameters.AddWithValue("@pos", position);
            cmd.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@id", ID);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteContact(object ID, bool relationship)
        {
            //delete activities and samples under contact




            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            if(relationship == false)
            {
                cmd.CommandText = string.Format(@"DELETE FROM Contact WHERE ID = @id");
                cmd.Parameters.AddWithValue("@id", ID);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();

            }
            else if(relationship == true)
            {
                //find contactID
                List<int> contactIDs = new List<int>();

                con2 = new OleDbConnection();
                con2.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd2 = new OleDbCommand();
                cmd2.Connection = con2;
                cmd2.CommandText = string.Format(@"SELECT ID FROM Contact WHERE [Practice ID] = @id");
                cmd2.Parameters.AddWithValue("@id", ID);
                con2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    contactIDs.Add(reader2.GetInt32(0));
                }
                foreach (var item in contactIDs) //steps through samples of selected contact
                {
                    Activity newActivity = new Activity(0, "", "", "");
                    newActivity.DeleteActivity(item, true);
                    Sample newSample = new Sample(0, "");
                    newSample.DeleteSample(item, true);
                }
                con2.Close();


                cmd.CommandText = string.Format(@"DELETE FROM Contact WHERE [Practice ID] = @id");
                cmd.Parameters.AddWithValue("@id", ID);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();

            }
        }
    }
}
