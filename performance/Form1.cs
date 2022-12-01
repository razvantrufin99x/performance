using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace performance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public  PerformanceManager pf ;//= new PerformanceManager();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pf = new PerformanceManager();
                Text = pf.getCurrentCpuUsage();
            }
            catch { }
        }
    }
}
