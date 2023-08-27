using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FontusHealthCRM
{
    class Activity
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader reader;
        OleDbConnection con2;
        OleDbCommand cmd2;
        OleDbDataReader reader2;


        //attributes
        private object ID;
        private int contactID;
        private string dateOf;
        private string type;
        private string notes;

        //constructor
        public Activity (int intContactId, string strDateOf, string strType, string strNotes)
        {
            contactID = intContactId;
            dateOf = strDateOf;
            type = strType;
            notes = strNotes;
            //use dateTime for dateCreated
        }

        //methods
        public void AddActivity(int contactID, string dateOf, string type, string notes)
        {

            //store data into db via sql
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO Activity ([Contact ID], [Date Of], [Date Created], Type, Notes) VALUES (@cid, @dto, @dtc, @tp, @nt)";
            cmd.Parameters.AddWithValue("@cid", contactID);
            cmd.Parameters.AddWithValue("@dto", dateOf);
            cmd.Parameters.AddWithValue("@dtc", DateTime.Now.ToString("dd/MM/yyyy")); //dateTime rn
            cmd.Parameters.AddWithValue("@tp", type);
            cmd.Parameters.AddWithValue("@nt", notes);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();

            //find out the ActivityID (autonumber) that has just been allocated
            cmd.CommandText = "SELECT MAX(ID) FROM Activity";
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            ID = Convert.ToInt32(reader[0]);
            con.Close();
        }

        public void EditActivity(int contactID, string dateOf, string type, string notes, object ID) 
        {
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE Activity SET [Contact ID] = @cid, [Date Of] = @dto, Type = @tp, Notes = @nt WHERE ID = @id;";
            cmd.Parameters.AddWithValue("@cid", contactID);
            cmd.Parameters.AddWithValue("@dto", dateOf);
            cmd.Parameters.AddWithValue("@tp", type);
            cmd.Parameters.AddWithValue("@nt", notes);
            cmd.Parameters.AddWithValue("@id", ID);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteActivity(object ID, bool relationship)
        {
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            if(relationship == false)
            {
                cmd.CommandText = string.Format(@"DELETE FROM Activity WHERE ID = @id");
                cmd.Parameters.AddWithValue("@id", ID);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();


            }
            else if(relationship == true) //in this case, the contactID is parsed to delete
            {
                cmd.CommandText = string.Format(@"DELETE FROM Activity WHERE [Contact ID] = @id");
                cmd.Parameters.AddWithValue("@id", ID);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();
            }

        }
    }
}
