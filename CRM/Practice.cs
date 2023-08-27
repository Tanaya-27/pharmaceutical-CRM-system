using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace FontusHealthCRM
{
    class Practice
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
        private int CCGID;
        private string address;

        //constructor
        public Practice(string strName, int intCcgId, string strAddress)
        {
            name = strName;
            CCGID = intCcgId;
            address = strAddress;
        }

        //methods
        public void AddPractice(string name, int CCGID, string address)
        {
            //store data into db via sql

            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO Practice ([Practice Name], [CCG ID], [Postcode]) VALUES (@nm, @cid, @ad)";
            cmd.Parameters.AddWithValue("@nm", name);
            cmd.Parameters.AddWithValue("@cid", CCGID);
            cmd.Parameters.AddWithValue("@ad", address);


            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();

            //find out the PRACID (autonumber) that has just been allocated
            cmd.CommandText = "SELECT MAX(ID) FROM Practice";
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            ID = Convert.ToInt32(reader[0]);
            con.Close();
        }

        public void EditPractice(string pracName, int ccgID, string pracAddress, object ID)
        {
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE Practice SET [Practice Name] = @nm, [CCG ID] = @cid, [Postcode] = @ad WHERE ID = @id;";
            cmd.Parameters.AddWithValue("@nm", pracName);
            cmd.Parameters.AddWithValue("@cid", ccgID);
            cmd.Parameters.AddWithValue("@ad", pracAddress);
            cmd.Parameters.AddWithValue("@id", ID);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeletePractice(object ID, bool relationship)
        {
            //delete contacts from prac


            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            if(relationship == false)
            {
                cmd.CommandText = string.Format(@"DELETE FROM Practice WHERE ID = @id");
                cmd.Parameters.AddWithValue("@id", ID);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();
            }
            else if(relationship == true)
            {
                //find prac IDs (list) and step through
                List<int> pracIDs = new List<int>();

                con2 = new OleDbConnection();
                con2.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd2 = new OleDbCommand();
                cmd2.Connection = con2;
                cmd2.CommandText = string.Format(@"SELECT ID FROM Practice WHERE [CCG ID] = @id");
                cmd2.Parameters.AddWithValue("@id", ID);
                con2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    pracIDs.Add(reader2.GetInt32(0));
                }
                foreach (var item in pracIDs) //steps through samples of selected contact
                {
                    Contact currentContact = new Contact("", 0, "", "");
                    currentContact.DeleteContact(item, true);
                }
                con2.Close();

                cmd.CommandText = string.Format(@"DELETE FROM Practice WHERE [CCG ID] = @id");
                cmd.Parameters.AddWithValue("@id", ID);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();

            }
        }
    }
}
