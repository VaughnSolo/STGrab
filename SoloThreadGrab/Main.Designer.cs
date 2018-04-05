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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonGrab = new System.Windows.Forms.Button();
            this.textNewURL = new System.Windows.Forms.TextBox();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.checkBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.groupPreview = new System.Windows.Forms.GroupBox();
            this.labelCheckedCount = new System.Windows.Forms.Label();
            this.labelFileCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textThreadTitle = new System.Windows.Forms.TextBox();
            this.labelThreadTitle = new System.Windows.Forms.Label();
            this.groupDownload = new System.Windows.Forms.GroupBox();
            this.radioDownPar = new System.Windows.Forms.RadioButton();
            this.radioDownSeq = new System.Windows.Forms.RadioButton();
            this.checkBoxCombine = new System.Windows.Forms.CheckBox();
            this.textThreadFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOutputSelect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioNoFolders = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioNoBoard = new System.Windows.Forms.RadioButton();
            this.radioFullPath = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textOutputPath = new System.Windows.Forms.TextBox();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.buttonDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.groupPreview.SuspendLayout();
            this.groupDownload.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGrab
            // 
            this.buttonGrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonGrab.Location = new System.Drawing.Point(458, 6);
            this.buttonGrab.Name = "buttonGrab";
            this.buttonGrab.Size = new System.Drawing.Size(91, 21);
            this.buttonGrab.TabIndex = 0;
            this.buttonGrab.Text = "Grab";
            this.buttonGrab.UseVisualStyleBackColor = true;
            this.buttonGrab.Click += new System.EventHandler(this.buttonGrab_Click);
            // 
            // textNewURL
            // 
            this.textNewURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textNewURL.Location = new System.Drawing.Point(104, 6);
            this.textNewURL.Name = "textNewURL";
            this.textNewURL.Size = new System.Drawing.Size(348, 21);
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
            this.groupPreview.Enabled = false;
            this.groupPreview.Location = new System.Drawing.Point(18, 60);
            this.groupPreview.Name = "groupPreview";
            this.groupPreview.Size = new System.Drawing.Size(531, 268);
            this.groupPreview.TabIndex = 5;
            this.groupPreview.TabStop = false;
            this.groupPreview.Text = "Thread Item Preview";
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
            // labelFileCount
            // 
            this.labelFileCount.AutoSize = true;
            this.labelFileCount.Location = new System.Drawing.Point(307, 246);
            this.labelFileCount.Name = "labelFileCount";
            this.labelFileCount.Size = new System.Drawing.Size(45, 15);
            this.labelFileCount.TabIndex = 4;
            this.labelFileCount.Text = "Found:";
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
            this.textThreadTitle.Location = new System.Drawing.Point(104, 33);
            this.textThreadTitle.Name = "textThreadTitle";
            this.textThreadTitle.ReadOnly = true;
            this.textThreadTitle.Size = new System.Drawing.Size(445, 21);
            this.textThreadTitle.TabIndex = 7;
            // 
            // labelThreadTitle
            // 
            this.labelThreadTitle.AutoSize = true;
            this.labelThreadTitle.Location = new System.Drawing.Point(15, 36);
            this.labelThreadTitle.Name = "labelThreadTitle";
            this.labelThreadTitle.Size = new System.Drawing.Size(86, 15);
            this.labelThreadTitle.TabIndex = 8;
            this.labelThreadTitle.Text = "Thread Name:";
            // 
            // groupDownload
            // 
            this.groupDownload.Controls.Add(this.radioDownPar);
            this.groupDownload.Controls.Add(this.radioDownSeq);
            this.groupDownload.Controls.Add(this.checkBoxCombine);
            this.groupDownload.Controls.Add(this.textThreadFolder);
            this.groupDownload.Controls.Add(this.label4);
            this.groupDownload.Controls.Add(this.buttonOutputSelect);
            this.groupDownload.Controls.Add(this.panel1);
            this.groupDownload.Controls.Add(this.label2);
            this.groupDownload.Controls.Add(this.textOutputPath);
            this.groupDownload.Enabled = false;
            this.groupDownload.Location = new System.Drawing.Point(18, 335);
            this.groupDownload.Name = "groupDownload";
            this.groupDownload.Size = new System.Drawing.Size(531, 176);
            this.groupDownload.TabIndex = 9;
            this.groupDownload.TabStop = false;
            this.groupDownload.Text = "Download";
            // 
            // radioDownPar
            // 
            this.radioDownPar.AutoSize = true;
            this.radioDownPar.Enabled = false;
            this.radioDownPar.Location = new System.Drawing.Point(155, 154);
            this.radioDownPar.Name = "radioDownPar";
            this.radioDownPar.Size = new System.Drawing.Size(126, 19);
            this.radioDownPar.TabIndex = 17;
            this.radioDownPar.Text = "Parallel Download";
            this.radioDownPar.UseVisualStyleBackColor = true;
            // 
            // radioDownSeq
            // 
            this.radioDownSeq.AutoSize = true;
            this.radioDownSeq.Checked = true;
            this.radioDownSeq.Location = new System.Drawing.Point(6, 154);
            this.radioDownSeq.Name = "radioDownSeq";
            this.radioDownSeq.Size = new System.Drawing.Size(143, 19);
            this.radioDownSeq.TabIndex = 16;
            this.radioDownSeq.TabStop = true;
            this.radioDownSeq.Text = "Sequential Download";
            this.radioDownSeq.UseVisualStyleBackColor = true;
            // 
            // checkBoxCombine
            // 
            this.checkBoxCombine.AutoSize = true;
            this.checkBoxCombine.Checked = true;
            this.checkBoxCombine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCombine.Location = new System.Drawing.Point(325, 155);
            this.checkBoxCombine.Name = "checkBoxCombine";
            this.checkBoxCombine.Size = new System.Drawing.Size(200, 19);
            this.checkBoxCombine.TabIndex = 15;
            this.checkBoxCombine.Text = "Continue if Folder Already Exists";
            this.checkBoxCombine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCombine.UseVisualStyleBackColor = true;
            // 
            // textThreadFolder
            // 
            this.textThreadFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textThreadFolder.Location = new System.Drawing.Point(167, 44);
            this.textThreadFolder.Name = "textThreadFolder";
            this.textThreadFolder.Size = new System.Drawing.Size(358, 21);
            this.textThreadFolder.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Thread Name (Folder Title):";
            // 
            // buttonOutputSelect
            // 
            this.buttonOutputSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonOutputSelect.Location = new System.Drawing.Point(475, 20);
            this.buttonOutputSelect.Name = "buttonOutputSelect";
            this.buttonOutputSelect.Size = new System.Drawing.Size(50, 21);
            this.buttonOutputSelect.TabIndex = 13;
            this.buttonOutputSelect.Text = "Browse";
            this.buttonOutputSelect.UseVisualStyleBackColor = true;
            this.buttonOutputSelect.Click += new System.EventHandler(this.buttonOutputSelect_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioNoFolders);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioNoBoard);
            this.panel1.Controls.Add(this.radioFullPath);
            this.panel1.Location = new System.Drawing.Point(6, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 78);
            this.panel1.TabIndex = 12;
            // 
            // radioNoFolders
            // 
            this.radioNoFolders.AutoSize = true;
            this.radioNoFolders.Location = new System.Drawing.Point(102, 53);
            this.radioNoFolders.Name = "radioNoFolders";
            this.radioNoFolders.Size = new System.Drawing.Size(143, 19);
            this.radioNoFolders.TabIndex = 14;
            this.radioNoFolders.Text = "Output Path\\Files.type";
            this.radioNoFolders.UseVisualStyleBackColor = true;
            this.radioNoFolders.CheckedChanged += new System.EventHandler(this.FolderStruct_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Folder Structure:";
            // 
            // radioNoBoard
            // 
            this.radioNoBoard.AutoSize = true;
            this.radioNoBoard.Location = new System.Drawing.Point(102, 28);
            this.radioNoBoard.Name = "radioNoBoard";
            this.radioNoBoard.Size = new System.Drawing.Size(222, 19);
            this.radioNoBoard.TabIndex = 12;
            this.radioNoBoard.Text = "Output Path\\Thread Name\\Files.type";
            this.radioNoBoard.UseVisualStyleBackColor = true;
            this.radioNoBoard.CheckedChanged += new System.EventHandler(this.FolderStruct_Changed);
            // 
            // radioFullPath
            // 
            this.radioFullPath.AutoSize = true;
            this.radioFullPath.Checked = true;
            this.radioFullPath.Location = new System.Drawing.Point(102, 3);
            this.radioFullPath.Name = "radioFullPath";
            this.radioFullPath.Size = new System.Drawing.Size(295, 19);
            this.radioFullPath.TabIndex = 11;
            this.radioFullPath.TabStop = true;
            this.radioFullPath.Text = "Output Path\\Board Name\\Thread Name\\Files.type";
            this.radioFullPath.UseVisualStyleBackColor = true;
            this.radioFullPath.CheckedChanged += new System.EventHandler(this.FolderStruct_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Output Path:";
            // 
            // textOutputPath
            // 
            this.textOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textOutputPath.Location = new System.Drawing.Point(86, 20);
            this.textOutputPath.Name = "textOutputPath";
            this.textOutputPath.ReadOnly = true;
            this.textOutputPath.Size = new System.Drawing.Size(383, 21);
            this.textOutputPath.TabIndex = 9;
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(199, 517);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(350, 52);
            this.progressBarDownload.Step = 1;
            this.progressBarDownload.TabIndex = 16;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Enabled = false;
            this.buttonDownload.Location = new System.Drawing.Point(18, 517);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(175, 52);
            this.buttonDownload.TabIndex = 15;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 596);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.groupDownload);
            this.Controls.Add(this.labelThreadTitle);
            this.Controls.Add(this.textThreadTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupPreview);
            this.Controls.Add(this.textNewURL);
            this.Controls.Add(this.buttonGrab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "STGrab 1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.groupPreview.ResumeLayout(false);
            this.groupPreview.PerformLayout();
            this.groupDownload.ResumeLayout(false);
            this.groupDownload.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupDownload;
        private System.Windows.Forms.Button buttonOutputSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioNoFolders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioNoBoard;
        private System.Windows.Forms.RadioButton radioFullPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOutputPath;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.TextBox textThreadFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxCombine;
        private System.Windows.Forms.RadioButton radioDownPar;
        private System.Windows.Forms.RadioButton radioDownSeq;
    }
}

