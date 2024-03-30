namespace EventMgmtClient
{
    partial class Participant
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
            this.components = new System.ComponentModel.Container();
            this.addParticipant = new System.Windows.Forms.Button();
            this.deleteParticipant = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.mob_no = new System.Windows.Forms.Label();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.tblname = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbmob_no = new System.Windows.Forms.TextBox();
            this.ParticipantDG = new System.Windows.Forms.DataGridView();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblpart = new System.Windows.Forms.Label();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.organizerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organizerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.organizerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.updateParticipant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ParticipantDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // addParticipant
            // 
            this.addParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addParticipant.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addParticipant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addParticipant.Location = new System.Drawing.Point(636, 550);
            this.addParticipant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addParticipant.Name = "addParticipant";
            this.addParticipant.Size = new System.Drawing.Size(96, 59);
            this.addParticipant.TabIndex = 0;
            this.addParticipant.Text = "Add";
            this.addParticipant.UseVisualStyleBackColor = false;
            this.addParticipant.Click += new System.EventHandler(this.addParticipant_Click);
            // 
            // deleteParticipant
            // 
            this.deleteParticipant.BackColor = System.Drawing.Color.Red;
            this.deleteParticipant.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteParticipant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteParticipant.Location = new System.Drawing.Point(398, 550);
            this.deleteParticipant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteParticipant.Name = "deleteParticipant";
            this.deleteParticipant.Size = new System.Drawing.Size(96, 59);
            this.deleteParticipant.TabIndex = 1;
            this.deleteParticipant.Text = "Delete";
            this.deleteParticipant.UseVisualStyleBackColor = false;
            this.deleteParticipant.Click += new System.EventHandler(this.deleteParticipant_Click);
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(394, 250);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(98, 22);
            this.fname.TabIndex = 3;
            this.fname.Text = "First Name";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(394, 312);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(94, 22);
            this.lname.TabIndex = 4;
            this.lname.Text = "Last Name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(394, 375);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(57, 22);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            // 
            // mob_no
            // 
            this.mob_no.AutoSize = true;
            this.mob_no.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mob_no.Location = new System.Drawing.Point(394, 438);
            this.mob_no.Name = "mob_no";
            this.mob_no.Size = new System.Drawing.Size(136, 22);
            this.mob_no.TabIndex = 6;
            this.mob_no.Text = "Mobile Number";
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(562, 250);
            this.tbfname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(168, 26);
            this.tbfname.TabIndex = 7;
            // 
            // tblname
            // 
            this.tblname.Location = new System.Drawing.Point(562, 312);
            this.tblname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(168, 26);
            this.tblname.TabIndex = 8;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(562, 375);
            this.tbemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(168, 26);
            this.tbemail.TabIndex = 9;
            // 
            // tbmob_no
            // 
            this.tbmob_no.Location = new System.Drawing.Point(562, 438);
            this.tbmob_no.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmob_no.Name = "tbmob_no";
            this.tbmob_no.Size = new System.Drawing.Size(168, 26);
            this.tbmob_no.TabIndex = 10;
            // 
            // ParticipantDG
            // 
            this.ParticipantDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ParticipantDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParticipantDG.Location = new System.Drawing.Point(844, 250);
            this.ParticipantDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParticipantDG.Name = "ParticipantDG";
            this.ParticipantDG.RowHeadersWidth = 62;
            this.ParticipantDG.RowTemplate.Height = 28;
            this.ParticipantDG.Size = new System.Drawing.Size(900, 500);
            this.ParticipantDG.TabIndex = 11;
            this.ParticipantDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Participant_CellClick);
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = typeof(System.Data.DataSet);
            this.dataSetBindingSource.Position = 0;
            // 
            // lblpart
            // 
            this.lblpart.AutoSize = true;
            this.lblpart.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpart.Location = new System.Drawing.Point(392, 168);
            this.lblpart.Name = "lblpart";
            this.lblpart.Size = new System.Drawing.Size(153, 36);
            this.lblpart.TabIndex = 13;
            this.lblpart.Text = "Participant";
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.Location = new System.Drawing.Point(496, 731);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 20);
            this.ErrMsg.TabIndex = 14;
            // 
            // organizerBindingSource
            // 
            this.organizerBindingSource.DataSource = typeof(EventMgmtClient.ServiceReference1.Organizer);
            // 
            // organizerBindingSource1
            // 
            this.organizerBindingSource1.DataSource = typeof(EventMgmtClient.ServiceReference1.Organizer);
            // 
            // organizerBindingSource2
            // 
            this.organizerBindingSource2.DataSource = typeof(EventMgmtClient.ServiceReference1.Organizer);
            // 
            // updateParticipant
            // 
            this.updateParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateParticipant.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateParticipant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateParticipant.Location = new System.Drawing.Point(519, 625);
            this.updateParticipant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateParticipant.Name = "updateParticipant";
            this.updateParticipant.Size = new System.Drawing.Size(96, 59);
            this.updateParticipant.TabIndex = 40;
            this.updateParticipant.Text = "Update";
            this.updateParticipant.UseVisualStyleBackColor = false;
            this.updateParticipant.Click += new System.EventHandler(this.updateParticipant_Click);
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 941);
            this.Controls.Add(this.updateParticipant);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.lblpart);
            this.Controls.Add(this.ParticipantDG);
            this.Controls.Add(this.tbmob_no);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tblname);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.mob_no);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.deleteParticipant);
            this.Controls.Add(this.addParticipant);
            this.Name = "Participant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Participant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Participant_Load);
            this.Controls.SetChildIndex(this.addParticipant, 0);
            this.Controls.SetChildIndex(this.deleteParticipant, 0);
            this.Controls.SetChildIndex(this.fname, 0);
            this.Controls.SetChildIndex(this.lname, 0);
            this.Controls.SetChildIndex(this.email, 0);
            this.Controls.SetChildIndex(this.mob_no, 0);
            this.Controls.SetChildIndex(this.tbfname, 0);
            this.Controls.SetChildIndex(this.tblname, 0);
            this.Controls.SetChildIndex(this.tbemail, 0);
            this.Controls.SetChildIndex(this.tbmob_no, 0);
            this.Controls.SetChildIndex(this.ParticipantDG, 0);
            this.Controls.SetChildIndex(this.lblpart, 0);
            this.Controls.SetChildIndex(this.ErrMsg, 0);
            this.Controls.SetChildIndex(this.updateParticipant, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ParticipantDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addParticipant;
        private System.Windows.Forms.Button deleteParticipant;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label mob_no;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbmob_no;
        private System.Windows.Forms.DataGridView ParticipantDG;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dglname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmob_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgemail;
        private System.Windows.Forms.BindingSource participantBindingSource;
        private System.Windows.Forms.Label lblpart;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.BindingSource organizerBindingSource;
        private System.Windows.Forms.BindingSource organizerBindingSource2;
        private System.Windows.Forms.BindingSource organizerBindingSource1;
        private System.Windows.Forms.Button updateParticipant;
    }
}

