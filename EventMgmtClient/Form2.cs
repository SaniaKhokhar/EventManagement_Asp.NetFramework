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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void participantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Participant participantForm = new Participant();
            participantForm.ShowDialog();
        }

        private void venueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venue venueForm = new Venue();
            venueForm.ShowDialog();
        }

        private void organizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Organizer orgForm = new Organizer();
            orgForm.ShowDialog();
        }

        private void eventtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events eventsForm = new Events();
            eventsForm.ShowDialog();
        }

        private void registrationtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventRegistration regForm = new EventRegistration();
            regForm.ShowDialog();
        }
    }
}
