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
            this.ErrMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VenueDG = new System.Windows.Forms.DataGridView();
            this.tbcapacity = new System.Windows.Forms.TextBox();
            this.tblocation = new System.Windows.Forms.TextBox();
            this.tbvenuename = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.venue_name = new System.Windows.Forms.Label();
            this.deleteVenue = new System.Windows.Forms.Button();
            this.addVenue = new System.Windows.Forms.Button();
            this.updateVenue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VenueDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.BackColor = System.Drawing.Color.Transparent;
            this.ErrMsg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMsg.ForeColor = System.Drawing.Color.Crimson;
            this.ErrMsg.Location = new System.Drawing.Point(374, 801);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 26);
            this.ErrMsg.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(905, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 41);
            this.label2.TabIndex = 29;
            this.label2.Text = "Venue";
            // 
            // VenueDG
            // 
            this.VenueDG.BackgroundColor = System.Drawing.Color.LightCyan;
            this.VenueDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VenueDG.DefaultCellStyle = dataGridViewCellStyle1;
            this.VenueDG.Location = new System.Drawing.Point(847, 360);
            this.VenueDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VenueDG.Name = "VenueDG";
            this.VenueDG.RowHeadersWidth = 62;
            this.VenueDG.RowTemplate.Height = 28;
            this.VenueDG.Size = new System.Drawing.Size(697, 403);
            this.VenueDG.TabIndex = 27;
            this.VenueDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VenueDG_CellClick);
            // 
            // tbcapacity
            // 
            this.tbcapacity.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcapacity.Location = new System.Drawing.Point(538, 532);
            this.tbcapacity.Margin = new System.Windows.Forms.Padding(0);
            this.tbcapacity.MinimumSize = new System.Drawing.Size(4, 20);
            this.tbcapacity.Name = "tbcapacity";
            this.tbcapacity.Size = new System.Drawing.Size(196, 32);
            this.tbcapacity.TabIndex = 25;
            // 
            // tblocation
            // 
            this.tblocation.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblocation.Location = new System.Drawing.Point(538, 458);
            this.tblocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblocation.MinimumSize = new System.Drawing.Size(4, 24);
            this.tblocation.Multiline = true;
            this.tblocation.Name = "tblocation";
            this.tblocation.Size = new System.Drawing.Size(196, 46);
            this.tblocation.TabIndex = 24;
            // 
            // tbvenuename
            // 
            this.tbvenuename.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvenuename.Location = new System.Drawing.Point(538, 382);
            this.tbvenuename.Margin = new System.Windows.Forms.Padding(0);
            this.tbvenuename.MinimumSize = new System.Drawing.Size(4, 20);
            this.tbvenuename.Name = "tbvenuename";
            this.tbvenuename.Size = new System.Drawing.Size(196, 32);
            this.tbvenuename.TabIndex = 23;
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.BackColor = System.Drawing.Color.Transparent;
            this.capacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.ForeColor = System.Drawing.Color.DarkBlue;
            this.capacity.Location = new System.Drawing.Point(313, 532);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(98, 27);
            this.capacity.TabIndex = 21;
            this.capacity.Text = "Capacity";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.BackColor = System.Drawing.Color.Transparent;
            this.location.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.ForeColor = System.Drawing.Color.DarkBlue;
            this.location.Location = new System.Drawing.Point(313, 458);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(98, 27);
            this.location.TabIndex = 20;
            this.location.Text = "Location";
            // 
            // venue_name
            // 
            this.venue_name.AutoSize = true;
            this.venue_name.BackColor = System.Drawing.Color.Transparent;
            this.venue_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venue_name.ForeColor = System.Drawing.Color.DarkBlue;
            this.venue_name.Location = new System.Drawing.Point(313, 382);
            this.venue_name.Name = "venue_name";
            this.venue_name.Size = new System.Drawing.Size(134, 27);
            this.venue_name.TabIndex = 19;
            this.venue_name.Text = "Venue Name";
            // 
            // deleteVenue
            // 
            this.deleteVenue.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteVenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.deleteVenue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteVenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteVenue.Location = new System.Drawing.Point(347, 695);
            this.deleteVenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteVenue.Name = "deleteVenue";
            this.deleteVenue.Size = new System.Drawing.Size(96, 59);
            this.deleteVenue.TabIndex = 17;
            this.deleteVenue.Text = "Delete";
            this.deleteVenue.UseVisualStyleBackColor = false;
            this.deleteVenue.Click += new System.EventHandler(this.deleteVenue_Click);
            // 
            // addVenue
            // 
            this.addVenue.BackColor = System.Drawing.Color.LimeGreen;
            this.addVenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.addVenue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addVenue.Location = new System.Drawing.Point(639, 695);
            this.addVenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVenue.Name = "addVenue";
            this.addVenue.Size = new System.Drawing.Size(96, 59);
            this.addVenue.TabIndex = 16;
            this.addVenue.Text = "Add";
            this.addVenue.UseVisualStyleBackColor = false;
            this.addVenue.Click += new System.EventHandler(this.addVenue_Click);
            // 
            // updateVenue
            // 
            this.updateVenue.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateVenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.updateVenue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateVenue.Location = new System.Drawing.Point(493, 695);
            this.updateVenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateVenue.Name = "updateVenue";
            this.updateVenue.Size = new System.Drawing.Size(96, 59);
            this.updateVenue.TabIndex = 41;
            this.updateVenue.Text = "Update";
            this.updateVenue.UseVisualStyleBackColor = false;
            this.updateVenue.Click += new System.EventHandler(this.updateVenue_Click);
            // 
            // Venue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 902);
            this.Controls.Add(this.updateVenue);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VenueDG);
            this.Controls.Add(this.tbcapacity);
            this.Controls.Add(this.tblocation);
            this.Controls.Add(this.tbvenuename);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.location);
            this.Controls.Add(this.venue_name);
            this.Controls.Add(this.deleteVenue);
            this.Controls.Add(this.addVenue);
            this.Name = "Venue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Venue_Load);
            this.Controls.SetChildIndex(this.addVenue, 0);
            this.Controls.SetChildIndex(this.deleteVenue, 0);
            this.Controls.SetChildIndex(this.venue_name, 0);
            this.Controls.SetChildIndex(this.location, 0);
            this.Controls.SetChildIndex(this.capacity, 0);
            this.Controls.SetChildIndex(this.tbvenuename, 0);
            this.Controls.SetChildIndex(this.tblocation, 0);
            this.Controls.SetChildIndex(this.tbcapacity, 0);
            this.Controls.SetChildIndex(this.VenueDG, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ErrMsg, 0);
            this.Controls.SetChildIndex(this.updateVenue, 0);
            ((System.ComponentModel.ISupportInitialize)(this.VenueDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView VenueDG;
        private System.Windows.Forms.TextBox tbcapacity;
        private System.Windows.Forms.TextBox tblocation;
        private System.Windows.Forms.TextBox tbvenuename;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label venue_name;
        private System.Windows.Forms.Button deleteVenue;
        private System.Windows.Forms.Button addVenue;
        private System.Windows.Forms.Button updateVenue;
    }
}