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
            OleDbConnection Conn = new OleDbConnection(conStr);
            Conn.Open();
            String strCmd = "Select * from Login where username= @username AND password = @password";

        }
    }
}
