using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventMgmtClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client1 = new EventMgmtClient.ServiceReference1.Service1Client("WSDualHttpBinding_IService1");
            EventMgmtClient.ServiceReference1.Participant part = client1.GetParticipant(3);
            label1.Text = part.ParticipantfName;
            client1.Close();

        }
    }
}
