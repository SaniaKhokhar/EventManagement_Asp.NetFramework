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
    public partial class Venue : Form1
    {
        public Venue()
        {
            InitializeComponent();
        }

        private void Venue_Load(object sender, EventArgs e)
        {
            ShowVenue();
        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("WSDualHttpBinding_IService1");
        void ShowVenue()
        {
            DataSet ds = new DataSet();
            ds = client.GetVenues();
            VenueDG.DataSource = ds.Tables[0];
        }
        private void ClearTextBoxes()
        {
            tbvenuename.Text = "";
            tblocation.Text = "";
            tbcapacity.Text = "";
            
        }

        DataGridViewRow selectedRow;
        private void VenueDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < VenueDG.Rows.Count)
                {
                    selectedRow = VenueDG.Rows[e.RowIndex];
                    tbvenuename.Text = selectedRow.Cells[1].Value.ToString();
                    tblocation.Text = selectedRow.Cells[2].Value.ToString();
                    tbcapacity.Text = selectedRow.Cells[3].Value.ToString();
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

        private void addVenue_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbvenuename.Text == "" || tblocation.Text == "" || tbcapacity.Text == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else if (selectedRow != null)
                {
                    MessageBox.Show("You should Update it.!!\n click on 'Update' button");
                }
                else
                {
                    bool res = client.AddVenue(tbvenuename.Text, tblocation.Text, Convert.ToInt32(tbcapacity.Text));
                    ShowVenue();
                    if (res)
                    {
                        ErrMsg.Text = "Venue Added!!";
                        ClearTextBoxes();
                    }
                    else
                    {
                        ErrMsg.Text = "Venue Not Added!!";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        private void deleteVenue_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = VenueDG.CurrentRow;
                if (selectedRow == null)
                {
                    ErrMsg.Text = "Please select a row to delete.";
                }
                if (tbvenuename.Text == "" || tblocation.Text == "" || tbcapacity.Text == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    
                    bool res = client.DeleteVenue(Convert.ToInt32(selectedRow.Cells[0].Value));                    
                    ShowVenue();

                    if (res)
                    {
                        ErrMsg.Text = "Venue Deleted!!";
                        ClearTextBoxes();
                    }
                    else
                    {
                        ErrMsg.Text = "Not Deleted";
                    }
                }

            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        private void updateParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbvenuename.Text == "" || tblocation.Text == "" || tbcapacity.Text == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    int vid = Convert.ToInt32(selectedRow.Cells[0].Value);

                    bool res = client.UpdateVenue(vid, tbvenuename.Text, tblocation.Text, Convert.ToInt32(tbcapacity.Text));
                    ShowVenue();
                    if (res)
                    {
                        ErrMsg.Text = "Venue Updated!!";
                        ClearTextBoxes();
                    }
                    else
                    {
                        ErrMsg.Text = "Venue Not Updated!!";
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
