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
        
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string queryString = "SELECT * FROM users WHERE Login_username = '" + textBox1.Text + "' AND Login_password = '" + textBox2.Text + "'; ";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(conn.ConnectionString))
                {
                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("incorrect username or password",
                                                                   "no user found");
                    }


                    while (reader.Read())
                    {
                        string id = reader.GetValue(0).ToString();
                        string username = reader.GetString(1);
                        string password = reader.GetString(2);
                        string designation = reader.GetString(3);
                        // Insert code to process data.

                        if (designation == "admin")
                        {
                            appAdmin a = new appAdmin();
                            a.Show();
                            this.Hide();
                        }
                        else if (designation == "teacher")
                        {
                            teacher form = new teacher();
                            form.Show();
                            this.Hide();
                        }
                        else if (designation == "hod")
                        {
                            //hod form = new hod();
                            //form.Show();
                            //this.Close();
                            MessageBox.Show("no hod found");
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to connect to data source");
            }
        }
    }
}
