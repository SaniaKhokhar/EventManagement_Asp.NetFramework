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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.EventDG = new System.Windows.Forms.DataGridView();
            this.tbevent_name = new System.Windows.Forms.TextBox();
            this.end_time = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.event_name = new System.Windows.Forms.Label();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.addEvent = new System.Windows.Forms.Button();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.venue = new System.Windows.Forms.Label();
            this.organizer = new System.Windows.Forms.Label();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.dtpend_time = new System.Windows.Forms.DateTimePicker();
            this.dtpstart_time = new System.Windows.Forms.DateTimePicker();
            this.cmborg = new System.Windows.Forms.ComboBox();
            this.organizerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbvenue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EventDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "Events";
            // 
            // EventDG
            // 
            this.EventDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EventDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDG.Location = new System.Drawing.Point(727, 180);
            this.EventDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventDG.Name = "EventDG";
            this.EventDG.RowHeadersWidth = 62;
            this.EventDG.RowTemplate.Height = 28;
            this.EventDG.Size = new System.Drawing.Size(800, 400);
            this.EventDG.TabIndex = 50;
            this.EventDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDG_CellClick);
            // 
            // tbevent_name
            // 
            this.tbevent_name.Location = new System.Drawing.Point(485, 197);
            this.tbevent_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbevent_name.Name = "tbevent_name";
            this.tbevent_name.Size = new System.Drawing.Size(195, 22);
            this.tbevent_name.TabIndex = 46;
            // 
            // end_time
            // 
            this.end_time.AutoSize = true;
            this.end_time.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_time.Location = new System.Drawing.Point(333, 399);
            this.end_time.Name = "end_time";
            this.end_time.Size = new System.Drawing.Size(73, 19);
            this.end_time.TabIndex = 45;
            this.end_time.Text = "End Time";
            // 
            // start_time
            // 
            this.start_time.AutoSize = true;
            this.start_time.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_time.Location = new System.Drawing.Point(333, 337);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(76, 19);
            this.start_time.TabIndex = 44;
            this.start_time.Text = "Start time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(333, 266);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(41, 19);
            this.date.TabIndex = 43;
            this.date.Text = "Date";
            // 
            // event_name
            // 
            this.event_name.AutoSize = true;
            this.event_name.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_name.Location = new System.Drawing.Point(333, 199);
            this.event_name.Name = "event_name";
            this.event_name.Size = new System.Drawing.Size(91, 19);
            this.event_name.TabIndex = 42;
            this.event_name.Text = "Event Name";
            // 
            // deleteEvent
            // 
            this.deleteEvent.BackColor = System.Drawing.Color.Red;
            this.deleteEvent.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteEvent.Location = new System.Drawing.Point(466, 543);
            this.deleteEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(85, 47);
            this.deleteEvent.TabIndex = 41;
            this.deleteEvent.Text = "Delete";
            this.deleteEvent.UseVisualStyleBackColor = false;
            this.deleteEvent.Click += new System.EventHandler(this.deleteParticipant_Click);
            // 
            // addEvent
            // 
            this.addEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addEvent.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEvent.Location = new System.Drawing.Point(595, 543);
            this.addEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(85, 47);
            this.addEvent.TabIndex = 40;
            this.addEvent.Text = "Add";
            this.addEvent.UseVisualStyleBackColor = false;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(485, 266);
            this.dtpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(195, 22);
            this.dtpdate.TabIndex = 51;
            // 
            // venue
            // 
            this.venue.AutoSize = true;
            this.venue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venue.Location = new System.Drawing.Point(333, 502);
            this.venue.Name = "venue";
            this.venue.Size = new System.Drawing.Size(50, 19);
            this.venue.TabIndex = 53;
            this.venue.Text = "Venue";
            // 
            // organizer
            // 
            this.organizer.AutoSize = true;
            this.organizer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizer.Location = new System.Drawing.Point(333, 439);
            this.organizer.Name = "organizer";
            this.organizer.Size = new System.Drawing.Size(76, 19);
            this.organizer.TabIndex = 52;
            this.organizer.Text = "Organizer";
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg.Location = new System.Drawing.Point(471, 647);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 19);
            this.ErrMsg.TabIndex = 56;
            // 
            // dtpend_time
            // 
            this.dtpend_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpend_time.Location = new System.Drawing.Point(485, 334);
            this.dtpend_time.Name = "dtpend_time";
            this.dtpend_time.Size = new System.Drawing.Size(195, 22);
            this.dtpend_time.TabIndex = 57;
            this.dtpend_time.Value = new System.DateTime(2024, 3, 29, 0, 0, 0, 0);
            // 
            // dtpstart_time
            // 
            this.dtpstart_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpstart_time.Location = new System.Drawing.Point(485, 396);
            this.dtpstart_time.Name = "dtpstart_time";
            this.dtpstart_time.Size = new System.Drawing.Size(195, 22);
            this.dtpstart_time.TabIndex = 58;
            this.dtpstart_time.Value = new System.DateTime(2024, 3, 29, 0, 0, 0, 0);
            // 
            // cmborg
            // 
            this.cmborg.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.organizerBindingSource, "OrganizerId", true));
            this.cmborg.DataSource = this.organizerBindingSource;
            this.cmborg.DisplayMember = "OrganizerName";
            this.cmborg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmborg.FormattingEnabled = true;
            this.cmborg.Location = new System.Drawing.Point(485, 439);
            this.cmborg.Name = "cmborg";
            this.cmborg.Size = new System.Drawing.Size(195, 24);
            this.cmborg.TabIndex = 59;
            this.cmborg.ValueMember = "OrganizerId";
            this.cmborg.SelectedIndexChanged += new System.EventHandler(this.cmborg_SelectedIndexChanged);
            // 
            // organizerBindingSource
            // 
            this.organizerBindingSource.DataSource = typeof(EventMgmtClient.ServiceReference1.Organizer);
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = typeof(System.Data.DataSet);
            this.dataSetBindingSource.Position = 0;
            // 
            // cmbvenue
            // 
            this.cmbvenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvenue.FormattingEnabled = true;
            this.cmbvenue.Location = new System.Drawing.Point(485, 501);
            this.cmbvenue.Name = "cmbvenue";
            this.cmbvenue.Size = new System.Drawing.Size(195, 24);
            this.cmbvenue.TabIndex = 60;
            this.cmbvenue.SelectedIndexChanged += new System.EventHandler(this.cmbvenue_SelectedIndexChanged);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.cmbvenue);
            this.Controls.Add(this.cmborg);
            this.Controls.Add(this.dtpstart_time);
            this.Controls.Add(this.dtpend_time);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.venue);
            this.Controls.Add(this.organizer);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.EventDG);
            this.Controls.Add(this.tbevent_name);
            this.Controls.Add(this.end_time);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.event_name);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.label2);
            this.Name = "Events";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.Events_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.addEvent, 0);
            this.Controls.SetChildIndex(this.deleteEvent, 0);
            this.Controls.SetChildIndex(this.event_name, 0);
            this.Controls.SetChildIndex(this.date, 0);
            this.Controls.SetChildIndex(this.start_time, 0);
            this.Controls.SetChildIndex(this.end_time, 0);
            this.Controls.SetChildIndex(this.tbevent_name, 0);
            this.Controls.SetChildIndex(this.EventDG, 0);
            this.Controls.SetChildIndex(this.dtpdate, 0);
            this.Controls.SetChildIndex(this.organizer, 0);
            this.Controls.SetChildIndex(this.venue, 0);
            this.Controls.SetChildIndex(this.ErrMsg, 0);
            this.Controls.SetChildIndex(this.dtpend_time, 0);
            this.Controls.SetChildIndex(this.dtpstart_time, 0);
            this.Controls.SetChildIndex(this.cmborg, 0);
            this.Controls.SetChildIndex(this.cmbvenue, 0);
            ((System.ComponentModel.ISupportInitialize)(this.EventDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView EventDG;
        private System.Windows.Forms.TextBox tbevent_name;
        private System.Windows.Forms.Label end_time;
        private System.Windows.Forms.Label start_time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label event_name;
        private System.Windows.Forms.Button deleteEvent;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label venue;
        private System.Windows.Forms.Label organizer;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.DateTimePicker dtpend_time;
        private System.Windows.Forms.DateTimePicker dtpstart_time;
        private System.Windows.Forms.ComboBox cmborg;
        private System.Windows.Forms.BindingSource organizerBindingSource;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private System.Windows.Forms.ComboBox cmbvenue;
    }
}