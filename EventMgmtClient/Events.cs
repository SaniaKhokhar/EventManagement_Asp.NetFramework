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
    public partial class Events : Form1
    {
        public Events()
        {
            InitializeComponent();
        }

        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("WSDualHttpBinding_IService1");

        private void Events_Load(object sender, EventArgs e)
        {
            ShowEvents();

            FillDropDown();

        }

        
        void ShowEvents()
        {
            DataSet ds = new DataSet();
            ds = client.GetEvents();
            EventDG.DataSource = ds.Tables[0];
        }

        void FillDropDown()
        {
            DataSet orgDataset = client.GetOrganizers();
            cmborg.DataSource = orgDataset.Tables["organizers"];
            cmborg.DisplayMember = "Name";
            cmborg.ValueMember = "Id";
            cmborg.SelectedIndex = -1;

            DataSet venueDataset = client.GetVenues();
            cmbvenue.DataSource = venueDataset.Tables["venues"];
            cmbvenue.DisplayMember = "Venue_Name";
            cmbvenue.ValueMember = "Id";
            cmbvenue.SelectedIndex = -1;
        }

        private void ClearTextBoxes()
        {
            tbevent_name.Text = "";
            dtpstart_time.Text = "";
            dtpend_time.Text = "";
            cmborg.SelectedIndex = -1;
            cmbvenue.SelectedIndex = -1;
        }

        DataGridViewRow selectedRow;
        private void EventDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < EventDG.Rows.Count)
                {
                    selectedRow = EventDG.Rows[e.RowIndex];
                    tbevent_name.Text = selectedRow.Cells[1].Value.ToString();
                    dtpdate.Text = selectedRow.Cells[2].Value.ToString();
                    dtpstart_time.Text = selectedRow.Cells[3].Value.ToString();
                    dtpend_time.Text = selectedRow.Cells[4].Value.ToString();

                    string selectedOrgName = selectedRow.Cells[5].Value.ToString();

                    foreach (object item in cmborg.Items)
                    {
                        DataRowView rowView = item as DataRowView;
                        if (rowView != null && rowView["Name"].ToString() == selectedOrgName)
                        {
                            // Found item -> select it in the ComboBox
                            cmborg.SelectedItem = item;
                            break;
                        }
                    }

                    string selectedVenueName = selectedRow.Cells[6].Value.ToString();

                    foreach (object item in cmbvenue.Items)
                    {
                        DataRowView rowView = item as DataRowView;
                        if (rowView != null && rowView["Venue_Name"].ToString() == selectedVenueName)
                        {
                            // found item -> select it in the ComboBox
                            cmbvenue.SelectedItem = item;
                            break;
                        }
                    }

                }
                else
                {
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        

        private void deleteParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                Object selectedOrg = cmborg.SelectedValue;
                int orgID;
                int.TryParse(selectedOrg.ToString(), out orgID);

                Object selectedVenue = cmbvenue.SelectedValue;
                int venueID;
                int.TryParse(selectedVenue.ToString(), out venueID);

                if (tbevent_name.Text == "" || orgID < 0 || venueID < 0)
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    bool res = client.DeleteEvent(Convert.ToInt32(selectedRow.Cells[0].Value));
                    ShowEvents();
                    if (res)
                    {
                        ErrMsg.Text = "Event Deleted!!";
                        ClearTextBoxes();
                    }
                    else
                    {
                        ErrMsg.Text = "Not deleted";
                    }
                }

            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            try
            {
                Object selectedOrg = cmborg.SelectedValue;
                int orgID;
                int.TryParse(selectedOrg.ToString(), out orgID);

                Object selectedVenue = cmbvenue.SelectedValue;
                int venueID;
                int.TryParse(selectedVenue.ToString(), out venueID);

                if (tbevent_name.Text == "" || orgID < 0 || venueID < 0)
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {


                    //Convert.ToDateTime(dateTimePicker1)
                    bool res = client.AddEvent(tbevent_name.Text, dtpdate.Value , dtpstart_time.Text, dtpend_time.Text, orgID, venueID);
                    ShowEvents();
                    if (res)
                    {
                        ErrMsg.Text = "Event Added!!";
                        ClearTextBoxes();
                    }
                    else
                    {
                        ErrMsg.Text = "Event Not Added!!";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }


        private void cmborg_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string selectedOrganization = cmborg.SelectedIndex.ToString();

            // Display a message box to show the selected organization
            MessageBox.Show("Selected organization: " + selectedOrganization + " 1");
            */
        }

        private void cmbvenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Object selectedVenue = cmbvenue.SelectedValue;

            if (selectedVenue != null)
            {
                // Display a message box to show the selected venue
                MessageBox.Show("Selected venue: " + selectedVenue.ToString());         // it gives id (which is seted as ValueMember)
            }
            else
            {
                MessageBox.Show("No venue selected.");
            }
            */

            /*
            DataRowView selectedRow = cmbvenue.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                // Access the value of the "Venue_Name" column
                string selectedVenueName = selectedRow["Venue_Name"].ToString();

                // Display the selected venue name in a message box
                MessageBox.Show("Selected venue: " + selectedVenueName);            // it is giving vamuew name
            }
            */

        }
    }
}
