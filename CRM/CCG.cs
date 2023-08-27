using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace FontusHealthCRM
{
    class CCG
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader reader;


        //attributes
        private object ID;
        private string name;
        private string HDE;
        private string region;

        //constructor
        public CCG(string strName, string strHDE, string strRegion)
        {
            name = strName;
            HDE = strHDE;
            region = strRegion;
        }

        //methods
        public void AddCCG(string name, string HDE, string region)
        {
            //store data into db via sql

            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO CCG ([CCG Name], [Responsible HDE], [CCG Region]) VALUES (@nm, @hde, @rg)";
            cmd.Parameters.AddWithValue("@nm", name);
            cmd.Parameters.AddWithValue("@hde", HDE);
            cmd.Parameters.AddWithValue("@rg", region);

            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();

            //find out the CCGID (autonumber) that has just been allocated
            cmd.CommandText = "SELECT MAX(ID) FROM CCG";
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            ID = Convert.ToInt32(reader[0]);
            con.Close();
        }

        public void EditCCG(string ccgName, string HDE, string ccgRegion, object ID)
        {

            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"UPDATE CCG SET [CCG Name] = @nm, [Responsible HDE] = @hde, [CCG Region] = @rg WHERE ID = @id;";
            cmd.Parameters.AddWithValue("@nm", ccgName);
            cmd.Parameters.AddWithValue("@hde", HDE);
            cmd.Parameters.AddWithValue("@rg", ccgRegion);
            cmd.Parameters.AddWithValue("@id", ID);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();

        }
        
        public void DeleteCCG(object ID)
        {
            //delete practices under ccg
            Practice currentPractice = new Practice("", 0, "");
            currentPractice.DeletePractice(ID, true);


            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = string.Format(@"DELETE FROM CCG WHERE ID = @id");
            cmd.Parameters.AddWithValue("@id", ID);
            con.Open();
            reader = cmd.ExecuteReader();
            con.Close();

        }
    }
}
