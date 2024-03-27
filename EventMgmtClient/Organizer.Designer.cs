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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnvenue = new System.Windows.Forms.Button();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrganizerDG = new System.Windows.Forms.DataGridView();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbcontactno = new System.Windows.Forms.TextBox();
            this.tborgname = new System.Windows.Forms.TextBox();
            this.org_email = new System.Windows.Forms.Label();
            this.org_contact = new System.Windows.Forms.Label();
            this.org_name = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteOrganizer = new System.Windows.Forms.Button();
            this.addOrganizer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizerDG)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(319, 118);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 22);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Participant";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnvenue
            // 
            this.btnvenue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvenue.Location = new System.Drawing.Point(110, 104);
            this.btnvenue.Name = "btnvenue";
            this.btnvenue.Size = new System.Drawing.Size(113, 49);
            this.btnvenue.TabIndex = 32;
            this.btnvenue.Text = "Venue";
            this.btnvenue.UseVisualStyleBackColor = true;
            this.btnvenue.Click += new System.EventHandler(this.btnvenue_Click);
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.Location = new System.Drawing.Point(514, 741);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 20);
            this.ErrMsg.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(824, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 36);
            this.label2.TabIndex = 44;
            this.label2.Text = "Organizer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(672, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 46);
            this.label1.TabIndex = 43;
            this.label1.Text = "Event Management System";
            // 
            // OrganizerDG
            // 
            this.OrganizerDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrganizerDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrganizerDG.DefaultCellStyle = dataGridViewCellStyle1;
            this.OrganizerDG.Location = new System.Drawing.Point(830, 225);
            this.OrganizerDG.Name = "OrganizerDG";
            this.OrganizerDG.RowHeadersWidth = 62;
            this.OrganizerDG.RowTemplate.Height = 28;
            this.OrganizerDG.Size = new System.Drawing.Size(678, 448);
            this.OrganizerDG.TabIndex = 42;
            this.OrganizerDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrganizerDG_CellClick);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(543, 423);
            this.tbemail.MinimumSize = new System.Drawing.Size(4, 50);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(196, 26);
            this.tbemail.TabIndex = 41;
            // 
            // tbcontactno
            // 
            this.tbcontactno.Location = new System.Drawing.Point(543, 332);
            this.tbcontactno.Name = "tbcontactno";
            this.tbcontactno.Size = new System.Drawing.Size(196, 26);
            this.tbcontactno.TabIndex = 40;
            // 
            // tborgname
            // 
            this.tborgname.Location = new System.Drawing.Point(543, 248);
            this.tborgname.MinimumSize = new System.Drawing.Size(4, 50);
            this.tborgname.Name = "tborgname";
            this.tborgname.Size = new System.Drawing.Size(196, 26);
            this.tborgname.TabIndex = 39;
            // 
            // org_email
            // 
            this.org_email.AutoSize = true;
            this.org_email.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org_email.Location = new System.Drawing.Point(354, 423);
            this.org_email.Name = "org_email";
            this.org_email.Size = new System.Drawing.Size(57, 22);
            this.org_email.TabIndex = 38;
            this.org_email.Text = "Email";
            // 
            // org_contact
            // 
            this.org_contact.AutoSize = true;
            this.org_contact.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org_contact.Location = new System.Drawing.Point(354, 335);
            this.org_contact.Name = "org_contact";
            this.org_contact.Size = new System.Drawing.Size(102, 22);
            this.org_contact.TabIndex = 37;
            this.org_contact.Text = "Mobile No.";
            // 
            // org_name
            // 
            this.org_name.AutoSize = true;
            this.org_name.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org_name.Location = new System.Drawing.Point(354, 251);
            this.org_name.Name = "org_name";
            this.org_name.Size = new System.Drawing.Size(88, 22);
            this.org_name.TabIndex = 36;
            this.org_name.Text = "Organizer";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 159);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(258, 714);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // deleteOrganizer
            // 
            this.deleteOrganizer.BackColor = System.Drawing.Color.Red;
            this.deleteOrganizer.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrganizer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteOrganizer.Location = new System.Drawing.Point(589, 594);
            this.deleteOrganizer.Name = "deleteOrganizer";
            this.deleteOrganizer.Size = new System.Drawing.Size(96, 59);
            this.deleteOrganizer.TabIndex = 34;
            this.deleteOrganizer.Text = "Delete";
            this.deleteOrganizer.UseVisualStyleBackColor = false;
            this.deleteOrganizer.Click += new System.EventHandler(this.deleteOrganizer_Click);
            // 
            // addOrganizer
            // 
            this.addOrganizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addOrganizer.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrganizer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addOrganizer.Location = new System.Drawing.Point(401, 594);
            this.addOrganizer.Name = "addOrganizer";
            this.addOrganizer.Size = new System.Drawing.Size(96, 59);
            this.addOrganizer.TabIndex = 33;
            this.addOrganizer.Text = "Add";
            this.addOrganizer.UseVisualStyleBackColor = false;
            this.addOrganizer.Click += new System.EventHandler(this.addOrganizer_Click);
            // 
            // Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1745, 897);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnvenue);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrganizerDG);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbcontactno);
            this.Controls.Add(this.tborgname);
            this.Controls.Add(this.org_email);
            this.Controls.Add(this.org_contact);
            this.Controls.Add(this.org_name);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.deleteOrganizer);
            this.Controls.Add(this.addOrganizer);
            this.Name = "Organizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Organizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrganizerDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnvenue;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OrganizerDG;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbcontactno;
        private System.Windows.Forms.TextBox tborgname;
        private System.Windows.Forms.Label org_email;
        private System.Windows.Forms.Label org_contact;
        private System.Windows.Forms.Label org_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button deleteOrganizer;
        private System.Windows.Forms.Button addOrganizer;
    }
}