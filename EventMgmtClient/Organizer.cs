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
    public partial class Organizer : Form1
    {
        public Organizer()
        {
            InitializeComponent();
        }

        private void Organizer_Load(object sender, EventArgs e)
        {
            ShowOrganizer();
        }

        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("WSDualHttpBinding_IService1");
        void ShowOrganizer()
        {
            DataSet ds = new DataSet();
            ds = client.GetOrganizers();
            OrganizerDG.DataSource = ds.Tables[0];
        }
        private void ClearTextBoxes()
        {
            tborgname.Text = "";
            tbcontactno.Text = "";
            tbemail.Text = "";

        }

        DataGridViewRow selectedRow;

        private void OrganizerDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < OrganizerDG.Rows.Count)
                {
                    selectedRow = OrganizerDG.Rows[e.RowIndex];
                    tborgname.Text = selectedRow.Cells[1].Value.ToString();
                    tbcontactno.Text = selectedRow.Cells[2].Value.ToString();
                    tbemail.Text = selectedRow.Cells[3].Value.ToString();
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

        private void addOrganizer_Click(object sender, EventArgs e)
        {
            try
            {
                if (tborgname.Text == "" || tbcontactno.Text == "" || tbemail.Text == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    bool res = client.AddOrganizer(tborgname.Text, Convert.ToInt64(tbcontactno.Text), tbemail.Text);
                    ShowOrganizer();
                    if (res)
                    {
                        ErrMsg.Text = "Organizer Added Successfully!!";
                        ClearTextBoxes();
                    }
                    else
                    {
                        ErrMsg.Text = "Organizer Not Added!!";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        private void deleteOrganizer_Click(object sender, EventArgs e)
        {
            try
            {
                if (tborgname.Text == "" || tbcontactno.Text == "" || tbemail.Text == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {

                    bool res = client.DeleteOrganizer(Convert.ToInt32(selectedRow.Cells[0].Value));
                    ShowOrganizer();

                    if (res)
                    {
                        ErrMsg.Text = "Organizer Deleted Successfully!!";
                        ClearTextBoxes();
                    }
                    else
                    {
                        ErrMsg.Text = "Organizer Not deleted";
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
