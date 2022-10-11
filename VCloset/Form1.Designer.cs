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
            ((System.ComponentModel.ISupportInitialize)(this.topPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // topPicture
            // 
            this.topPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPicture.Location = new System.Drawing.Point(325, 96);
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
            this.bottomPicture.Location = new System.Drawing.Point(325, 427);
            this.bottomPicture.Name = "bottomPicture";
            this.bottomPicture.Size = new System.Drawing.Size(300, 300);
            this.bottomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bottomPicture.TabIndex = 1;
            this.bottomPicture.TabStop = false;
            // 
            // topNextBtn
            // 
            this.topNextBtn.Location = new System.Drawing.Point(684, 227);
            this.topNextBtn.Name = "topNextBtn";
            this.topNextBtn.Size = new System.Drawing.Size(150, 46);
            this.topNextBtn.TabIndex = 2;
            this.topNextBtn.Text = "next";
            this.topNextBtn.UseVisualStyleBackColor = true;
            // 
            // topBackBtn
            // 
            this.topBackBtn.Location = new System.Drawing.Point(114, 227);
            this.topBackBtn.Name = "topBackBtn";
            this.topBackBtn.Size = new System.Drawing.Size(150, 46);
            this.topBackBtn.TabIndex = 3;
            this.topBackBtn.Text = "back";
            this.topBackBtn.UseVisualStyleBackColor = true;
            // 
            // bottomBackBtn
            // 
            this.bottomBackBtn.Location = new System.Drawing.Point(114, 576);
            this.bottomBackBtn.Name = "bottomBackBtn";
            this.bottomBackBtn.Size = new System.Drawing.Size(150, 46);
            this.bottomBackBtn.TabIndex = 4;
            this.bottomBackBtn.Text = "back";
            this.bottomBackBtn.UseVisualStyleBackColor = true;
            this.bottomBackBtn.Click += new System.EventHandler(this.bottomBackBtn_Click);
            // 
            // bottomNextBtn
            // 
            this.bottomNextBtn.Location = new System.Drawing.Point(684, 576);
            this.bottomNextBtn.Name = "bottomNextBtn";
            this.bottomNextBtn.Size = new System.Drawing.Size(150, 46);
            this.bottomNextBtn.TabIndex = 5;
            this.bottomNextBtn.Text = "next";
            this.bottomNextBtn.UseVisualStyleBackColor = true;
            // 
            // bottomUploadBtn
            // 
            this.bottomUploadBtn.Location = new System.Drawing.Point(114, 427);
            this.bottomUploadBtn.Name = "bottomUploadBtn";
            this.bottomUploadBtn.Size = new System.Drawing.Size(150, 46);
            this.bottomUploadBtn.TabIndex = 6;
            this.bottomUploadBtn.Text = "upload";
            this.bottomUploadBtn.UseVisualStyleBackColor = true;
            this.bottomUploadBtn.Click += new System.EventHandler(this.bottomUploadBtn_Click);
            // 
            // topUploadBtn
            // 
            this.topUploadBtn.Location = new System.Drawing.Point(114, 96);
            this.topUploadBtn.Name = "topUploadBtn";
            this.topUploadBtn.Size = new System.Drawing.Size(150, 46);
            this.topUploadBtn.TabIndex = 7;
            this.topUploadBtn.Text = "upload";
            this.topUploadBtn.UseVisualStyleBackColor = true;
            this.topUploadBtn.Click += new System.EventHandler(this.topUploadBtn_Click);
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.Location = new System.Drawing.Point(400, 798);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(150, 46);
            this.shuffleBtn.TabIndex = 8;
            this.shuffleBtn.Text = "shuffle";
            this.shuffleBtn.UseVisualStyleBackColor = true;
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
            this.Name = "Form1";
            this.Text = "VCloset";
            ((System.ComponentModel.ISupportInitialize)(this.topPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPicture)).EndInit();
            this.ResumeLayout(false);

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
    }
}