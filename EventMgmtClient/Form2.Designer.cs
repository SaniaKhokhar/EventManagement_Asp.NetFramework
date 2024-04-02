namespace EventMgmtClient
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.participantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(694, 29);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label1.Size = new System.Drawing.Size(515, 75);
            this.label1.TabIndex = 41;
            this.label1.Text = "Event Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(30);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantToolStripMenuItem,
            this.venueToolStripMenuItem,
            this.organizerToolStripMenuItem,
            this.eventtoolStripMenuItem,
            this.registrationtoolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(1, 50, 1, 1);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(0, 1200);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(250, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 80, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(250, 899);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // participantToolStripMenuItem
            // 
            this.participantToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.participantToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 160, 0, 40);
            this.participantToolStripMenuItem.Name = "participantToolStripMenuItem";
            this.participantToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.participantToolStripMenuItem.Text = "Participant";
            this.participantToolStripMenuItem.Click += new System.EventHandler(this.participantToolStripMenuItem_Click);
            // 
            // venueToolStripMenuItem
            // 
            this.venueToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.venueToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.venueToolStripMenuItem.Name = "venueToolStripMenuItem";
            this.venueToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.venueToolStripMenuItem.Text = "Venue";
            this.venueToolStripMenuItem.Click += new System.EventHandler(this.venueToolStripMenuItem_Click);
            // 
            // organizerToolStripMenuItem
            // 
            this.organizerToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.organizerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.organizerToolStripMenuItem.Name = "organizerToolStripMenuItem";
            this.organizerToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.organizerToolStripMenuItem.Text = "Organizer";
            this.organizerToolStripMenuItem.Click += new System.EventHandler(this.organizerToolStripMenuItem_Click);
            // 
            // eventtoolStripMenuItem
            // 
            this.eventtoolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventtoolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.eventtoolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.eventtoolStripMenuItem.Name = "eventtoolStripMenuItem";
            this.eventtoolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.eventtoolStripMenuItem.Text = "Event";
            this.eventtoolStripMenuItem.Click += new System.EventHandler(this.eventtoolStripMenuItem_Click);
            // 
            // registrationtoolStripMenuItem
            // 
            this.registrationtoolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationtoolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.registrationtoolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.registrationtoolStripMenuItem.Name = "registrationtoolStripMenuItem";
            this.registrationtoolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.registrationtoolStripMenuItem.Text = "Event Registration";
            this.registrationtoolStripMenuItem.Click += new System.EventHandler(this.registrationtoolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EventMgmtClient.Properties.Resources.smooth_background_by_the_dogfather_d25z704_pre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1756, 899);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem participantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationtoolStripMenuItem;
    }
}