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
    public partial class appAdmin : Form
    {
        public appAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addTeacherIncharge =  new addTeacherIncharge();
            addTeacherIncharge.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addHOD = new addHOD();
            addHOD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var viewAll = new viewAll();
            viewAll.Show();
        }
    }
}
