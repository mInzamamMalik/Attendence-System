﻿using System;
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
    public partial class teacherIncharge : Form
    {
        public teacherIncharge()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login a = new login();
            a.Show();
            this.Close();
        }
    }
}
