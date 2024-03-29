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
    public partial class Participant : Form1
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
            DataSet ds = new DataSet();
            ds = client.GetParticipants();
            ParticipantDG.DataSource = ds.Tables[0];
        }
        private void ClearTextBoxes()
        {
            tbfname.Text = "";
            tblname.Text = "";
            tbemail.Text = "";
            tbmob_no.Text = "";
        }

        DataGridViewRow selectedRow;
        private void Participant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < ParticipantDG.Rows.Count)
                {
                    selectedRow = ParticipantDG.Rows[e.RowIndex];
                    tbfname.Text = selectedRow.Cells[1].Value.ToString();
                    tblname.Text = selectedRow.Cells[2].Value.ToString();
                    tbemail.Text = selectedRow.Cells[3].Value.ToString();
                    tbmob_no.Text = selectedRow.Cells[4].Value.ToString();
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
        private void addParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbfname.Text == "" || tblname.Text == "" || tbemail.Text == "" || tbmob_no.Text == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    bool res = client.AddParticipant(tbfname.Text, tblname.Text, Convert.ToInt64(tbmob_no.Text), tbemail.Text);
                    ShowParticipant();
                    if (res)
                    {
                        ErrMsg.Text = "Participant Added!!";
                        ClearTextBoxes();
                    }
                    else
                    {
                        ErrMsg.Text = "Participant Not Added!!";
                    }
                }
            }
            catch(Exception ex) {
                ErrMsg.Text = ex.Message;
            }
        }
       
        private void deleteParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbfname.Text == "" || tblname.Text == "" || tbemail.Text == "" || tbmob_no.Text == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    bool res = client.DeleteParticipant(Convert.ToInt32(selectedRow.Cells[0].Value));
                    ShowParticipant();
                    if (res)
                    {
                        ErrMsg.Text = "Participant Deleted!!";
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

        private void btnvenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venue venue = new Venue();
            venue.ShowDialog();
        }

        private void tblname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

