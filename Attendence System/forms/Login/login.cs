using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {

        private OleDbCommand oleDbCmd = new OleDbCommand();
        String conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zee\WebstormProjects\Attendence-System.git\Attendence System\AttendenceSystem.mdb";
        
        
        
        
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string queryString = "SELECT * FROM login";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(conn.ConnectionString))
                {
                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string companyCode = reader.GetValue(0).ToString();
                        string agentId = reader.GetString(1);
                        string firstName = reader.GetString(2);
                        string lastName = reader.GetString(3);
                        string nameSuffix = reader.GetString(4);
                        string corporateName = reader.GetString(5);
                        string entityType = reader.GetString(6);
                        string obfSSN = reader.GetString(7);
                        string obfFEIN = reader.GetString(8);
                        string dummyIndicator = reader.GetString(9);
                        // Insert code to process data.
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
        }
    }
}
