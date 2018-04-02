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
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.groupPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGrab
            // 
            this.buttonGrab.Location = new System.Drawing.Point(458, 10);
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
            this.textNewURL.Location = new System.Drawing.Point(12, 12);
            this.textNewURL.Name = "textNewURL";
            this.textNewURL.Size = new System.Drawing.Size(440, 21);
            this.textNewURL.TabIndex = 1;
            // 
            // previewBox
            // 
            this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewBox.Location = new System.Drawing.Point(315, 20);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(216, 244);
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
            this.checkBoxFiles.Size = new System.Drawing.Size(303, 244);
            this.checkBoxFiles.TabIndex = 3;
            this.checkBoxFiles.SelectedIndexChanged += new System.EventHandler(this.checkBoxFiles_SelectedIndexChanged);
            // 
            // groupPreview
            // 
            this.groupPreview.Controls.Add(this.previewBox);
            this.groupPreview.Controls.Add(this.checkBoxFiles);
            this.groupPreview.Location = new System.Drawing.Point(12, 39);
            this.groupPreview.Name = "groupPreview";
            this.groupPreview.Size = new System.Drawing.Size(537, 280);
            this.groupPreview.TabIndex = 5;
            this.groupPreview.TabStop = false;
            this.groupPreview.Text = "Preview Thread Items";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 374);
            this.Controls.Add(this.groupPreview);
            this.Controls.Add(this.textNewURL);
            this.Controls.Add(this.buttonGrab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Main";
            this.Text = "STGrab 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.groupPreview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGrab;
        private System.Windows.Forms.TextBox textNewURL;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.CheckedListBox checkBoxFiles;
        private System.Windows.Forms.GroupBox groupPreview;
    }
}

