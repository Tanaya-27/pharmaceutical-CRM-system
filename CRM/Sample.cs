using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace FontusHealthCRM
{
    class Sample
    {
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataReader reader;
        static OleDbConnection con2;
        static OleDbCommand cmd2;
        static OleDbDataReader reader2;
        //static OleDbDataReader reader2;

        //attributes
        private object ID;
        private int contactID;
        //private string creationDate;
        private string status;
        public List<SampleItem> listOfSampleItems { get; } //uses composition

        //constructor
        public Sample( int intContactId, string strStatus)
        {
            contactID = intContactId;
            status = strStatus;
            listOfSampleItems = new List<SampleItem>();
        }
        //methods
        public void AddSample(int contactID, string sampleStatus)
        {
            //store data into db via sql
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO Sample ([Contact ID], [Creation Date], Status) VALUES (@cid, @cdt, @st)";
            cmd.Parameters.AddWithValue("@cid", contactID);
            cmd.Parameters.AddWithValue("@cdt", DateTime.Now.ToString("dd/MM/yyyy"));
            cmd.Parameters.AddWithValue("@st", sampleStatus);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();

            //find out the SampleID (autonumber) that has just been allocated
            cmd.CommandText = "SELECT MAX(ID) FROM Sample";
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            ID = Convert.ToInt32(reader[0]);
            con.Close();

            //write the SampleItems to database
            con2 = new OleDbConnection();
            con2.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd2 = new OleDbCommand();
            cmd2.Connection = con2;

            foreach (var item in listOfSampleItems)
            {
                cmd2.Parameters.Clear();
                cmd2.CommandText = @"INSERT INTO [Sample Items] ([Product ID], [Sample ID], [Quantity]) VALUES (@prd, @sid, @q)";
                cmd2.Parameters.AddWithValue("@prd", Convert.ToString(item.productID));
                cmd2.Parameters.AddWithValue("@sid", Convert.ToString(ID));
                cmd2.Parameters.AddWithValue("@q", Convert.ToString(item.quantity));

                con2.Open();
                int status2 = cmd2.ExecuteNonQuery();
                con2.Close();
            }
        }
        public void addItem(SampleItem oi)
        {
            listOfSampleItems.Add(oi);
        }
        public decimal CalcTotal()
        {
            decimal runningTotal = 0;
            foreach (var item in listOfSampleItems)
            {
                runningTotal = runningTotal + item.price * item.quantity;
            }
            return runningTotal;
        }

        public void EditSample(string newStatus, object ID)
        {
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE Sample SET Status = @st WHERE ID = @id;";
            cmd.Parameters.AddWithValue("@st", newStatus);
            cmd.Parameters.AddWithValue("@id", ID);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteSample(object ID, bool relationship)
        {
            if (relationship == false)
            {
                con2 = new OleDbConnection();
                con2.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd2 = new OleDbCommand();
                cmd2.Connection = con2;
                cmd2.CommandText = string.Format(@"DELETE FROM [Sample Items] WHERE [Sample ID] = @id");
                cmd2.Parameters.AddWithValue("@id", ID);
                con2.Open();
                reader2 = cmd2.ExecuteReader();
                con2.Close();

                con = new OleDbConnection();
                con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = string.Format(@"DELETE FROM [Sample] WHERE ID = @id");
                cmd.Parameters.AddWithValue("@id", ID);
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();

            }
            else if (relationship == true)
            {
                List<int> sampleIDs = new List<int>();

                //need to get list of sampleIDs from contact
                con = new OleDbConnection();
                con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @" SELECT ID FROM Sample WHERE [Contact ID] = @id";
                cmd.Parameters.AddWithValue("@id", ID);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sampleIDs.Add(reader.GetInt32(0));
                }
                foreach (var item in sampleIDs) //steps through samples of selected contact
                {

                    con2 = new OleDbConnection();
                    con2.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                    cmd2 = new OleDbCommand();
                    cmd2.Connection = con2;
                    cmd2.CommandText = string.Format(@"DELETE FROM [Sample Items] WHERE [Sample ID] = @id");
                    cmd2.Parameters.AddWithValue("@id", item);
                    con2.Open();
                    reader2 = cmd2.ExecuteReader();
                    con2.Close();

                    con = new OleDbConnection();
                    con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                    cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = string.Format(@"DELETE FROM [Sample] WHERE ID = @id");
                    cmd.Parameters.AddWithValue("@id", item);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    con.Close();

                }
                con.Close();

            }

        }
    }
}
