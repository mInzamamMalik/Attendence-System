using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class manageClassRoom : Form
    {
        public manageClassRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new addStudent();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = new addStudent();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var a = new addClassRoom();
            a.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
