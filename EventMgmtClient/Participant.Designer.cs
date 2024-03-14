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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ParticipantDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addParticipant
            // 
            this.addParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addParticipant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addParticipant.Location = new System.Drawing.Point(383, 584);
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
            this.deleteParticipant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteParticipant.Location = new System.Drawing.Point(571, 584);
            this.deleteParticipant.Name = "deleteParticipant";
            this.deleteParticipant.Size = new System.Drawing.Size(96, 59);
            this.deleteParticipant.TabIndex = 1;
            this.deleteParticipant.Text = "Delete";
            this.deleteParticipant.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(258, 714);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(336, 241);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(86, 20);
            this.fname.TabIndex = 3;
            this.fname.Text = "First Name";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(336, 325);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(86, 20);
            this.lname.TabIndex = 4;
            this.lname.Text = "Last Name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(336, 413);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(48, 20);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            // 
            // mob_no
            // 
            this.mob_no.AutoSize = true;
            this.mob_no.Location = new System.Drawing.Point(336, 490);
            this.mob_no.Name = "mob_no";
            this.mob_no.Size = new System.Drawing.Size(115, 20);
            this.mob_no.TabIndex = 6;
            this.mob_no.Text = "Mobile Number";
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(525, 238);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(168, 26);
            this.tbfname.TabIndex = 7;
            // 
            // tblname
            // 
            this.tblname.Location = new System.Drawing.Point(525, 322);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(168, 26);
            this.tblname.TabIndex = 8;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(525, 413);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(168, 26);
            this.tbemail.TabIndex = 9;
            // 
            // tbmob_no
            // 
            this.tbmob_no.Location = new System.Drawing.Point(525, 484);
            this.tbmob_no.Name = "tbmob_no";
            this.tbmob_no.Size = new System.Drawing.Size(168, 26);
            this.tbmob_no.TabIndex = 10;
            // 
            // ParticipantDG
            // 
            this.ParticipantDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ParticipantDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParticipantDG.Location = new System.Drawing.Point(873, 181);
            this.ParticipantDG.Name = "ParticipantDG";
            this.ParticipantDG.RowHeadersWidth = 62;
            this.ParticipantDG.RowTemplate.Height = 28;
            this.ParticipantDG.Size = new System.Drawing.Size(605, 252);
            this.ParticipantDG.TabIndex = 11;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = typeof(System.Data.DataSet);
            this.dataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Event Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(693, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Participant";
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 842);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParticipantDG);
            this.Controls.Add(this.tbmob_no);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tblname);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.mob_no);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.deleteParticipant);
            this.Controls.Add(this.addParticipant);
            this.Name = "Participant";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Participant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ParticipantDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addParticipant;
        private System.Windows.Forms.Button deleteParticipant;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

