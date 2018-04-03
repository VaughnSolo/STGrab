namespace SoloThreadGrab
{
    partial class Main
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
            this.buttonGrab = new System.Windows.Forms.Button();
            this.textNewURL = new System.Windows.Forms.TextBox();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.checkBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.groupPreview = new System.Windows.Forms.GroupBox();
            this.labelFileCount = new System.Windows.Forms.Label();
            this.labelCheckedCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textThreadTitle = new System.Windows.Forms.TextBox();
            this.labelThreadTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.groupPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGrab
            // 
            this.buttonGrab.Location = new System.Drawing.Point(458, 5);
            this.buttonGrab.Name = "buttonGrab";
            this.buttonGrab.Size = new System.Drawing.Size(91, 23);
            this.buttonGrab.TabIndex = 0;
            this.buttonGrab.Text = "Start";
            this.buttonGrab.UseVisualStyleBackColor = true;
            this.buttonGrab.Click += new System.EventHandler(this.buttonGrab_Click);
            // 
            // textNewURL
            // 
            this.textNewURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textNewURL.Location = new System.Drawing.Point(98, 6);
            this.textNewURL.Name = "textNewURL";
            this.textNewURL.Size = new System.Drawing.Size(354, 21);
            this.textNewURL.TabIndex = 1;
            // 
            // previewBox
            // 
            this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewBox.Location = new System.Drawing.Point(307, 20);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(218, 223);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.previewBox.TabIndex = 2;
            this.previewBox.TabStop = false;
            // 
            // checkBoxFiles
            // 
            this.checkBoxFiles.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFiles.FormattingEnabled = true;
            this.checkBoxFiles.Location = new System.Drawing.Point(6, 20);
            this.checkBoxFiles.Name = "checkBoxFiles";
            this.checkBoxFiles.Size = new System.Drawing.Size(295, 244);
            this.checkBoxFiles.TabIndex = 3;
            this.checkBoxFiles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkBoxFiles_ItemCheck);
            this.checkBoxFiles.SelectedIndexChanged += new System.EventHandler(this.checkBoxFiles_SelectedIndexChanged);
            // 
            // groupPreview
            // 
            this.groupPreview.Controls.Add(this.labelCheckedCount);
            this.groupPreview.Controls.Add(this.labelFileCount);
            this.groupPreview.Controls.Add(this.previewBox);
            this.groupPreview.Controls.Add(this.checkBoxFiles);
            this.groupPreview.Location = new System.Drawing.Point(18, 60);
            this.groupPreview.Name = "groupPreview";
            this.groupPreview.Size = new System.Drawing.Size(531, 268);
            this.groupPreview.TabIndex = 5;
            this.groupPreview.TabStop = false;
            this.groupPreview.Text = "Thread Item Preview";
            // 
            // labelFileCount
            // 
            this.labelFileCount.AutoSize = true;
            this.labelFileCount.Location = new System.Drawing.Point(307, 246);
            this.labelFileCount.Name = "labelFileCount";
            this.labelFileCount.Size = new System.Drawing.Size(45, 15);
            this.labelFileCount.TabIndex = 4;
            this.labelFileCount.Text = "Found:";
            // 
            // labelCheckedCount
            // 
            this.labelCheckedCount.AutoSize = true;
            this.labelCheckedCount.Location = new System.Drawing.Point(411, 246);
            this.labelCheckedCount.Name = "labelCheckedCount";
            this.labelCheckedCount.Size = new System.Drawing.Size(58, 15);
            this.labelCheckedCount.TabIndex = 5;
            this.labelCheckedCount.Text = "Checked:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thread URL:";
            // 
            // textThreadTitle
            // 
            this.textThreadTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textThreadTitle.Location = new System.Drawing.Point(98, 33);
            this.textThreadTitle.Name = "textThreadTitle";
            this.textThreadTitle.ReadOnly = true;
            this.textThreadTitle.Size = new System.Drawing.Size(451, 21);
            this.textThreadTitle.TabIndex = 7;
            // 
            // labelThreadTitle
            // 
            this.labelThreadTitle.AutoSize = true;
            this.labelThreadTitle.Location = new System.Drawing.Point(15, 36);
            this.labelThreadTitle.Name = "labelThreadTitle";
            this.labelThreadTitle.Size = new System.Drawing.Size(75, 15);
            this.labelThreadTitle.TabIndex = 8;
            this.labelThreadTitle.Text = "Thread Title:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 438);
            this.Controls.Add(this.labelThreadTitle);
            this.Controls.Add(this.textThreadTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupPreview);
            this.Controls.Add(this.textNewURL);
            this.Controls.Add(this.buttonGrab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Main";
            this.Text = "STGrab 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.groupPreview.ResumeLayout(false);
            this.groupPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGrab;
        private System.Windows.Forms.TextBox textNewURL;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.CheckedListBox checkBoxFiles;
        private System.Windows.Forms.GroupBox groupPreview;
        private System.Windows.Forms.Label labelFileCount;
        private System.Windows.Forms.Label labelCheckedCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textThreadTitle;
        private System.Windows.Forms.Label labelThreadTitle;
    }
}

