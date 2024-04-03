namespace EventMgmtClient
{
    partial class Organizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrganizerDG = new System.Windows.Forms.DataGridView();
            this.tbcontactno = new System.Windows.Forms.TextBox();
            this.org_email = new System.Windows.Forms.Label();
            this.org_contact = new System.Windows.Forms.Label();
            this.org_name = new System.Windows.Forms.Label();
            this.deleteOrganizer = new System.Windows.Forms.Button();
            this.addOrganizer = new System.Windows.Forms.Button();
            this.updateOrganizer = new System.Windows.Forms.Button();
            this.tborgname = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizerDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.BackColor = System.Drawing.Color.Transparent;
            this.ErrMsg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMsg.ForeColor = System.Drawing.Color.Crimson;
            this.ErrMsg.Location = new System.Drawing.Point(533, 865);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 26);
            this.ErrMsg.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(882, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 41);
            this.label2.TabIndex = 44;
            this.label2.Text = "Organizer";
            // 
            // OrganizerDG
            // 
            this.OrganizerDG.BackgroundColor = System.Drawing.Color.LightCyan;
            this.OrganizerDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrganizerDG.DefaultCellStyle = dataGridViewCellStyle1;
            this.OrganizerDG.Location = new System.Drawing.Point(959, 466);
            this.OrganizerDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrganizerDG.Name = "OrganizerDG";
            this.OrganizerDG.RowHeadersWidth = 62;
            this.OrganizerDG.RowTemplate.Height = 28;
            this.OrganizerDG.Size = new System.Drawing.Size(744, 501);
            this.OrganizerDG.TabIndex = 42;
            this.OrganizerDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrganizerDG_CellClick);
            // 
            // tbcontactno
            // 
            this.tbcontactno.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontactno.Location = new System.Drawing.Point(596, 569);
            this.tbcontactno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcontactno.Name = "tbcontactno";
            this.tbcontactno.Size = new System.Drawing.Size(196, 32);
            this.tbcontactno.TabIndex = 40;
            // 
            // org_email
            // 
            this.org_email.AutoSize = true;
            this.org_email.BackColor = System.Drawing.Color.Transparent;
            this.org_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org_email.ForeColor = System.Drawing.Color.DarkBlue;
            this.org_email.Location = new System.Drawing.Point(371, 643);
            this.org_email.Name = "org_email";
            this.org_email.Size = new System.Drawing.Size(68, 27);
            this.org_email.TabIndex = 38;
            this.org_email.Text = "Email";
            // 
            // org_contact
            // 
            this.org_contact.AutoSize = true;
            this.org_contact.BackColor = System.Drawing.Color.Transparent;
            this.org_contact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org_contact.ForeColor = System.Drawing.Color.DarkBlue;
            this.org_contact.Location = new System.Drawing.Point(371, 569);
            this.org_contact.Name = "org_contact";
            this.org_contact.Size = new System.Drawing.Size(121, 27);
            this.org_contact.TabIndex = 37;
            this.org_contact.Text = "Mobile No.";
            // 
            // org_name
            // 
            this.org_name.AutoSize = true;
            this.org_name.BackColor = System.Drawing.Color.Transparent;
            this.org_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org_name.ForeColor = System.Drawing.Color.DarkBlue;
            this.org_name.Location = new System.Drawing.Point(371, 493);
            this.org_name.Name = "org_name";
            this.org_name.Size = new System.Drawing.Size(106, 27);
            this.org_name.TabIndex = 36;
            this.org_name.Text = "Organizer";
            // 
            // deleteOrganizer
            // 
            this.deleteOrganizer.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteOrganizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.deleteOrganizer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrganizer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteOrganizer.Location = new System.Drawing.Point(427, 756);
            this.deleteOrganizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteOrganizer.Name = "deleteOrganizer";
            this.deleteOrganizer.Size = new System.Drawing.Size(96, 59);
            this.deleteOrganizer.TabIndex = 34;
            this.deleteOrganizer.Text = "Delete";
            this.deleteOrganizer.UseVisualStyleBackColor = false;
            this.deleteOrganizer.Click += new System.EventHandler(this.deleteOrganizer_Click);
            // 
            // addOrganizer
            // 
            this.addOrganizer.BackColor = System.Drawing.Color.LimeGreen;
            this.addOrganizer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrganizer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addOrganizer.Location = new System.Drawing.Point(697, 756);
            this.addOrganizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addOrganizer.Name = "addOrganizer";
            this.addOrganizer.Size = new System.Drawing.Size(96, 59);
            this.addOrganizer.TabIndex = 33;
            this.addOrganizer.Text = "Add";
            this.addOrganizer.UseVisualStyleBackColor = false;
            this.addOrganizer.Click += new System.EventHandler(this.addOrganizer_Click);
            // 
            // updateOrganizer
            // 
            this.updateOrganizer.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateOrganizer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOrganizer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateOrganizer.Location = new System.Drawing.Point(562, 756);
            this.updateOrganizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateOrganizer.Name = "updateOrganizer";
            this.updateOrganizer.Size = new System.Drawing.Size(96, 59);
            this.updateOrganizer.TabIndex = 46;
            this.updateOrganizer.Text = "Update";
            this.updateOrganizer.UseVisualStyleBackColor = false;
            this.updateOrganizer.Click += new System.EventHandler(this.updateOrganizer_Click);
            // 
            // tborgname
            // 
            this.tborgname.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tborgname.Location = new System.Drawing.Point(596, 493);
            this.tborgname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tborgname.Name = "tborgname";
            this.tborgname.Size = new System.Drawing.Size(196, 32);
            this.tborgname.TabIndex = 47;
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(596, 643);
            this.tbemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(196, 32);
            this.tbemail.TabIndex = 48;
            // 
            // Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1748, 900);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tborgname);
            this.Controls.Add(this.updateOrganizer);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrganizerDG);
            this.Controls.Add(this.tbcontactno);
            this.Controls.Add(this.org_email);
            this.Controls.Add(this.org_contact);
            this.Controls.Add(this.org_name);
            this.Controls.Add(this.deleteOrganizer);
            this.Controls.Add(this.addOrganizer);
            this.Name = "Organizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Organizer_Load);
            this.Controls.SetChildIndex(this.addOrganizer, 0);
            this.Controls.SetChildIndex(this.deleteOrganizer, 0);
            this.Controls.SetChildIndex(this.org_name, 0);
            this.Controls.SetChildIndex(this.org_contact, 0);
            this.Controls.SetChildIndex(this.org_email, 0);
            this.Controls.SetChildIndex(this.tbcontactno, 0);
            this.Controls.SetChildIndex(this.OrganizerDG, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ErrMsg, 0);
            this.Controls.SetChildIndex(this.updateOrganizer, 0);
            this.Controls.SetChildIndex(this.tborgname, 0);
            this.Controls.SetChildIndex(this.tbemail, 0);
            ((System.ComponentModel.ISupportInitialize)(this.OrganizerDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView OrganizerDG;
        private System.Windows.Forms.TextBox tbcontactno;
        private System.Windows.Forms.Label org_email;
        private System.Windows.Forms.Label org_contact;
        private System.Windows.Forms.Label org_name;
        private System.Windows.Forms.Button deleteOrganizer;
        private System.Windows.Forms.Button addOrganizer;
        private System.Windows.Forms.Button updateOrganizer;
        private System.Windows.Forms.TextBox tborgname;
        private System.Windows.Forms.TextBox tbemail;
    }
}