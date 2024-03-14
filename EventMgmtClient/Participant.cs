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
    public partial class Participant : Form
    {
        public Participant()
        {
            InitializeComponent();
        }

        private void Participant_Load(object sender, EventArgs e)
        {
            ShowParticipant();
        }

        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("WSDualHttpBinding_IService1");
        void ShowParticipant()
        {
            
           /* ParticipantDG.DataSource = client.GetParticipants();
            ParticipantDG.DataBind;*/

            DataSet ds = new DataSet();
            ds = client.GetParticipants();
            ParticipantDG.DataSource = ds.Tables[0];
        }
        private void addParticipant_Click(object sender, EventArgs e)
        {
           bool res =  client.AddParticipant(tbfname.Text,tblname.Text,Convert.ToInt64(tbmob_no.Text),tbemail.Text);
        }

       
    }
}

