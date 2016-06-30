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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new manageClassRoom();
            a.Show();
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            var a = new classRoom();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = new addClassRoom();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var a = new classReport();
            a.Show();
        }
    }
}
