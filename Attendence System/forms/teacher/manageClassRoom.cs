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

        private void manageClassRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendenceSystemDataSet1.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.FillBy2(this.attendenceSystemDataSet1.students);
            // TODO: This line of code loads data into the 'attendenceSystemDataSet1.students' table. You can move, or remove it, as needed.
            //this.studentsTableAdapter.Fill(this.attendenceSystemDataSet1.students);
            // TODO: This line of code loads data into the 'attendenceSystemDataSet.Student' table. You can move, or remove it, as needed.
            //  this.studentTableAdapter.Fill(this.attendenceSystemDataSet.Student);

        }

      

        //private void fillByToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.studentsTableAdapter.FillBy(this.attendenceSystemDataSet1.students);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.studentsTableAdapter.FillBy1(this.attendenceSystemDataSet1.students);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
