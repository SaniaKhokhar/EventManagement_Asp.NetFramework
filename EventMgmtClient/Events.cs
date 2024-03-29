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

        private void Events_Load(object sender, EventArgs e)
        {
            ShowEvents();
        }

        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("WSDualHttpBinding_IService1");
        void ShowEvents()
        {
            DataSet ds = new DataSet();
            ds = client.GetEvents();
            EventDG.DataSource = ds.Tables[0];
        }
        private void ClearTextBoxes()
        {
            tbevent_name.Text = "";
            tbstart_time.Text = "";
            tbend_time.Text = "";
            tborg.Text = "";
            tbvenue.Text = "";
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
                    dateTimePicker1.Text = selectedRow.Cells[2].Value.ToString();
                    tbstart_time.Text = selectedRow.Cells[3].Value.ToString();
                    tbend_time.Text = selectedRow.Cells[4].Value.ToString();
                    tborg.Text = selectedRow.Cells[5].Value.ToString();
                    tbvenue.Text = selectedRow.Cells[6].Value.ToString();
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
                if (tbevent_name.Text == "" || tbstart_time.Text == "" || tbend_time.Text == "" || tborg.Text == "" || tbvenue.Text == "")
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
                if (tbevent_name.Text == "" || tbstart_time.Text == "" || tbend_time.Text == "" || tborg.Text == "" || tbvenue.Text == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    DateTime date;
                    DateTime.TryParse(dateTimePicker1.Text, out date);

                    //Convert.ToDateTime(dateTimePicker1)
                    bool res = client.AddEvent(tbevent_name.Text, date , tbstart_time.Text, tbend_time.Text, 1003,1002);
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
    }
}
