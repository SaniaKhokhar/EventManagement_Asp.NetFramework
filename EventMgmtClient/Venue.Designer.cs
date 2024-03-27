namespace EventMgmtClient
{
    partial class Venue
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
            this.btnorganizer = new System.Windows.Forms.Button();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VenueDG = new System.Windows.Forms.DataGridView();
            this.tbcapacity = new System.Windows.Forms.TextBox();
            this.tblocation = new System.Windows.Forms.TextBox();
            this.tbvenuename = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.venue_name = new System.Windows.Forms.Label();
            this.deleteVenue = new System.Windows.Forms.Button();
            this.addVenue = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.VenueDG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnorganizer
            // 
            this.btnorganizer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorganizer.Location = new System.Drawing.Point(98, 94);
            this.btnorganizer.Name = "btnorganizer";
            this.btnorganizer.Size = new System.Drawing.Size(113, 49);
            this.btnorganizer.TabIndex = 15;
            this.btnorganizer.Text = "Organizer";
            this.btnorganizer.UseVisualStyleBackColor = true;
            this.btnorganizer.Click += new System.EventHandler(this.btnorganizer_Click);
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.Location = new System.Drawing.Point(502, 731);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 20);
            this.ErrMsg.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(812, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Venue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 46);
            this.label1.TabIndex = 28;
            this.label1.Text = "Event Management System";
            // 
            // VenueDG
            // 
            this.VenueDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VenueDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VenueDG.DefaultCellStyle = dataGridViewCellStyle1;
            this.VenueDG.Location = new System.Drawing.Point(750, 218);
            this.VenueDG.Name = "VenueDG";
            this.VenueDG.RowHeadersWidth = 62;
            this.VenueDG.RowTemplate.Height = 28;
            this.VenueDG.Size = new System.Drawing.Size(812, 448);
            this.VenueDG.TabIndex = 27;
            this.VenueDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VenueDG_CellClick);
            // 
            // tbcapacity
            // 
            this.tbcapacity.Location = new System.Drawing.Point(531, 413);
            this.tbcapacity.MinimumSize = new System.Drawing.Size(4, 50);
            this.tbcapacity.Name = "tbcapacity";
            this.tbcapacity.Size = new System.Drawing.Size(196, 26);
            this.tbcapacity.TabIndex = 25;
            // 
            // tblocation
            // 
            this.tblocation.Location = new System.Drawing.Point(531, 322);
            this.tblocation.Multiline = true;
            this.tblocation.Name = "tblocation";
            this.tblocation.Size = new System.Drawing.Size(196, 47);
            this.tblocation.TabIndex = 24;
            // 
            // tbvenuename
            // 
            this.tbvenuename.Location = new System.Drawing.Point(531, 238);
            this.tbvenuename.MinimumSize = new System.Drawing.Size(4, 50);
            this.tbvenuename.Name = "tbvenuename";
            this.tbvenuename.Size = new System.Drawing.Size(196, 26);
            this.tbvenuename.TabIndex = 23;
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.Location = new System.Drawing.Point(342, 413);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(80, 22);
            this.capacity.TabIndex = 21;
            this.capacity.Text = "Capacity";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.Location = new System.Drawing.Point(342, 325);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(79, 22);
            this.location.TabIndex = 20;
            this.location.Text = "Location";
            // 
            // venue_name
            // 
            this.venue_name.AutoSize = true;
            this.venue_name.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venue_name.Location = new System.Drawing.Point(342, 241);
            this.venue_name.Name = "venue_name";
            this.venue_name.Size = new System.Drawing.Size(108, 22);
            this.venue_name.TabIndex = 19;
            this.venue_name.Text = "Venue Name";
            // 
            // deleteVenue
            // 
            this.deleteVenue.BackColor = System.Drawing.Color.Red;
            this.deleteVenue.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteVenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteVenue.Location = new System.Drawing.Point(577, 584);
            this.deleteVenue.Name = "deleteVenue";
            this.deleteVenue.Size = new System.Drawing.Size(96, 59);
            this.deleteVenue.TabIndex = 17;
            this.deleteVenue.Text = "Delete";
            this.deleteVenue.UseVisualStyleBackColor = false;
            this.deleteVenue.Click += new System.EventHandler(this.deleteVenue_Click);
            // 
            // addVenue
            // 
            this.addVenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addVenue.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addVenue.Location = new System.Drawing.Point(389, 584);
            this.addVenue.Name = "addVenue";
            this.addVenue.Size = new System.Drawing.Size(96, 59);
            this.addVenue.TabIndex = 16;
            this.addVenue.Text = "Add";
            this.addVenue.UseVisualStyleBackColor = false;
            this.addVenue.Click += new System.EventHandler(this.addVenue_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(258, 714);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(307, 108);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 22);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Participant";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // Venue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 897);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnorganizer);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VenueDG);
            this.Controls.Add(this.tbcapacity);
            this.Controls.Add(this.tblocation);
            this.Controls.Add(this.tbvenuename);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.location);
            this.Controls.Add(this.venue_name);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.deleteVenue);
            this.Controls.Add(this.addVenue);
            this.Name = "Venue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Venue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VenueDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnorganizer;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView VenueDG;
        private System.Windows.Forms.TextBox tbcapacity;
        private System.Windows.Forms.TextBox tblocation;
        private System.Windows.Forms.TextBox tbvenuename;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label venue_name;
        private System.Windows.Forms.Button deleteVenue;
        private System.Windows.Forms.Button addVenue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}