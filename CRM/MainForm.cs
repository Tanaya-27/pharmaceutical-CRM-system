using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace FontusHealthCRM
{
    public partial class MainForm : Form
    {
        static OleDbConnection con;
        static OleDbCommand cmd;
        static OleDbDataReader reader;

        static OleDbConnection con2;
        static OleDbCommand cmd2;
        static OleDbDataReader reader2;

        static OleDbConnection con3;
        static OleDbCommand cmd3;
        static OleDbDataReader reader3;

        static OleDbConnection con4;
        static OleDbCommand cmd4;
        static OleDbDataReader reader4;

        string username;
        string job;

        public MainForm(string userName, string jobTitle)
        {
            InitializeComponent();

            username = userName;
            job = jobTitle;

            if (jobTitle == "MD" || jobTitle == "IT Officer")
            {
                btnAdmin.Enabled = true;
            }
            if (jobTitle == "HDE")
            {
                chkMyDataOnly.Enabled = true;
            }

            PopulateTopPracs();
            PopulatePercentChart();

        }
        //subroutine SORT
        //Uses recursion to break the collection into progressively smaller collections; eventually, each collection will have just one element
        private static List<List<decimal>> Sort(List<List<decimal>> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }
            List<List<decimal>> left = new List<List<decimal>>();
            List<List<decimal>> right = new List<List<decimal>>();
            int median = unsorted.Count / 2;
            for (int i = 0; i < median; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = median; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }
            left = Sort(left);
            right = Sort(right);
            return Merge(left, right);
        }
        //Method takes two sorted "sublists" (left and right) 
        //of original list and merges them into a new colletion
        private static List<List<decimal>> Merge(List<List<decimal>> left, List<List<decimal>> right)
        {
            List<List<decimal>> result = new List<List<decimal>>(); //The new collection
            while (left.Any() || right.Any())
            {
                if (left.Any() && right.Any())
                {
                    //Comparing the first element of each sublist to see which is smaller
                    if (left[0][0] >= right[0][0])
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Any())
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Any())
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }


        //subroutine POPULATE TOP10 CHART
        private void PopulateTopPracs()
        {
            decimal valuePerSample;
            decimal valuePerContact;
            decimal valuePerPractice;
            decimal totalRevenue = 0;
            List<List<decimal>> topPrac2D = new List<List<decimal>>(); //a list of compiled 1d lists

            //algorithm to find total value of samples from a practice
            List<int> pracIDs = new List<int>();
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;

            //add if statement for alternate query (for just the users ccgs)
            if (chkMyDataOnly.Checked == true)
            {
                cmd.CommandText = @"SELECT Practice.ID FROM Practice INNER JOIN CCG ON Practice.[CCG ID] = CCG.ID WHERE CCG.[Responsible HDE] = @hde;";
                cmd.Parameters.AddWithValue("@hde", username);
            }
            else
            {
                cmd.CommandText = @"SELECT ID FROM Practice";
            }

            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pracIDs.Add(reader.GetInt32(0));
            }

            foreach (var item in pracIDs) //steps through practices
            {
                valuePerPractice = 0; //set back to 0 !!
                List<int> contIDs = new List<int>();
                con2 = new OleDbConnection();
                con2.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd2 = new OleDbCommand();
                cmd2.Connection = con2;
                cmd2.CommandText = @"SELECT ID FROM Contact WHERE [Practice ID] = @itm";
                cmd2.Parameters.AddWithValue("@itm", Convert.ToInt32(item));
                con2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    contIDs.Add(reader2.GetInt32(0));
                }
                foreach (var item2 in contIDs) //steps through contacts in each practice
                {
                    valuePerContact = 0; //set back to 0 !!
                    List<int> sampleIDs = new List<int>();
                    con3 = new OleDbConnection();
                    con3.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                    cmd3 = new OleDbCommand();
                    cmd3.Connection = con3;
                    cmd3.CommandText = @"SELECT ID FROM Sample WHERE [Contact ID] = @itm";
                    cmd3.Parameters.AddWithValue("@itm", item2);
                    con3.Open();
                    reader3 = cmd3.ExecuteReader();
                    while (reader3.Read())
                    {
                        sampleIDs.Add(reader3.GetInt32(0));
                    }
                    foreach (var item3 in sampleIDs) //steps through samples from each contact
                    {
                        valuePerSample = 0; //set back to 0 !!
                        con4 = new OleDbConnection();
                        con4.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                        cmd4 = new OleDbCommand();
                        cmd4.Connection = con4;
                        cmd4.CommandText = @" SELECT SUM([Product].[Price]*[Sample Items].[Quantity]) FROM Product INNER JOIN [Sample Items] ON Product.[ID] = [Sample Items].[Product ID] WHERE [Sample ID] = @itm";
                        cmd4.Parameters.AddWithValue("@itm", item3);
                        con4.Open();
                        reader4 = cmd4.ExecuteReader();
                        while (reader4.Read())
                        {
                            valuePerSample += Convert.ToDecimal(reader4.GetValue(0));
                        }
                        con4.Close();
                        //need to add together valuePerSample (within each contact) to get valuePerContact
                        valuePerContact += valuePerSample;
                    }
                    con3.Close();

                    //need to add together valuePerContact (within each practice) to get valuePerPractice
                    valuePerPractice += valuePerContact;
                }
                con2.Close();

                //add prac name then prac value
                List<decimal> topPrac1D = new List<decimal>();
                topPrac1D.Add(valuePerPractice);

                //getting name of current prac (to add to 1d list)
                OleDbConnection con5;
                OleDbCommand cmd5;
                OleDbDataReader reader5;
                con5 = new OleDbConnection();
                con5.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd5 = new OleDbCommand();
                cmd5.Connection = con5;
                cmd5.CommandText = @"SELECT [Practice Name] FROM Practice WHERE ID = @id";
                cmd5.Parameters.AddWithValue("@id", item);
                con5.Open();
                reader5 = cmd5.ExecuteReader();
                reader5.Read();
                if (reader5.HasRows)
                {
                    string currentPracName = Convert.ToString(reader5[0]);
                    con5.Close();
                    //adding prac name to list (second item in 1d list)
                    topPrac1D.Add(item);
                }
                //adding this list to 2d list
                topPrac2D.Add(topPrac1D);

                totalRevenue += valuePerPractice;
            }
            con.Close();


            //merge sort List toppracvalues
            List<List<decimal>> sortedTopPracs = Sort(topPrac2D);

            //populate top ten chart - stacked bar chart
            if (sortedTopPracs.Count < 11)
            {
                for (int i = 0; i < sortedTopPracs.Count; i++)
                {
                    con = new OleDbConnection();
                    con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                    cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"SELECT [Practice Name] FROM Practice WHERE ID = @id";
                    cmd.Parameters.AddWithValue("@id", sortedTopPracs[i][1]);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    string pracName = Convert.ToString(reader[0]);
                    con.Close();
                    chartTopPracs.Series["Value, £"].Points.AddXY(pracName, sortedTopPracs[i][0]);

                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    con = new OleDbConnection();
                    con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                    cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"SELECT [Practice Name] FROM Practice WHERE ID = @id";
                    cmd.Parameters.AddWithValue("@id", sortedTopPracs[i][1]);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    string pracName = Convert.ToString(reader[0]);
                    con.Close();
                    chartTopPracs.Series["Value, £"].Points.AddXY(pracName, sortedTopPracs[i][0]);

                }

            }

        }

        private void PopulatePercentChart()
        {
            //filling %ofsales pie chart
            //want % of total revenue - find total, then step through all products and find % and add to pie
            decimal valuePerProd;
            List<int> prodIDs = new List<int>();
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT [ID] FROM Product";
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                prodIDs.Add(reader.GetInt32(0));
            }
            foreach (var item in prodIDs) //steps through products
            {
                valuePerProd = 0;
                con2 = new OleDbConnection();
                con2.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                cmd2 = new OleDbCommand();
                cmd2.Connection = con2;

                //add if statement for alternate query (for just the users ccgs)
                if (chkMyDataOnly.Checked == true)
                {

                    List<int> HDEPracs = new List<int>();
                    con3 = new OleDbConnection();
                    con3.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                    cmd3 = new OleDbCommand();
                    cmd3.Connection = con3;
                    cmd3.CommandText = @" SELECT Practice.ID FROM Practice INNER JOIN CCG ON CCG.ID = Practice.[CCG ID] WHERE CCG.[Responsible HDE] = @hde";
                    cmd3.Parameters.AddWithValue("@hde", username);
                    con3.Open();
                    reader3 = cmd3.ExecuteReader();
                    while (reader3.Read())
                    {
                        HDEPracs.Add(reader3.GetInt32(0));
                    }
                    if (HDEPracs.Count > 0)
                    {
                        foreach (var item3 in HDEPracs) //steps through practices belonging to user
                        {
                            List<int> HDESamples = new List<int>();
                            con4 = new OleDbConnection();
                            con4.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =Fontus Health CRM.mdb";
                            cmd4 = new OleDbCommand();
                            cmd4.Connection = con4;
                            cmd4.CommandText = @" SELECT Sample.ID FROM Sample INNER JOIN Contact ON Sample.[Contact ID] = Contact.ID WHERE Contact.[Practice ID] = @itm";
                            cmd4.Parameters.AddWithValue("@itm", item3);
                            con4.Open();
                            reader4 = cmd4.ExecuteReader();
                            while (reader4.Read())
                            {
                                HDESamples.Add(reader4.GetInt32(0));
                            }
                            foreach (var item4 in HDESamples) //steps through samples belonging to user
                            {
                                cmd2.CommandText = @"  SELECT SUM([Product].[Price]*[Sample Items].[Quantity]) FROM Product INNER JOIN [Sample Items] ON Product.[ID] = [Sample Items].[Product ID]";
                                cmd2.CommandText += @" WHERE [Sample Items].[Product ID] = @itm AND [Sample Items].[Sample ID] = @itm4";
                                cmd2.Parameters.AddWithValue("@itm", item);
                                cmd2.Parameters.AddWithValue("@itm4", item4);
                            }
                            con4.Close();
                        }
                        con3.Close();
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    cmd2.CommandText = @" SELECT SUM([Product].[Price]*[Sample Items].[Quantity]) FROM Product";
                    cmd2.CommandText += @" INNER JOIN [Sample Items] ON Product.[ID] = [Sample Items].[Product ID] WHERE [Sample Items].[Product ID] = @itm";
                    cmd2.Parameters.AddWithValue("@itm", item);
                }


                con2.Open();
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    valuePerProd = Convert.ToDecimal(reader2.GetValue(0));
                    //now add this value to pie chart
                    chartPercentOfSales.Series["Value"].Points.AddXY(Convert.ToString(item), valuePerProd);
                    chartPercentOfSales.Series["Value"].Label = "#PERCENT{P2}";
                    chartPercentOfSales.Series["Value"].LegendText = "#VALX";
                }
                con2.Close();
            }

        }


        private void btnCCGs_Click_1(object sender, EventArgs e)
        {
            FormCCGs newCCGsForm = new FormCCGs();
            newCCGsForm.Show();
        }

        private void btnPractices_Click_1(object sender, EventArgs e)
        {
            FormPractices newFormPractices = new FormPractices();
            newFormPractices.Show();
        }

        private void btnContacts_Click_1(object sender, EventArgs e)
        {
            FormContacts newFormContacts = new FormContacts();
            newFormContacts.Show();
        }

        private void btnActivities_Click_1(object sender, EventArgs e)
        {
            FormActivities newFormActivities = new FormActivities();
            newFormActivities.Show();
        }

        private void btnSamples_Click_1(object sender, EventArgs e)
        {
            FormSamples newFormSamples = new FormSamples();
            newFormSamples.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin newFormAdmin = new FormAdmin();
            newFormAdmin.Show();
        }

        private void chkMyDataOnly_CheckedChanged(object sender, EventArgs e)
        {
            //refresh charts (put if statement in queries)
            chartTopPracs.Series.Clear();
            chartTopPracs.Series.Add("Value, £");
            chartTopPracs.Series["Value, £"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;

            chartPercentOfSales.Series.Clear();
            chartPercentOfSales.Series.Add("Value");
            chartPercentOfSales.Series["Value"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            PopulateTopPracs();
            PopulatePercentChart();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin newFormLogin = new FormLogin();
            newFormLogin.ShowDialog();
            this.Close();
        }
    }
}
