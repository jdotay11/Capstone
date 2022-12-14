namespace VCloset
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.uploadPanel = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.faqBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.toggleHeadwear = new System.Windows.Forms.RadioButton();
            this.toggleTop = new System.Windows.Forms.RadioButton();
            this.toggleBottom = new System.Windows.Forms.RadioButton();
            this.toggleShoe = new System.Windows.Forms.RadioButton();
            this.toggleBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.darkModeSelect = new System.Windows.Forms.Button();
            this.uploadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toggle Articles";
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
            this.uploadPanel.TabIndex = 14;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Background Color";
            // 
            // colorSelect
            // 
            this.colorSelect.Location = new System.Drawing.Point(277, 186);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(212, 60);
            this.colorSelect.TabIndex = 16;
            this.colorSelect.Text = "Select";
            this.colorSelect.UseVisualStyleBackColor = true;
            this.colorSelect.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Reset Clothes";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(521, 186);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(212, 60);
            this.resetBtn.TabIndex = 18;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // toggleHeadwear
            // 
            this.toggleHeadwear.AutoSize = true;
            this.toggleHeadwear.Location = new System.Drawing.Point(41, 186);
            this.toggleHeadwear.Name = "toggleHeadwear";
            this.toggleHeadwear.Size = new System.Drawing.Size(151, 36);
            this.toggleHeadwear.TabIndex = 19;
            this.toggleHeadwear.TabStop = true;
            this.toggleHeadwear.Text = "Headwear";
            this.toggleHeadwear.UseVisualStyleBackColor = true;
            // 
            // toggleTop
            // 
            this.toggleTop.AutoSize = true;
            this.toggleTop.Location = new System.Drawing.Point(41, 228);
            this.toggleTop.Name = "toggleTop";
            this.toggleTop.Size = new System.Drawing.Size(84, 36);
            this.toggleTop.TabIndex = 20;
            this.toggleTop.TabStop = true;
            this.toggleTop.Text = "Top";
            this.toggleTop.UseVisualStyleBackColor = true;
            // 
            // toggleBottom
            // 
            this.toggleBottom.AutoSize = true;
            this.toggleBottom.Location = new System.Drawing.Point(41, 270);
            this.toggleBottom.Name = "toggleBottom";
            this.toggleBottom.Size = new System.Drawing.Size(124, 36);
            this.toggleBottom.TabIndex = 21;
            this.toggleBottom.TabStop = true;
            this.toggleBottom.Text = "Bottom";
            this.toggleBottom.UseVisualStyleBackColor = true;
            // 
            // toggleShoe
            // 
            this.toggleShoe.AutoSize = true;
            this.toggleShoe.Location = new System.Drawing.Point(41, 312);
            this.toggleShoe.Name = "toggleShoe";
            this.toggleShoe.Size = new System.Drawing.Size(109, 36);
            this.toggleShoe.TabIndex = 22;
            this.toggleShoe.TabStop = true;
            this.toggleShoe.Text = "Shoes";
            this.toggleShoe.UseVisualStyleBackColor = true;
            // 
            // toggleBtn
            // 
            this.toggleBtn.Location = new System.Drawing.Point(41, 366);
            this.toggleBtn.Name = "toggleBtn";
            this.toggleBtn.Size = new System.Drawing.Size(150, 46);
            this.toggleBtn.TabIndex = 24;
            this.toggleBtn.Text = "Toggle";
            this.toggleBtn.UseVisualStyleBackColor = true;
            this.toggleBtn.Click += new System.EventHandler(this.toggleBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dark Mode";
            // 
            // darkModeSelect
            // 
            this.darkModeSelect.Location = new System.Drawing.Point(277, 312);
            this.darkModeSelect.Name = "darkModeSelect";
            this.darkModeSelect.Size = new System.Drawing.Size(212, 60);
            this.darkModeSelect.TabIndex = 26;
            this.darkModeSelect.Text = "Select";
            this.darkModeSelect.UseVisualStyleBackColor = true;
            this.darkModeSelect.Click += new System.EventHandler(this.darkModeSelect_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.darkModeSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toggleBtn);
            this.Controls.Add(this.toggleShoe);
            this.Controls.Add(this.toggleBottom);
            this.Controls.Add(this.toggleTop);
            this.Controls.Add(this.toggleHeadwear);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uploadPanel);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.uploadPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Panel uploadPanel;
        private Button homeBtn;
        private Button settingsBtn;
        private Button faqBtn;
        private Label label2;
        private Button colorSelect;
        private Label label3;
        private Button resetBtn;
        private RadioButton toggleHeadwear;
        private RadioButton toggleTop;
        private RadioButton toggleBottom;
        private RadioButton toggleShoe;
        private Button toggleBtn;
        private Label label4;
        private Button darkModeSelect;
    }
}