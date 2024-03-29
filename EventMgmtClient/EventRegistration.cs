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
    public partial class EventRegistration : Form1
    {
        public EventRegistration()
        {
            InitializeComponent();
        }

        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("WSDualHttpBinding_IService1");


        private void EventRegistration_Load(object sender, EventArgs e)
        {
            ShowEventRegistrations();
            FillDropDown();
        }

        void ShowEventRegistrations()
        {
            DataSet ds = new DataSet();
            ds = client.GetRegistrations();
            RegDG.DataSource = ds.Tables[0];
        }

        void FillDropDown()
        {
            DataSet partDataset = client.GetParticipants();
            DataTable participantsTable = partDataset.Tables["participants"];
            
            //new Column in table
            participantsTable.Columns.Add("Identity", typeof(string), "First_Name + ' ' + Email + ' ' + Mobile_No");

            cmbpart.DataSource = participantsTable;
            cmbpart.DisplayMember = "Identity";
            cmbpart.ValueMember = "Id";
            cmbpart.SelectedIndex = -1;

            DataSet eventDataset = client.GetEvents();
            cmbevent.DataSource = eventDataset.Tables["events"];
            cmbevent.DisplayMember = "Event_Name";
            cmbevent.ValueMember = "Id";
            cmbevent.SelectedIndex = -1;
        }

        void ClearTextBoxes()
        {
            cmbpart.SelectedIndex = -1;
            cmbevent.SelectedIndex = -1;
            nudfees.Value = 0;
        }

        DataGridViewRow selectedRow;
        private void RegDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < RegDG.Rows.Count)
                {
                    selectedRow = RegDG.Rows[e.RowIndex];
                    
                    string selectedPartName = selectedRow.Cells[1].Value.ToString();

                    foreach (object item in cmbpart.Items)
                    {
                        DataRowView rowView = item as DataRowView;
                        if (rowView != null && rowView["First_Name"].ToString() == selectedPartName)
                        {
                            // Found item -> select it in the ComboBox
                            cmbpart.SelectedItem = item;
                            break;
                        }
                    }

                    string selectedEventName = selectedRow.Cells[2].Value.ToString();

                    foreach (object item in cmbevent.Items)
                    {
                        DataRowView rowView = item as DataRowView;
                        if (rowView != null && rowView["Event_Name"].ToString() == selectedEventName)
                        {
                            // found item -> select it in the ComboBox
                            cmbevent.SelectedItem = item;
                            break;
                        }
                    }

                    dtpreg_date.Text = selectedRow.Cells[3].Value.ToString();
                    nudfees.Value = (int)selectedRow.Cells[4].Value;

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

        private void addEvent_Click(object sender, EventArgs e)
        {
            try
            {
                Object selectedPart = cmbpart.SelectedValue;
                int partID;
                int.TryParse(selectedPart.ToString(), out partID);

                Object selectedEvent = cmbevent.SelectedValue;
                int eventID;
                int.TryParse(selectedEvent.ToString(), out eventID);

                if(partID < 0 ||  eventID < 0 || nudfees.Value < 0)
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    bool res = client.AddRegistration(partID, eventID, dtpreg_date.Value, (int)nudfees.Value);
                    ShowEventRegistrations();
                    if(res)
                    {
                        ErrMsg.Text = "Event Registration Added!!";
                        ClearTextBoxes();
                    }
                    else
                    {
                        ErrMsg.Text = "Event Registration Not Added!!";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        private void deleteEvent_Click(object sender, EventArgs e)
        {
            try
            {
                Object selectedPart = cmbpart.SelectedValue;
                int partID;
                int.TryParse(selectedPart.ToString(), out partID);

                Object selectedEvent = cmbevent.SelectedValue;
                int eventID;
                int.TryParse(selectedEvent.ToString(), out eventID);

                if (partID < 0 || eventID < 0 || nudfees.Value < 0)
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    bool res = client.DeleteRegistration(Convert.ToInt32(selectedRow.Cells[0].Value));
                    ShowEventRegistrations();
                    if (res)
                    {
                        ErrMsg.Text = "Event Registration Deleted!!";
                        ClearTextBoxes();
                    }
                    else
                    {
                        ErrMsg.Text = "Not Deleted!!";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }
    }
}
