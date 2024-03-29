﻿namespace EventMgmtClient
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnorganizer = new System.Windows.Forms.Button();
            this.btnvenue = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.btnevent = new System.Windows.Forms.Button();
            this.btnparticipant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(65, 146);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 19);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Participant";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(750, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "Event Management System";
            // 
            // btnorganizer
            // 
            this.btnorganizer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorganizer.Location = new System.Drawing.Point(60, 325);
            this.btnorganizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnorganizer.Name = "btnorganizer";
            this.btnorganizer.Size = new System.Drawing.Size(172, 39);
            this.btnorganizer.TabIndex = 32;
            this.btnorganizer.Text = "Organizer";
            this.btnorganizer.UseVisualStyleBackColor = true;
            this.btnorganizer.Click += new System.EventHandler(this.btnorganizer_Click);
            // 
            // btnvenue
            // 
            this.btnvenue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvenue.Location = new System.Drawing.Point(60, 250);
            this.btnvenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvenue.Name = "btnvenue";
            this.btnvenue.Size = new System.Drawing.Size(172, 39);
            this.btnvenue.TabIndex = 36;
            this.btnvenue.Text = "Venue";
            this.btnvenue.UseVisualStyleBackColor = true;
            this.btnvenue.Click += new System.EventHandler(this.btnvenue_Click);
            // 
            // btnreg
            // 
            this.btnreg.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.Location = new System.Drawing.Point(60, 475);
            this.btnreg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(172, 39);
            this.btnreg.TabIndex = 37;
            this.btnreg.Text = "Event Registration";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btnevent
            // 
            this.btnevent.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnevent.Location = new System.Drawing.Point(60, 400);
            this.btnevent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnevent.Name = "btnevent";
            this.btnevent.Size = new System.Drawing.Size(172, 39);
            this.btnevent.TabIndex = 38;
            this.btnevent.Text = "Event";
            this.btnevent.UseVisualStyleBackColor = true;
            this.btnevent.Click += new System.EventHandler(this.btnevent_Click);
            // 
            // btnparticipant
            // 
            this.btnparticipant.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparticipant.Location = new System.Drawing.Point(60, 180);
            this.btnparticipant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnparticipant.Name = "btnparticipant";
            this.btnparticipant.Size = new System.Drawing.Size(172, 39);
            this.btnparticipant.TabIndex = 39;
            this.btnparticipant.Text = "Participant";
            this.btnparticipant.UseVisualStyleBackColor = true;
            this.btnparticipant.Click += new System.EventHandler(this.btnparticipant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.btnparticipant);
            this.Controls.Add(this.btnevent);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.btnvenue);
            this.Controls.Add(this.linkLabel1);
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

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnorganizer;
        private System.Windows.Forms.Button btnvenue;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btnevent;
        private System.Windows.Forms.Button btnparticipant;
    }
}