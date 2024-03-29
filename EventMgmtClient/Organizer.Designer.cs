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
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbcontactno = new System.Windows.Forms.TextBox();
            this.tborgname = new System.Windows.Forms.TextBox();
            this.org_email = new System.Windows.Forms.Label();
            this.org_contact = new System.Windows.Forms.Label();
            this.org_name = new System.Windows.Forms.Label();
            this.deleteOrganizer = new System.Windows.Forms.Button();
            this.addOrganizer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizerDG)).BeginInit();
            this.SuspendLayout();
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
            this.OrganizerDG.Location = new System.Drawing.Point(964, 220);
            this.OrganizerDG.Name = "OrganizerDG";
            this.OrganizerDG.RowHeadersWidth = 62;
            this.OrganizerDG.RowTemplate.Height = 28;
            this.OrganizerDG.Size = new System.Drawing.Size(541, 448);
            this.OrganizerDG.TabIndex = 42;
            this.OrganizerDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrganizerDG_CellClick);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(673, 424);
            this.tbemail.MinimumSize = new System.Drawing.Size(4, 50);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(196, 50);
            this.tbemail.TabIndex = 41;
            // 
            // tbcontactno
            // 
            this.tbcontactno.Location = new System.Drawing.Point(673, 333);
            this.tbcontactno.Name = "tbcontactno";
            this.tbcontactno.Size = new System.Drawing.Size(196, 26);
            this.tbcontactno.TabIndex = 40;
            // 
            // tborgname
            // 
            this.tborgname.Location = new System.Drawing.Point(673, 249);
            this.tborgname.MinimumSize = new System.Drawing.Size(4, 50);
            this.tborgname.Name = "tborgname";
            this.tborgname.Size = new System.Drawing.Size(196, 50);
            this.tborgname.TabIndex = 39;
            // 
            // org_email
            // 
            this.org_email.AutoSize = true;
            this.org_email.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org_email.Location = new System.Drawing.Point(484, 424);
            this.org_email.Name = "org_email";
            this.org_email.Size = new System.Drawing.Size(57, 22);
            this.org_email.TabIndex = 38;
            this.org_email.Text = "Email";
            // 
            // org_contact
            // 
            this.org_contact.AutoSize = true;
            this.org_contact.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org_contact.Location = new System.Drawing.Point(484, 336);
            this.org_contact.Name = "org_contact";
            this.org_contact.Size = new System.Drawing.Size(102, 22);
            this.org_contact.TabIndex = 37;
            this.org_contact.Text = "Mobile No.";
            // 
            // org_name
            // 
            this.org_name.AutoSize = true;
            this.org_name.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.org_name.Location = new System.Drawing.Point(484, 252);
            this.org_name.Name = "org_name";
            this.org_name.Size = new System.Drawing.Size(88, 22);
            this.org_name.TabIndex = 36;
            this.org_name.Text = "Organizer";
            // 
            // deleteOrganizer
            // 
            this.deleteOrganizer.BackColor = System.Drawing.Color.Red;
            this.deleteOrganizer.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrganizer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteOrganizer.Location = new System.Drawing.Point(719, 595);
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
            this.addOrganizer.Location = new System.Drawing.Point(531, 595);
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
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrganizerDG);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbcontactno);
            this.Controls.Add(this.tborgname);
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
            this.Controls.SetChildIndex(this.tborgname, 0);
            this.Controls.SetChildIndex(this.tbcontactno, 0);
            this.Controls.SetChildIndex(this.tbemail, 0);
            this.Controls.SetChildIndex(this.OrganizerDG, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ErrMsg, 0);
            ((System.ComponentModel.ISupportInitialize)(this.OrganizerDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView OrganizerDG;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbcontactno;
        private System.Windows.Forms.TextBox tborgname;
        private System.Windows.Forms.Label org_email;
        private System.Windows.Forms.Label org_contact;
        private System.Windows.Forms.Label org_name;
        private System.Windows.Forms.Button deleteOrganizer;
        private System.Windows.Forms.Button addOrganizer;
    }
}