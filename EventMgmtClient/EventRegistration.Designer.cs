namespace EventMgmtClient
{
    partial class EventRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblpart = new System.Windows.Forms.Label();
            this.cmbpart = new System.Windows.Forms.ComboBox();
            this.cmbevent = new System.Windows.Forms.ComboBox();
            this.dtpreg_date = new System.Windows.Forms.DateTimePicker();
            this.addEvent = new System.Windows.Forms.Button();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.RegDG = new System.Windows.Forms.DataGridView();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.nudfees = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblevent = new System.Windows.Forms.Label();
            this.lblreg_date = new System.Windows.Forms.Label();
            this.lblfees = new System.Windows.Forms.Label();
            this.updateOrganizer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RegDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpart
            // 
            this.lblpart.AutoSize = true;
            this.lblpart.BackColor = System.Drawing.Color.Transparent;
            this.lblpart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpart.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblpart.Location = new System.Drawing.Point(181, 414);
            this.lblpart.Name = "lblpart";
            this.lblpart.Size = new System.Drawing.Size(117, 27);
            this.lblpart.TabIndex = 40;
            this.lblpart.Text = "Participant";
            // 
            // cmbpart
            // 
            this.cmbpart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbpart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpart.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpart.FormattingEnabled = true;
            this.cmbpart.ItemHeight = 25;
            this.cmbpart.Location = new System.Drawing.Point(406, 414);
            this.cmbpart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbpart.Name = "cmbpart";
            this.cmbpart.Size = new System.Drawing.Size(391, 33);
            this.cmbpart.TabIndex = 53;
            // 
            // cmbevent
            // 
            this.cmbevent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbevent.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbevent.FormattingEnabled = true;
            this.cmbevent.Location = new System.Drawing.Point(406, 490);
            this.cmbevent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbevent.Name = "cmbevent";
            this.cmbevent.Size = new System.Drawing.Size(224, 33);
            this.cmbevent.TabIndex = 54;
            // 
            // dtpreg_date
            // 
            this.dtpreg_date.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpreg_date.Location = new System.Drawing.Point(406, 564);
            this.dtpreg_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpreg_date.Name = "dtpreg_date";
            this.dtpreg_date.Size = new System.Drawing.Size(224, 33);
            this.dtpreg_date.TabIndex = 55;
            this.dtpreg_date.Value = new System.DateTime(2024, 3, 30, 0, 0, 0, 0);
            // 
            // addEvent
            // 
            this.addEvent.BackColor = System.Drawing.Color.LimeGreen;
            this.addEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.addEvent.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEvent.Location = new System.Drawing.Point(535, 740);
            this.addEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(96, 59);
            this.addEvent.TabIndex = 57;
            this.addEvent.Text = "Add";
            this.addEvent.UseVisualStyleBackColor = false;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // deleteEvent
            // 
            this.deleteEvent.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.deleteEvent.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteEvent.Location = new System.Drawing.Point(237, 740);
            this.deleteEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(96, 59);
            this.deleteEvent.TabIndex = 58;
            this.deleteEvent.Text = "Delete";
            this.deleteEvent.UseVisualStyleBackColor = false;
            this.deleteEvent.Click += new System.EventHandler(this.deleteEvent_Click);
            // 
            // RegDG
            // 
            this.RegDG.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RegDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RegDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RegDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.RegDG.Location = new System.Drawing.Point(846, 415);
            this.RegDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegDG.Name = "RegDG";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RegDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RegDG.RowHeadersWidth = 62;
            this.RegDG.RowTemplate.Height = 28;
            this.RegDG.Size = new System.Drawing.Size(895, 459);
            this.RegDG.TabIndex = 59;
            this.RegDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegDG_CellClick);
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.BackColor = System.Drawing.Color.Transparent;
            this.ErrMsg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMsg.ForeColor = System.Drawing.Color.Crimson;
            this.ErrMsg.Location = new System.Drawing.Point(250, 848);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 26);
            this.ErrMsg.TabIndex = 60;
            // 
            // nudfees
            // 
            this.nudfees.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudfees.Location = new System.Drawing.Point(406, 640);
            this.nudfees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudfees.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudfees.Name = "nudfees";
            this.nudfees.Size = new System.Drawing.Size(225, 33);
            this.nudfees.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(818, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 41);
            this.label2.TabIndex = 62;
            this.label2.Text = "Event Registration";
            // 
            // lblevent
            // 
            this.lblevent.AutoSize = true;
            this.lblevent.BackColor = System.Drawing.Color.Transparent;
            this.lblevent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevent.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblevent.Location = new System.Drawing.Point(181, 490);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(69, 27);
            this.lblevent.TabIndex = 63;
            this.lblevent.Text = "Event";
            // 
            // lblreg_date
            // 
            this.lblreg_date.AutoSize = true;
            this.lblreg_date.BackColor = System.Drawing.Color.Transparent;
            this.lblreg_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg_date.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblreg_date.Location = new System.Drawing.Point(181, 564);
            this.lblreg_date.Name = "lblreg_date";
            this.lblreg_date.Size = new System.Drawing.Size(180, 27);
            this.lblreg_date.TabIndex = 64;
            this.lblreg_date.Text = "Registration Date";
            // 
            // lblfees
            // 
            this.lblfees.AutoSize = true;
            this.lblfees.BackColor = System.Drawing.Color.Transparent;
            this.lblfees.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfees.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblfees.Location = new System.Drawing.Point(181, 640);
            this.lblfees.Name = "lblfees";
            this.lblfees.Size = new System.Drawing.Size(56, 27);
            this.lblfees.TabIndex = 65;
            this.lblfees.Text = "Fees";
            // 
            // updateOrganizer
            // 
            this.updateOrganizer.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateOrganizer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOrganizer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateOrganizer.Location = new System.Drawing.Point(389, 740);
            this.updateOrganizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateOrganizer.Name = "updateOrganizer";
            this.updateOrganizer.Size = new System.Drawing.Size(96, 59);
            this.updateOrganizer.TabIndex = 66;
            this.updateOrganizer.Text = "Update";
            this.updateOrganizer.UseVisualStyleBackColor = false;
            this.updateOrganizer.Click += new System.EventHandler(this.updateOrganizer_Click);
            // 
            // EventRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 900);
            this.Controls.Add(this.updateOrganizer);
            this.Controls.Add(this.lblfees);
            this.Controls.Add(this.lblreg_date);
            this.Controls.Add(this.lblevent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudfees);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.RegDG);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.dtpreg_date);
            this.Controls.Add(this.cmbevent);
            this.Controls.Add(this.cmbpart);
            this.Controls.Add(this.lblpart);
            this.Name = "EventRegistration";
            this.Text = "EventRegistration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EventRegistration_Load);
            this.Controls.SetChildIndex(this.lblpart, 0);
            this.Controls.SetChildIndex(this.cmbpart, 0);
            this.Controls.SetChildIndex(this.cmbevent, 0);
            this.Controls.SetChildIndex(this.dtpreg_date, 0);
            this.Controls.SetChildIndex(this.addEvent, 0);
            this.Controls.SetChildIndex(this.deleteEvent, 0);
            this.Controls.SetChildIndex(this.RegDG, 0);
            this.Controls.SetChildIndex(this.ErrMsg, 0);
            this.Controls.SetChildIndex(this.nudfees, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblevent, 0);
            this.Controls.SetChildIndex(this.lblreg_date, 0);
            this.Controls.SetChildIndex(this.lblfees, 0);
            this.Controls.SetChildIndex(this.updateOrganizer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RegDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpart;
        private System.Windows.Forms.ComboBox cmbpart;
        private System.Windows.Forms.ComboBox cmbevent;
        private System.Windows.Forms.DateTimePicker dtpreg_date;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.Button deleteEvent;
        private System.Windows.Forms.DataGridView RegDG;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.NumericUpDown nudfees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblevent;
        private System.Windows.Forms.Label lblreg_date;
        private System.Windows.Forms.Label lblfees;
        private System.Windows.Forms.Button updateOrganizer;
    }
}