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
    public partial class addHOD : Form
    {
        public addHOD()
        {
            InitializeComponent();
        }

        private void addHOD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("All Fields are required");
                return;
            }
            else
            {
                try
                {

                    //INSERT INTO login( [password], username, name, designation ) values('aaa', 'bbb', 'ccc', 'ddd');


                    OleDbCommand cmd1 = new OleDbCommand("INSERT INTO login(Login_username, Login_password, Login_designation, Login_name) values (@username, @password, @designation, @name)", conn);
                    conn.Open();

                    cmd1.Parameters.AddWithValue("@username", textBox3.Text);
                    cmd1.Parameters.AddWithValue("@password", textBox2.Text);
                    cmd1.Parameters.AddWithValue("@designation", "hod");
                    cmd1.Parameters.AddWithValue("@name", textBox1.Text);

                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(textBox1.Text + " is Added as HOD");
                    conn.Close();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message, "An Error Occured");

                }
                finally
                {
                    conn.Close();
                }


            }
        }
    }
}
