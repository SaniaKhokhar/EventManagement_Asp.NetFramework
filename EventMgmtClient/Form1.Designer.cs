namespace EventMgmtClient
{
    partial class Form1
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
            this.btnorganizer = new System.Windows.Forms.Button();
            this.btnvenue = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.btnevent = new System.Windows.Forms.Button();
            this.btparticipant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 25);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.label1.Size = new System.Drawing.Size(515, 75);
            this.label1.TabIndex = 33;
            this.label1.Text = "Event Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnorganizer
            // 
            this.btnorganizer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnorganizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnorganizer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorganizer.Location = new System.Drawing.Point(763, 132);
            this.btnorganizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnorganizer.Name = "btnorganizer";
            this.btnorganizer.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnorganizer.Size = new System.Drawing.Size(225, 62);
            this.btnorganizer.TabIndex = 32;
            this.btnorganizer.Text = "Organizer";
            this.btnorganizer.UseVisualStyleBackColor = false;
            this.btnorganizer.Click += new System.EventHandler(this.btnorganizer_Click);
            // 
            // btnvenue
            // 
            this.btnvenue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnvenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnvenue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvenue.Location = new System.Drawing.Point(447, 132);
            this.btnvenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvenue.Name = "btnvenue";
            this.btnvenue.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnvenue.Size = new System.Drawing.Size(225, 62);
            this.btnvenue.TabIndex = 36;
            this.btnvenue.Text = "Venue";
            this.btnvenue.UseVisualStyleBackColor = false;
            this.btnvenue.Click += new System.EventHandler(this.btnvenue_Click);
            // 
            // btnreg
            // 
            this.btnreg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnreg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnreg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.Location = new System.Drawing.Point(1366, 132);
            this.btnreg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreg.Name = "btnreg";
            this.btnreg.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnreg.Size = new System.Drawing.Size(225, 62);
            this.btnreg.TabIndex = 37;
            this.btnreg.Text = "Event Registration";
            this.btnreg.UseVisualStyleBackColor = false;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btnevent
            // 
            this.btnevent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnevent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnevent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnevent.Location = new System.Drawing.Point(1076, 132);
            this.btnevent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnevent.Name = "btnevent";
            this.btnevent.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnevent.Size = new System.Drawing.Size(225, 62);
            this.btnevent.TabIndex = 38;
            this.btnevent.Text = "Event";
            this.btnevent.UseVisualStyleBackColor = false;
            this.btnevent.Click += new System.EventHandler(this.btnevent_Click);
            // 
            // btparticipant
            // 
            this.btparticipant.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btparticipant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btparticipant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btparticipant.Location = new System.Drawing.Point(120, 132);
            this.btparticipant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btparticipant.Name = "btparticipant";
            this.btparticipant.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btparticipant.Size = new System.Drawing.Size(225, 62);
            this.btparticipant.TabIndex = 39;
            this.btparticipant.Text = "Participant";
            this.btparticipant.UseVisualStyleBackColor = false;
            this.btparticipant.Click += new System.EventHandler(this.btnparticipant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::EventMgmtClient.Properties.Resources.smooth_background_by_the_dogfather_d25z704_pre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1737, 850);
            this.Controls.Add(this.btparticipant);
            this.Controls.Add(this.btnevent);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.btnvenue);
            this.Controls.Add(this.btnorganizer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnorganizer;
        private System.Windows.Forms.Button btnvenue;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btnevent;
        private System.Windows.Forms.Button btparticipant;
    }
}