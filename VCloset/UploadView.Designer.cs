namespace VCloset
{
    partial class UploadView
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
            this.fileText = new System.Windows.Forms.TextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.itemSelect = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // fileText
            // 
            this.fileText.Location = new System.Drawing.Point(248, 99);
            this.fileText.Name = "fileText";
            this.fileText.ReadOnly = true;
            this.fileText.Size = new System.Drawing.Size(444, 39);
            this.fileText.TabIndex = 0;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(392, 407);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(150, 46);
            this.uploadBtn.TabIndex = 1;
            this.uploadBtn.Text = "upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // itemSelect
            // 
            this.itemSelect.FormattingEnabled = true;
            this.itemSelect.Items.AddRange(new object[] {
            "Top",
            "Bottom",
            "Shoes"});
            this.itemSelect.Location = new System.Drawing.Point(350, 176);
            this.itemSelect.Name = "itemSelect";
            this.itemSelect.Size = new System.Drawing.Size(240, 184);
            this.itemSelect.TabIndex = 2;
            // 
            // UploadView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 1129);
            this.Controls.Add(this.itemSelect);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.fileText);
            this.Name = "UploadView";
            this.Text = "UploadView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fileText;
        private Button uploadBtn;
        private CheckedListBox itemSelect;
    }
}