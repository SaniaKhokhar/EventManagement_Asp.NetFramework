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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Participant participant = new Participant();
            participant.ShowDialog();
        }
        private void btnvenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venue venue = new Venue();
            venue.ShowDialog();
        }

        private void btnorganizer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Organizer org = new Organizer();
            org.ShowDialog();
        }

        private void btnevent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events events = new Events();
            events.ShowDialog();
        }
        private void btnreg_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventRegistration reg = new EventRegistration();
            reg.ShowDialog();
        }
    }

}