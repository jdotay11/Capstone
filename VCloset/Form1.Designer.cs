﻿namespace VCloset
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPicture = new System.Windows.Forms.PictureBox();
            this.bottomPicture = new System.Windows.Forms.PictureBox();
            this.topNextBtn = new System.Windows.Forms.Button();
            this.topBackBtn = new System.Windows.Forms.Button();
            this.bottomBackBtn = new System.Windows.Forms.Button();
            this.bottomNextBtn = new System.Windows.Forms.Button();
            this.shuffleBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.shufflePanel = new System.Windows.Forms.Panel();
            this.uploadPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.homeBtn = new System.Windows.Forms.Button();
            this.faqBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.topPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPicture)).BeginInit();
            this.shufflePanel.SuspendLayout();
            this.uploadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPicture
            // 
            this.topPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPicture.Location = new System.Drawing.Point(326, 273);
            this.topPicture.Name = "topPicture";
            this.topPicture.Size = new System.Drawing.Size(300, 300);
            this.topPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topPicture.TabIndex = 0;
            this.topPicture.TabStop = false;
            // 
            // bottomPicture
            // 
            this.bottomPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPicture.Location = new System.Drawing.Point(326, 602);
            this.bottomPicture.Name = "bottomPicture";
            this.bottomPicture.Size = new System.Drawing.Size(300, 300);
            this.bottomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bottomPicture.TabIndex = 1;
            this.bottomPicture.TabStop = false;
            // 
            // topNextBtn
            // 
            this.topNextBtn.FlatAppearance.BorderSize = 0;
            this.topNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topNextBtn.Image = global::VCloset.Properties.Resources.next__1_;
            this.topNextBtn.Location = new System.Drawing.Point(867, 397);
            this.topNextBtn.Name = "topNextBtn";
            this.topNextBtn.Size = new System.Drawing.Size(95, 92);
            this.topNextBtn.TabIndex = 2;
            this.topNextBtn.UseVisualStyleBackColor = true;
            this.topNextBtn.Click += new System.EventHandler(this.topNextBtn_Click);
            // 
            // topBackBtn
            // 
            this.topBackBtn.FlatAppearance.BorderSize = 0;
            this.topBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topBackBtn.Image = global::VCloset.Properties.Resources.back;
            this.topBackBtn.Location = new System.Drawing.Point(12, 397);
            this.topBackBtn.Name = "topBackBtn";
            this.topBackBtn.Size = new System.Drawing.Size(95, 92);
            this.topBackBtn.TabIndex = 3;
            this.topBackBtn.UseVisualStyleBackColor = true;
            this.topBackBtn.Click += new System.EventHandler(this.topBackBtn_Click);
            // 
            // bottomBackBtn
            // 
            this.bottomBackBtn.FlatAppearance.BorderSize = 0;
            this.bottomBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomBackBtn.Image = global::VCloset.Properties.Resources.back;
            this.bottomBackBtn.Location = new System.Drawing.Point(12, 738);
            this.bottomBackBtn.Name = "bottomBackBtn";
            this.bottomBackBtn.Size = new System.Drawing.Size(95, 92);
            this.bottomBackBtn.TabIndex = 4;
            this.bottomBackBtn.UseVisualStyleBackColor = true;
            this.bottomBackBtn.Click += new System.EventHandler(this.bottomBackBtn_Click);
            // 
            // bottomNextBtn
            // 
            this.bottomNextBtn.FlatAppearance.BorderSize = 0;
            this.bottomNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomNextBtn.Image = global::VCloset.Properties.Resources.next__1_;
            this.bottomNextBtn.Location = new System.Drawing.Point(850, 738);
            this.bottomNextBtn.Name = "bottomNextBtn";
            this.bottomNextBtn.Size = new System.Drawing.Size(95, 92);
            this.bottomNextBtn.TabIndex = 5;
            this.bottomNextBtn.UseVisualStyleBackColor = true;
            this.bottomNextBtn.Click += new System.EventHandler(this.bottomNextBtn_Click);
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.FlatAppearance.BorderSize = 0;
            this.shuffleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleBtn.Image = global::VCloset.Properties.Resources.shuffle;
            this.shuffleBtn.Location = new System.Drawing.Point(521, 28);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(105, 74);
            this.shuffleBtn.TabIndex = 8;
            this.shuffleBtn.UseVisualStyleBackColor = true;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Image = global::VCloset.Properties.Resources.upload;
            this.uploadBtn.Location = new System.Drawing.Point(326, 28);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(105, 74);
            this.uploadBtn.TabIndex = 10;
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // shufflePanel
            // 
            this.shufflePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.shufflePanel.Controls.Add(this.uploadBtn);
            this.shufflePanel.Controls.Add(this.shuffleBtn);
            this.shufflePanel.Location = new System.Drawing.Point(0, 1005);
            this.shufflePanel.Name = "shufflePanel";
            this.shufflePanel.Size = new System.Drawing.Size(975, 124);
            this.shufflePanel.TabIndex = 11;
            // 
            // uploadPanel
            // 
            this.uploadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uploadPanel.Controls.Add(this.homeBtn);
            this.uploadPanel.Controls.Add(this.settingsBtn);
            this.uploadPanel.Controls.Add(this.faqBtn);
            this.uploadPanel.Location = new System.Drawing.Point(0, 0);
            this.uploadPanel.Name = "uploadPanel";
            this.uploadPanel.Size = new System.Drawing.Size(975, 124);
            this.uploadPanel.TabIndex = 13;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(268, 28);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(105, 74);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // faqBtn
            // 
            this.faqBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.faqBtn.FlatAppearance.BorderSize = 0;
            this.faqBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faqBtn.Image = global::VCloset.Properties.Resources.question_sign__1_;
            this.faqBtn.Location = new System.Drawing.Point(407, 28);
            this.faqBtn.Name = "faqBtn";
            this.faqBtn.Size = new System.Drawing.Size(105, 74);
            this.faqBtn.TabIndex = 1;
            this.faqBtn.UseVisualStyleBackColor = false;
            this.faqBtn.Click += new System.EventHandler(this.faqBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Image = global::VCloset.Properties.Resources.gear;
            this.settingsBtn.Location = new System.Drawing.Point(552, 28);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(105, 74);
            this.settingsBtn.TabIndex = 2;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(974, 1129);
            this.Controls.Add(this.uploadPanel);
            this.Controls.Add(this.shufflePanel);
            this.Controls.Add(this.bottomNextBtn);
            this.Controls.Add(this.bottomBackBtn);
            this.Controls.Add(this.topBackBtn);
            this.Controls.Add(this.topNextBtn);
            this.Controls.Add(this.bottomPicture);
            this.Controls.Add(this.topPicture);
            this.Name = "Form1";
            this.Text = "VCloset";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPicture)).EndInit();
            this.shufflePanel.ResumeLayout(false);
            this.uploadPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox topPicture;
        private PictureBox bottomPicture;
        private Button topNextBtn;
        private Button topBackBtn;
        private Button bottomBackBtn;
        private Button bottomNextBtn;
        private Button shuffleBtn;
        private Button uploadBtn;
        private Panel shufflePanel;
        private Panel uploadPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button homeBtn;
        private Button settingsBtn;
        private Button faqBtn;
    }
}