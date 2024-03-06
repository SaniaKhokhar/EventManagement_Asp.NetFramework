using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace EventMgmtHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceHost sh = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            sh = new ServiceHost(typeof(EventMgmtServiceLibrary.Service1));
            sh.Open();
            label1.Text = "Service Running!";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sh.Close();
        }
    }
}
