namespace VCloset
{
    partial class Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
            this.fileText = new System.Windows.Forms.TextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.itemSelect = new System.Windows.Forms.CheckedListBox();
            this.uploadPanel = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.faqBtn = new System.Windows.Forms.Button();
            this.uploadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileText
            // 
            this.fileText.Location = new System.Drawing.Point(244, 182);
            this.fileText.Name = "fileText";
            this.fileText.ReadOnly = true;
            this.fileText.Size = new System.Drawing.Size(444, 39);
            this.fileText.TabIndex = 0;
            // 
            // uploadBtn
            // 
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Image = global::VCloset.Properties.Resources.upload;
            this.uploadBtn.Location = new System.Drawing.Point(407, 492);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(105, 74);
            this.uploadBtn.TabIndex = 1;
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // itemSelect
            // 
            this.itemSelect.CheckOnClick = true;
            this.itemSelect.FormattingEnabled = true;
            this.itemSelect.Items.AddRange(new object[] {
            "Top",
            "Bottom",
            "Shoes"});
            this.itemSelect.Location = new System.Drawing.Point(349, 259);
            this.itemSelect.Name = "itemSelect";
            this.itemSelect.Size = new System.Drawing.Size(240, 184);
            this.itemSelect.TabIndex = 2;
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
            this.uploadPanel.TabIndex = 15;
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
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.uploadPanel);
            this.Controls.Add(this.itemSelect);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.fileText);
            this.Name = "Upload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UploadView_FormClosed);
            this.uploadPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fileText;
        private Button uploadBtn;
        private CheckedListBox itemSelect;
        private Panel uploadPanel;
        private Button homeBtn;
        private Button settingsBtn;
        private Button faqBtn;
    }
}