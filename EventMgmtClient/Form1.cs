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
            Participant participantForm = new Participant();
            participantForm.ShowDialog();
        }

        private void btnparticipant_Click(object sender, EventArgs e)
        {
            this.Hide();
            Participant participantForm = new Participant();
            participantForm.ShowDialog();
            //this.Show();
        }

        private void btnvenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venue venueForm = new Venue();
            venueForm.ShowDialog();
            //this.Show();
        }

        private void btnorganizer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Organizer orgForm = new Organizer();
            orgForm.ShowDialog();
            //this.Show();
        }

        private void btnevent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events eventsForm = new Events();
            eventsForm.ShowDialog();
            //this.Show();
        }
        private void btnreg_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventRegistration regForm = new EventRegistration();
            regForm.ShowDialog();
            //this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }

}