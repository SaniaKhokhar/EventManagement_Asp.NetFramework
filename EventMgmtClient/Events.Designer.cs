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
            this.label2 = new System.Windows.Forms.Label();
            this.EventDG = new System.Windows.Forms.DataGridView();
            this.tbend_time = new System.Windows.Forms.TextBox();
            this.tbstart_time = new System.Windows.Forms.TextBox();
            this.tblname = new System.Windows.Forms.TextBox();
            this.tbevent_name = new System.Windows.Forms.TextBox();
            this.end_time = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.event_name = new System.Windows.Forms.Label();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.addEvent = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbvenue = new System.Windows.Forms.TextBox();
            this.tborg = new System.Windows.Forms.TextBox();
            this.venue = new System.Windows.Forms.Label();
            this.organizer = new System.Windows.Forms.Label();
            this.ErrMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EventDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(744, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "Events";
            // 
            // EventDG
            // 
            this.EventDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EventDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDG.Location = new System.Drawing.Point(818, 225);
            this.EventDG.Name = "EventDG";
            this.EventDG.RowHeadersWidth = 62;
            this.EventDG.RowTemplate.Height = 28;
            this.EventDG.Size = new System.Drawing.Size(832, 448);
            this.EventDG.TabIndex = 50;
            this.EventDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDG_CellClick);
            // 
            // tbend_time
            // 
            this.tbend_time.Location = new System.Drawing.Point(564, 492);
            this.tbend_time.Name = "tbend_time";
            this.tbend_time.Size = new System.Drawing.Size(168, 26);
            this.tbend_time.TabIndex = 49;
            // 
            // tbstart_time
            // 
            this.tbstart_time.Location = new System.Drawing.Point(564, 421);
            this.tbstart_time.Name = "tbstart_time";
            this.tbstart_time.Size = new System.Drawing.Size(168, 26);
            this.tbstart_time.TabIndex = 48;
            // 
            // tblname
            // 
            this.tblname.Location = new System.Drawing.Point(564, 278);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(168, 26);
            this.tblname.TabIndex = 47;
            // 
            // tbevent_name
            // 
            this.tbevent_name.Location = new System.Drawing.Point(564, 246);
            this.tbevent_name.Name = "tbevent_name";
            this.tbevent_name.Size = new System.Drawing.Size(168, 26);
            this.tbevent_name.TabIndex = 46;
            // 
            // end_time
            // 
            this.end_time.AutoSize = true;
            this.end_time.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_time.Location = new System.Drawing.Point(375, 499);
            this.end_time.Name = "end_time";
            this.end_time.Size = new System.Drawing.Size(86, 22);
            this.end_time.TabIndex = 45;
            this.end_time.Text = "End Time";
            // 
            // start_time
            // 
            this.start_time.AutoSize = true;
            this.start_time.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_time.Location = new System.Drawing.Point(375, 421);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(86, 22);
            this.start_time.TabIndex = 44;
            this.start_time.Text = "Start time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(375, 333);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(47, 22);
            this.date.TabIndex = 43;
            this.date.Text = "Date";
            // 
            // event_name
            // 
            this.event_name.AutoSize = true;
            this.event_name.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_name.Location = new System.Drawing.Point(375, 249);
            this.event_name.Name = "event_name";
            this.event_name.Size = new System.Drawing.Size(106, 22);
            this.event_name.TabIndex = 42;
            this.event_name.Text = "Event Name";
            // 
            // deleteEvent
            // 
            this.deleteEvent.BackColor = System.Drawing.Color.Red;
            this.deleteEvent.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteEvent.Location = new System.Drawing.Point(576, 679);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(96, 59);
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
            this.addEvent.Location = new System.Drawing.Point(419, 679);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(96, 59);
            this.addEvent.TabIndex = 40;
            this.addEvent.Text = "Add";
            this.addEvent.UseVisualStyleBackColor = false;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(546, 333);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // tbvenue
            // 
            this.tbvenue.AcceptsReturn = true;
            this.tbvenue.Location = new System.Drawing.Point(564, 620);
            this.tbvenue.Name = "tbvenue";
            this.tbvenue.Size = new System.Drawing.Size(168, 26);
            this.tbvenue.TabIndex = 55;
            // 
            // tborg
            // 
            this.tborg.Location = new System.Drawing.Point(564, 549);
            this.tborg.Name = "tborg";
            this.tborg.Size = new System.Drawing.Size(168, 26);
            this.tborg.TabIndex = 54;
            // 
            // venue
            // 
            this.venue.AutoSize = true;
            this.venue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venue.Location = new System.Drawing.Point(375, 627);
            this.venue.Name = "venue";
            this.venue.Size = new System.Drawing.Size(57, 22);
            this.venue.TabIndex = 53;
            this.venue.Text = "Venue";
            // 
            // organizer
            // 
            this.organizer.AutoSize = true;
            this.organizer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizer.Location = new System.Drawing.Point(375, 549);
            this.organizer.Name = "organizer";
            this.organizer.Size = new System.Drawing.Size(88, 22);
            this.organizer.TabIndex = 52;
            this.organizer.Text = "Organizer";
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg.Location = new System.Drawing.Point(530, 809);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 22);
            this.ErrMsg.TabIndex = 56;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 897);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.tbvenue);
            this.Controls.Add(this.tborg);
            this.Controls.Add(this.venue);
            this.Controls.Add(this.organizer);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.EventDG);
            this.Controls.Add(this.tbend_time);
            this.Controls.Add(this.tbstart_time);
            this.Controls.Add(this.tblname);
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
            this.Controls.SetChildIndex(this.tblname, 0);
            this.Controls.SetChildIndex(this.tbstart_time, 0);
            this.Controls.SetChildIndex(this.tbend_time, 0);
            this.Controls.SetChildIndex(this.EventDG, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.organizer, 0);
            this.Controls.SetChildIndex(this.venue, 0);
            this.Controls.SetChildIndex(this.tborg, 0);
            this.Controls.SetChildIndex(this.tbvenue, 0);
            this.Controls.SetChildIndex(this.ErrMsg, 0);
            ((System.ComponentModel.ISupportInitialize)(this.EventDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView EventDG;
        private System.Windows.Forms.TextBox tbend_time;
        private System.Windows.Forms.TextBox tbstart_time;
        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.TextBox tbevent_name;
        private System.Windows.Forms.Label end_time;
        private System.Windows.Forms.Label start_time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label event_name;
        private System.Windows.Forms.Button deleteEvent;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbvenue;
        private System.Windows.Forms.TextBox tborg;
        private System.Windows.Forms.Label venue;
        private System.Windows.Forms.Label organizer;
        private System.Windows.Forms.Label ErrMsg;
    }
}