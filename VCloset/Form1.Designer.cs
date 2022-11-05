namespace VCloset
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
            this.topPicture = new System.Windows.Forms.PictureBox();
            this.bottomPicture = new System.Windows.Forms.PictureBox();
            this.topNextBtn = new System.Windows.Forms.Button();
            this.topBackBtn = new System.Windows.Forms.Button();
            this.bottomBackBtn = new System.Windows.Forms.Button();
            this.bottomNextBtn = new System.Windows.Forms.Button();
            this.bottomUploadBtn = new System.Windows.Forms.Button();
            this.topUploadBtn = new System.Windows.Forms.Button();
            this.shuffleBtn = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.topPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPicture)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPicture
            // 
            this.topPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPicture.Location = new System.Drawing.Point(331, 181);
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
            this.bottomPicture.Location = new System.Drawing.Point(331, 512);
            this.bottomPicture.Name = "bottomPicture";
            this.bottomPicture.Size = new System.Drawing.Size(300, 300);
            this.bottomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bottomPicture.TabIndex = 1;
            this.bottomPicture.TabStop = false;
            // 
            // topNextBtn
            // 
            this.topNextBtn.Location = new System.Drawing.Point(690, 312);
            this.topNextBtn.Name = "topNextBtn";
            this.topNextBtn.Size = new System.Drawing.Size(150, 46);
            this.topNextBtn.TabIndex = 2;
            this.topNextBtn.Text = "next";
            this.topNextBtn.UseVisualStyleBackColor = true;
            this.topNextBtn.Click += new System.EventHandler(this.topNextBtn_Click);
            // 
            // topBackBtn
            // 
            this.topBackBtn.Location = new System.Drawing.Point(120, 312);
            this.topBackBtn.Name = "topBackBtn";
            this.topBackBtn.Size = new System.Drawing.Size(150, 46);
            this.topBackBtn.TabIndex = 3;
            this.topBackBtn.Text = "back";
            this.topBackBtn.UseVisualStyleBackColor = true;
            this.topBackBtn.Click += new System.EventHandler(this.topBackBtn_Click);
            // 
            // bottomBackBtn
            // 
            this.bottomBackBtn.Location = new System.Drawing.Point(120, 661);
            this.bottomBackBtn.Name = "bottomBackBtn";
            this.bottomBackBtn.Size = new System.Drawing.Size(150, 46);
            this.bottomBackBtn.TabIndex = 4;
            this.bottomBackBtn.Text = "back";
            this.bottomBackBtn.UseVisualStyleBackColor = true;
            this.bottomBackBtn.Click += new System.EventHandler(this.bottomBackBtn_Click);
            // 
            // bottomNextBtn
            // 
            this.bottomNextBtn.Location = new System.Drawing.Point(690, 661);
            this.bottomNextBtn.Name = "bottomNextBtn";
            this.bottomNextBtn.Size = new System.Drawing.Size(150, 46);
            this.bottomNextBtn.TabIndex = 5;
            this.bottomNextBtn.Text = "next";
            this.bottomNextBtn.UseVisualStyleBackColor = true;
            this.bottomNextBtn.Click += new System.EventHandler(this.bottomNextBtn_Click);
            // 
            // bottomUploadBtn
            // 
            this.bottomUploadBtn.Location = new System.Drawing.Point(120, 512);
            this.bottomUploadBtn.Name = "bottomUploadBtn";
            this.bottomUploadBtn.Size = new System.Drawing.Size(150, 46);
            this.bottomUploadBtn.TabIndex = 6;
            this.bottomUploadBtn.Text = "upload";
            this.bottomUploadBtn.UseVisualStyleBackColor = true;
            this.bottomUploadBtn.Click += new System.EventHandler(this.bottomUploadBtn_Click);
            // 
            // topUploadBtn
            // 
            this.topUploadBtn.Location = new System.Drawing.Point(120, 181);
            this.topUploadBtn.Name = "topUploadBtn";
            this.topUploadBtn.Size = new System.Drawing.Size(150, 46);
            this.topUploadBtn.TabIndex = 7;
            this.topUploadBtn.Text = "upload";
            this.topUploadBtn.UseVisualStyleBackColor = true;
            this.topUploadBtn.Click += new System.EventHandler(this.topUploadBtn_Click);
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.Location = new System.Drawing.Point(406, 883);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(150, 46);
            this.shuffleBtn.TabIndex = 8;
            this.shuffleBtn.Text = "shuffle";
            this.shuffleBtn.UseVisualStyleBackColor = true;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenu,
            this.settingsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(974, 40);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // homeMenu
            // 
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(99, 36);
            this.homeMenu.Text = "Home";
            this.homeMenu.Click += new System.EventHandler(this.homeMenu_Click);
            // 
            // settingsMenu
            // 
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(120, 36);
            this.settingsMenu.Text = "Settings";
            this.settingsMenu.Click += new System.EventHandler(this.settingsMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 1129);
            this.Controls.Add(this.shuffleBtn);
            this.Controls.Add(this.topUploadBtn);
            this.Controls.Add(this.bottomUploadBtn);
            this.Controls.Add(this.bottomNextBtn);
            this.Controls.Add(this.bottomBackBtn);
            this.Controls.Add(this.topBackBtn);
            this.Controls.Add(this.topNextBtn);
            this.Controls.Add(this.bottomPicture);
            this.Controls.Add(this.topPicture);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "VCloset";
            ((System.ComponentModel.ISupportInitialize)(this.topPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPicture)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox topPicture;
        private PictureBox bottomPicture;
        private Button topNextBtn;
        private Button topBackBtn;
        private Button bottomBackBtn;
        private Button bottomNextBtn;
        private Button bottomUploadBtn;
        private Button topUploadBtn;
        private Button shuffleBtn;
        private MenuStrip menuStrip;
        private ToolStripMenuItem homeMenu;
        private ToolStripMenuItem settingsMenu;
    }
}