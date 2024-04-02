namespace EventMgmtClient
{
    partial class Events
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.EventDG = new System.Windows.Forms.DataGridView();
            this.tbevent_name = new System.Windows.Forms.TextBox();
            this.lblevent_name = new System.Windows.Forms.Label();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.addEvent = new System.Windows.Forms.Button();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.dtpend_time = new System.Windows.Forms.DateTimePicker();
            this.dtpstart_time = new System.Windows.Forms.DateTimePicker();
            this.cmborg = new System.Windows.Forms.ComboBox();
            this.cmbvenue = new System.Windows.Forms.ComboBox();
            this.lblend_time = new System.Windows.Forms.Label();
            this.lblstart_time = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblvenue = new System.Windows.Forms.Label();
            this.lblorg = new System.Windows.Forms.Label();
            this.updateEvent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(902, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 41);
            this.label2.TabIndex = 39;
            this.label2.Text = "Events";
            // 
            // EventDG
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EventDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EventDG.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EventDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EventDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.EventDG.Location = new System.Drawing.Point(660, 369);
            this.EventDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventDG.Name = "EventDG";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EventDG.RowHeadersWidth = 62;
            this.EventDG.RowTemplate.Height = 28;
            this.EventDG.Size = new System.Drawing.Size(1107, 490);
            this.EventDG.TabIndex = 50;
            this.EventDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDG_CellClick);
            // 
            // tbevent_name
            // 
            this.tbevent_name.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbevent_name.Location = new System.Drawing.Point(403, 354);
            this.tbevent_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbevent_name.Name = "tbevent_name";
            this.tbevent_name.Size = new System.Drawing.Size(219, 33);
            this.tbevent_name.TabIndex = 46;
            // 
            // lblevent_name
            // 
            this.lblevent_name.AutoSize = true;
            this.lblevent_name.BackColor = System.Drawing.Color.Transparent;
            this.lblevent_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevent_name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblevent_name.Location = new System.Drawing.Point(178, 354);
            this.lblevent_name.Name = "lblevent_name";
            this.lblevent_name.Size = new System.Drawing.Size(132, 27);
            this.lblevent_name.TabIndex = 42;
            this.lblevent_name.Text = "Event Name";
            // 
            // deleteEvent
            // 
            this.deleteEvent.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.deleteEvent.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteEvent.Location = new System.Drawing.Point(268, 817);
            this.deleteEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(96, 59);
            this.deleteEvent.TabIndex = 41;
            this.deleteEvent.Text = "Delete";
            this.deleteEvent.UseVisualStyleBackColor = false;
            this.deleteEvent.Click += new System.EventHandler(this.deleteParticipant_Click);
            // 
            // addEvent
            // 
            this.addEvent.BackColor = System.Drawing.Color.LimeGreen;
            this.addEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.addEvent.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEvent.Location = new System.Drawing.Point(527, 817);
            this.addEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(96, 59);
            this.addEvent.TabIndex = 40;
            this.addEvent.Text = "Add";
            this.addEvent.UseVisualStyleBackColor = false;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // dtpdate
            // 
            this.dtpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Location = new System.Drawing.Point(403, 430);
            this.dtpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(219, 32);
            this.dtpdate.TabIndex = 51;
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.BackColor = System.Drawing.Color.Transparent;
            this.ErrMsg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMsg.ForeColor = System.Drawing.Color.Crimson;
            this.ErrMsg.Location = new System.Drawing.Point(392, 866);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 26);
            this.ErrMsg.TabIndex = 56;
            // 
            // dtpend_time
            // 
            this.dtpend_time.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpend_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpend_time.Location = new System.Drawing.Point(403, 504);
            this.dtpend_time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpend_time.Name = "dtpend_time";
            this.dtpend_time.Size = new System.Drawing.Size(219, 32);
            this.dtpend_time.TabIndex = 57;
            this.dtpend_time.Value = new System.DateTime(2024, 3, 29, 0, 0, 0, 0);
            // 
            // dtpstart_time
            // 
            this.dtpstart_time.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstart_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpstart_time.Location = new System.Drawing.Point(403, 580);
            this.dtpstart_time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpstart_time.Name = "dtpstart_time";
            this.dtpstart_time.Size = new System.Drawing.Size(219, 32);
            this.dtpstart_time.TabIndex = 58;
            this.dtpstart_time.Value = new System.DateTime(2024, 3, 29, 0, 0, 0, 0);
            // 
            // cmborg
            // 
            this.cmborg.DisplayMember = "OrganizerId";
            this.cmborg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmborg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmborg.FormattingEnabled = true;
            this.cmborg.Location = new System.Drawing.Point(403, 654);
            this.cmborg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmborg.Name = "cmborg";
            this.cmborg.Size = new System.Drawing.Size(219, 33);
            this.cmborg.TabIndex = 59;
            this.cmborg.ValueMember = "OrganizerId";
            this.cmborg.SelectedIndexChanged += new System.EventHandler(this.cmborg_SelectedIndexChanged);
            // 
            // cmbvenue
            // 
            this.cmbvenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvenue.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbvenue.FormattingEnabled = true;
            this.cmbvenue.Location = new System.Drawing.Point(403, 730);
            this.cmbvenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbvenue.Name = "cmbvenue";
            this.cmbvenue.Size = new System.Drawing.Size(219, 33);
            this.cmbvenue.TabIndex = 60;
            this.cmbvenue.SelectedIndexChanged += new System.EventHandler(this.cmbvenue_SelectedIndexChanged);
            // 
            // lblend_time
            // 
            this.lblend_time.AutoSize = true;
            this.lblend_time.BackColor = System.Drawing.Color.Transparent;
            this.lblend_time.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend_time.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblend_time.Location = new System.Drawing.Point(178, 580);
            this.lblend_time.Name = "lblend_time";
            this.lblend_time.Size = new System.Drawing.Size(105, 27);
            this.lblend_time.TabIndex = 62;
            this.lblend_time.Text = "End Time";
            // 
            // lblstart_time
            // 
            this.lblstart_time.AutoSize = true;
            this.lblstart_time.BackColor = System.Drawing.Color.Transparent;
            this.lblstart_time.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstart_time.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblstart_time.Location = new System.Drawing.Point(178, 504);
            this.lblstart_time.Name = "lblstart_time";
            this.lblstart_time.Size = new System.Drawing.Size(111, 27);
            this.lblstart_time.TabIndex = 63;
            this.lblstart_time.Text = "Start Time";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbldate.Location = new System.Drawing.Point(178, 430);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(58, 27);
            this.lbldate.TabIndex = 64;
            this.lbldate.Text = "Date";
            // 
            // lblvenue
            // 
            this.lblvenue.AutoSize = true;
            this.lblvenue.BackColor = System.Drawing.Color.Transparent;
            this.lblvenue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvenue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblvenue.Location = new System.Drawing.Point(178, 730);
            this.lblvenue.Name = "lblvenue";
            this.lblvenue.Size = new System.Drawing.Size(71, 27);
            this.lblvenue.TabIndex = 65;
            this.lblvenue.Text = "Venue";
            // 
            // lblorg
            // 
            this.lblorg.AutoSize = true;
            this.lblorg.BackColor = System.Drawing.Color.Transparent;
            this.lblorg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorg.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblorg.Location = new System.Drawing.Point(178, 654);
            this.lblorg.Name = "lblorg";
            this.lblorg.Size = new System.Drawing.Size(106, 27);
            this.lblorg.TabIndex = 66;
            this.lblorg.Text = "Organizer";
            // 
            // updateEvent
            // 
            this.updateEvent.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.updateEvent.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateEvent.Location = new System.Drawing.Point(397, 817);
            this.updateEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateEvent.Name = "updateEvent";
            this.updateEvent.Size = new System.Drawing.Size(96, 59);
            this.updateEvent.TabIndex = 67;
            this.updateEvent.Text = "Update";
            this.updateEvent.UseVisualStyleBackColor = false;
            this.updateEvent.Click += new System.EventHandler(this.updateEvent_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1748, 901);
            this.Controls.Add(this.updateEvent);
            this.Controls.Add(this.lblorg);
            this.Controls.Add(this.lblvenue);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblstart_time);
            this.Controls.Add(this.lblend_time);
            this.Controls.Add(this.cmbvenue);
            this.Controls.Add(this.cmborg);
            this.Controls.Add(this.dtpstart_time);
            this.Controls.Add(this.dtpend_time);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.EventDG);
            this.Controls.Add(this.tbevent_name);
            this.Controls.Add(this.lblevent_name);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.label2);
            this.Name = "Events";
            this.Text = "Event";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Events_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.addEvent, 0);
            this.Controls.SetChildIndex(this.deleteEvent, 0);
            this.Controls.SetChildIndex(this.lblevent_name, 0);
            this.Controls.SetChildIndex(this.tbevent_name, 0);
            this.Controls.SetChildIndex(this.EventDG, 0);
            this.Controls.SetChildIndex(this.dtpdate, 0);
            this.Controls.SetChildIndex(this.ErrMsg, 0);
            this.Controls.SetChildIndex(this.dtpend_time, 0);
            this.Controls.SetChildIndex(this.dtpstart_time, 0);
            this.Controls.SetChildIndex(this.cmborg, 0);
            this.Controls.SetChildIndex(this.cmbvenue, 0);
            this.Controls.SetChildIndex(this.lblend_time, 0);
            this.Controls.SetChildIndex(this.lblstart_time, 0);
            this.Controls.SetChildIndex(this.lbldate, 0);
            this.Controls.SetChildIndex(this.lblvenue, 0);
            this.Controls.SetChildIndex(this.lblorg, 0);
            this.Controls.SetChildIndex(this.updateEvent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.EventDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView EventDG;
        private System.Windows.Forms.TextBox tbevent_name;
        private System.Windows.Forms.Label lblevent_name;
        private System.Windows.Forms.Button deleteEvent;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.DateTimePicker dtpend_time;
        private System.Windows.Forms.DateTimePicker dtpstart_time;
        private System.Windows.Forms.ComboBox cmborg;
        private System.Windows.Forms.ComboBox cmbvenue;
        private System.Windows.Forms.Label lblend_time;
        private System.Windows.Forms.Label lblstart_time;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblvenue;
        private System.Windows.Forms.Label lblorg;
        private System.Windows.Forms.Button updateEvent;
    }
}