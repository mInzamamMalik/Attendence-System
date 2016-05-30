using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form teacher = new teacher();
            teacher.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form teacherIncharge = new teacherIncharge();
            teacherIncharge.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form appAdmin = new appAdmin();
            appAdmin.Show();
        }
    }
}
