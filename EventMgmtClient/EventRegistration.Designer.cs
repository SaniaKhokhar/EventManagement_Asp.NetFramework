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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblpart = new System.Windows.Forms.Label();
            this.lblevent = new System.Windows.Forms.Label();
            this.lblreg_date = new System.Windows.Forms.Label();
            this.lblfees = new System.Windows.Forms.Label();
            this.cmbpart = new System.Windows.Forms.ComboBox();
            this.cmbevent = new System.Windows.Forms.ComboBox();
            this.dtpreg_date = new System.Windows.Forms.DateTimePicker();
            this.addEvent = new System.Windows.Forms.Button();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.RegDG = new System.Windows.Forms.DataGridView();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.nudfees = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RegDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpart
            // 
            this.lblpart.AutoSize = true;
            this.lblpart.Location = new System.Drawing.Point(344, 198);
            this.lblpart.Name = "lblpart";
            this.lblpart.Size = new System.Drawing.Size(70, 16);
            this.lblpart.TabIndex = 40;
            this.lblpart.Text = "Participant";
            // 
            // lblevent
            // 
            this.lblevent.AutoSize = true;
            this.lblevent.Location = new System.Drawing.Point(344, 290);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(41, 16);
            this.lblevent.TabIndex = 41;
            this.lblevent.Text = "Event";
            // 
            // lblreg_date
            // 
            this.lblreg_date.AutoSize = true;
            this.lblreg_date.Location = new System.Drawing.Point(344, 363);
            this.lblreg_date.Name = "lblreg_date";
            this.lblreg_date.Size = new System.Drawing.Size(111, 16);
            this.lblreg_date.TabIndex = 51;
            this.lblreg_date.Text = "Registration Date";
            // 
            // lblfees
            // 
            this.lblfees.AutoSize = true;
            this.lblfees.Location = new System.Drawing.Point(344, 438);
            this.lblfees.Name = "lblfees";
            this.lblfees.Size = new System.Drawing.Size(38, 16);
            this.lblfees.TabIndex = 52;
            this.lblfees.Text = "Fees";
            // 
            // cmbpart
            // 
            this.cmbpart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpart.FormattingEnabled = true;
            this.cmbpart.Location = new System.Drawing.Point(510, 190);
            this.cmbpart.Name = "cmbpart";
            this.cmbpart.Size = new System.Drawing.Size(324, 24);
            this.cmbpart.TabIndex = 53;
            // 
            // cmbevent
            // 
            this.cmbevent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbevent.FormattingEnabled = true;
            this.cmbevent.Location = new System.Drawing.Point(510, 282);
            this.cmbevent.Name = "cmbevent";
            this.cmbevent.Size = new System.Drawing.Size(200, 24);
            this.cmbevent.TabIndex = 54;
            // 
            // dtpreg_date
            // 
            this.dtpreg_date.Location = new System.Drawing.Point(510, 358);
            this.dtpreg_date.Name = "dtpreg_date";
            this.dtpreg_date.Size = new System.Drawing.Size(200, 22);
            this.dtpreg_date.TabIndex = 55;
            this.dtpreg_date.Value = new System.DateTime(2024, 3, 30, 0, 0, 0, 0);
            // 
            // addEvent
            // 
            this.addEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addEvent.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEvent.Location = new System.Drawing.Point(749, 502);
            this.addEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(85, 47);
            this.addEvent.TabIndex = 57;
            this.addEvent.Text = "Add";
            this.addEvent.UseVisualStyleBackColor = false;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // deleteEvent
            // 
            this.deleteEvent.BackColor = System.Drawing.Color.Red;
            this.deleteEvent.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteEvent.Location = new System.Drawing.Point(590, 502);
            this.deleteEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(85, 47);
            this.deleteEvent.TabIndex = 58;
            this.deleteEvent.Text = "Delete";
            this.deleteEvent.UseVisualStyleBackColor = false;
            this.deleteEvent.Click += new System.EventHandler(this.deleteEvent_Click);
            // 
            // RegDG
            // 
            this.RegDG.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RegDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RegDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.RegDG.Location = new System.Drawing.Point(900, 114);
            this.RegDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegDG.Name = "RegDG";
            this.RegDG.RowHeadersWidth = 62;
            this.RegDG.RowTemplate.Height = 28;
            this.RegDG.Size = new System.Drawing.Size(800, 400);
            this.RegDG.TabIndex = 59;
            this.RegDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegDG_CellClick);
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg.Location = new System.Drawing.Point(538, 605);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 19);
            this.ErrMsg.TabIndex = 60;
            // 
            // nudfees
            // 
            this.nudfees.Location = new System.Drawing.Point(510, 436);
            this.nudfees.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudfees.Name = "nudfees";
            this.nudfees.Size = new System.Drawing.Size(120, 22);
            this.nudfees.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 62;
            this.label2.Text = "Event Registration";
            // 
            // EventRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudfees);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.RegDG);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.dtpreg_date);
            this.Controls.Add(this.cmbevent);
            this.Controls.Add(this.cmbpart);
            this.Controls.Add(this.lblfees);
            this.Controls.Add(this.lblreg_date);
            this.Controls.Add(this.lblevent);
            this.Controls.Add(this.lblpart);
            this.Name = "EventRegistration";
            this.Text = "EventRegistration";
            this.Load += new System.EventHandler(this.EventRegistration_Load);
            this.Controls.SetChildIndex(this.lblpart, 0);
            this.Controls.SetChildIndex(this.lblevent, 0);
            this.Controls.SetChildIndex(this.lblreg_date, 0);
            this.Controls.SetChildIndex(this.lblfees, 0);
            this.Controls.SetChildIndex(this.cmbpart, 0);
            this.Controls.SetChildIndex(this.cmbevent, 0);
            this.Controls.SetChildIndex(this.dtpreg_date, 0);
            this.Controls.SetChildIndex(this.addEvent, 0);
            this.Controls.SetChildIndex(this.deleteEvent, 0);
            this.Controls.SetChildIndex(this.RegDG, 0);
            this.Controls.SetChildIndex(this.ErrMsg, 0);
            this.Controls.SetChildIndex(this.nudfees, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RegDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpart;
        private System.Windows.Forms.Label lblevent;
        private System.Windows.Forms.Label lblreg_date;
        private System.Windows.Forms.Label lblfees;
        private System.Windows.Forms.ComboBox cmbpart;
        private System.Windows.Forms.ComboBox cmbevent;
        private System.Windows.Forms.DateTimePicker dtpreg_date;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.Button deleteEvent;
        private System.Windows.Forms.DataGridView RegDG;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.NumericUpDown nudfees;
        private System.Windows.Forms.Label label2;
    }
}