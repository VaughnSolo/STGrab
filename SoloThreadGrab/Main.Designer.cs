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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonGrab = new System.Windows.Forms.Button();
            this.textNewURL = new System.Windows.Forms.TextBox();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.checkBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.groupPreview = new System.Windows.Forms.GroupBox();
            this.textLoadedURL = new System.Windows.Forms.TextBox();
            this.labelCheckedCount = new System.Windows.Forms.Label();
            this.labelFileCount = new System.Windows.Forms.Label();
            this.textThreadTitle = new System.Windows.Forms.TextBox();
            this.labelThreadTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupDownload = new System.Windows.Forms.GroupBox();
            this.radioDownPar = new System.Windows.Forms.RadioButton();
            this.radioDownSeq = new System.Windows.Forms.RadioButton();
            this.checkBoxCombine = new System.Windows.Forms.CheckBox();
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupMode = new System.Windows.Forms.GroupBox();
            this.radioS = new System.Windows.Forms.RadioButton();
            this.radioSP = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.listMultiLinks = new System.Windows.Forms.ListBox();
            this.progressThreads = new System.Windows.Forms.ProgressBar();
            this.groupMultiThread = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listMultiStatus = new System.Windows.Forms.ListBox();
            this.listMultiNames = new System.Windows.Forms.ListBox();
            this.hoverTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.groupPreview.SuspendLayout();
            this.groupDownload.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupMode.SuspendLayout();
            this.groupMultiThread.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGrab
            // 
            this.buttonGrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonGrab.Location = new System.Drawing.Point(458, 236);
            this.buttonGrab.Name = "buttonGrab";
            this.buttonGrab.Size = new System.Drawing.Size(91, 21);
            this.buttonGrab.TabIndex = 0;
            this.buttonGrab.Text = "Load";
            this.buttonGrab.UseVisualStyleBackColor = true;
            this.buttonGrab.Click += new System.EventHandler(this.buttonGrab_Click);
            // 
            // textNewURL
            // 
            this.textNewURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textNewURL.Location = new System.Drawing.Point(107, 236);
            this.textNewURL.Name = "textNewURL";
            this.textNewURL.Size = new System.Drawing.Size(345, 21);
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
            this.checkBoxFiles.Location = new System.Drawing.Point(6, 50);
            this.checkBoxFiles.Name = "checkBoxFiles";
            this.checkBoxFiles.Size = new System.Drawing.Size(295, 214);
            this.checkBoxFiles.TabIndex = 3;
            this.checkBoxFiles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkBoxFiles_ItemCheck);
            this.checkBoxFiles.SelectedIndexChanged += new System.EventHandler(this.checkBoxFiles_SelectedIndexChanged);
            // 
            // groupPreview
            // 
            this.groupPreview.Controls.Add(this.textLoadedURL);
            this.groupPreview.Controls.Add(this.labelCheckedCount);
            this.groupPreview.Controls.Add(this.labelFileCount);
            this.groupPreview.Controls.Add(this.previewBox);
            this.groupPreview.Controls.Add(this.checkBoxFiles);
            this.groupPreview.Controls.Add(this.textThreadTitle);
            this.groupPreview.Controls.Add(this.labelThreadTitle);
            this.groupPreview.Location = new System.Drawing.Point(18, 259);
            this.groupPreview.Name = "groupPreview";
            this.groupPreview.Size = new System.Drawing.Size(531, 305);
            this.groupPreview.TabIndex = 5;
            this.groupPreview.TabStop = false;
            this.groupPreview.Text = "Thread Item Preview";
            // 
            // textLoadedURL
            // 
            this.textLoadedURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textLoadedURL.Location = new System.Drawing.Point(6, 20);
            this.textLoadedURL.Name = "textLoadedURL";
            this.textLoadedURL.ReadOnly = true;
            this.textLoadedURL.Size = new System.Drawing.Size(295, 21);
            this.textLoadedURL.TabIndex = 9;
            // 
            // labelCheckedCount
            // 
            this.labelCheckedCount.AutoSize = true;
            this.labelCheckedCount.Location = new System.Drawing.Point(411, 246);
            this.labelCheckedCount.Name = "labelCheckedCount";
            this.labelCheckedCount.Size = new System.Drawing.Size(68, 15);
            this.labelCheckedCount.TabIndex = 5;
            this.labelCheckedCount.Text = "Checked: 0";
            // 
            // labelFileCount
            // 
            this.labelFileCount.AutoSize = true;
            this.labelFileCount.Location = new System.Drawing.Point(307, 246);
            this.labelFileCount.Name = "labelFileCount";
            this.labelFileCount.Size = new System.Drawing.Size(55, 15);
            this.labelFileCount.TabIndex = 4;
            this.labelFileCount.Text = "Found: 0";
            // 
            // textThreadTitle
            // 
            this.textThreadTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textThreadTitle.Location = new System.Drawing.Point(98, 270);
            this.textThreadTitle.Name = "textThreadTitle";
            this.textThreadTitle.Size = new System.Drawing.Size(427, 21);
            this.textThreadTitle.TabIndex = 7;
            // 
            // labelThreadTitle
            // 
            this.labelThreadTitle.AutoSize = true;
            this.labelThreadTitle.Location = new System.Drawing.Point(6, 273);
            this.labelThreadTitle.Name = "labelThreadTitle";
            this.labelThreadTitle.Size = new System.Drawing.Size(86, 15);
            this.labelThreadTitle.TabIndex = 8;
            this.labelThreadTitle.Text = "Thread Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thread URL:";
            // 
            // groupDownload
            // 
            this.groupDownload.Controls.Add(this.radioDownPar);
            this.groupDownload.Controls.Add(this.radioDownSeq);
            this.groupDownload.Controls.Add(this.checkBoxCombine);
            this.groupDownload.Controls.Add(this.buttonOutputSelect);
            this.groupDownload.Controls.Add(this.panel1);
            this.groupDownload.Controls.Add(this.label2);
            this.groupDownload.Controls.Add(this.textOutputPath);
            this.groupDownload.Location = new System.Drawing.Point(18, 65);
            this.groupDownload.Name = "groupDownload";
            this.groupDownload.Size = new System.Drawing.Size(531, 156);
            this.groupDownload.TabIndex = 9;
            this.groupDownload.TabStop = false;
            this.groupDownload.Text = "Download Options";
            // 
            // radioDownPar
            // 
            this.radioDownPar.AutoSize = true;
            this.radioDownPar.Checked = true;
            this.radioDownPar.Location = new System.Drawing.Point(155, 130);
            this.radioDownPar.Name = "radioDownPar";
            this.radioDownPar.Size = new System.Drawing.Size(126, 19);
            this.radioDownPar.TabIndex = 17;
            this.radioDownPar.TabStop = true;
            this.radioDownPar.Text = "Parallel Download";
            this.radioDownPar.UseVisualStyleBackColor = true;
            // 
            // radioDownSeq
            // 
            this.radioDownSeq.AutoSize = true;
            this.radioDownSeq.Location = new System.Drawing.Point(6, 130);
            this.radioDownSeq.Name = "radioDownSeq";
            this.radioDownSeq.Size = new System.Drawing.Size(143, 19);
            this.radioDownSeq.TabIndex = 16;
            this.radioDownSeq.Text = "Sequential Download";
            this.radioDownSeq.UseVisualStyleBackColor = true;
            // 
            // checkBoxCombine
            // 
            this.checkBoxCombine.AutoSize = true;
            this.checkBoxCombine.Checked = true;
            this.checkBoxCombine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCombine.Location = new System.Drawing.Point(325, 131);
            this.checkBoxCombine.Name = "checkBoxCombine";
            this.checkBoxCombine.Size = new System.Drawing.Size(200, 19);
            this.checkBoxCombine.TabIndex = 15;
            this.checkBoxCombine.Text = "Continue if Folder Already Exists";
            this.checkBoxCombine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCombine.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(6, 47);
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
            this.progressBarDownload.Location = new System.Drawing.Point(18, 606);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(531, 16);
            this.progressBarDownload.Step = 1;
            this.progressBarDownload.TabIndex = 16;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(18, 570);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(531, 30);
            this.buttonDownload.TabIndex = 15;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(18, 570);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(531, 30);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupMode
            // 
            this.groupMode.Controls.Add(this.radioS);
            this.groupMode.Controls.Add(this.radioSP);
            this.groupMode.Controls.Add(this.radioM);
            this.groupMode.Location = new System.Drawing.Point(18, 13);
            this.groupMode.Name = "groupMode";
            this.groupMode.Size = new System.Drawing.Size(531, 46);
            this.groupMode.TabIndex = 18;
            this.groupMode.TabStop = false;
            this.groupMode.Text = "Download Mode";
            // 
            // radioS
            // 
            this.radioS.AutoSize = true;
            this.radioS.Location = new System.Drawing.Point(211, 20);
            this.radioS.Name = "radioS";
            this.radioS.Size = new System.Drawing.Size(170, 19);
            this.radioS.TabIndex = 2;
            this.radioS.Text = "Single Thread w/o Preview";
            this.radioS.UseVisualStyleBackColor = true;
            this.radioS.CheckedChanged += new System.EventHandler(this.DownloadModeSwitch);
            // 
            // radioSP
            // 
            this.radioSP.AutoSize = true;
            this.radioSP.Checked = true;
            this.radioSP.Location = new System.Drawing.Point(12, 20);
            this.radioSP.Name = "radioSP";
            this.radioSP.Size = new System.Drawing.Size(163, 19);
            this.radioSP.TabIndex = 1;
            this.radioSP.TabStop = true;
            this.radioSP.Text = "Single Thread w/ Preview";
            this.radioSP.UseVisualStyleBackColor = true;
            this.radioSP.CheckedChanged += new System.EventHandler(this.DownloadModeSwitch);
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(414, 20);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(111, 19);
            this.radioM.TabIndex = 0;
            this.radioM.Text = "Multiple Thread";
            this.radioM.UseVisualStyleBackColor = true;
            this.radioM.CheckedChanged += new System.EventHandler(this.DownloadModeSwitch);
            // 
            // listMultiLinks
            // 
            this.listMultiLinks.FormattingEnabled = true;
            this.listMultiLinks.ItemHeight = 15;
            this.listMultiLinks.Location = new System.Drawing.Point(6, 20);
            this.listMultiLinks.Name = "listMultiLinks";
            this.listMultiLinks.Size = new System.Drawing.Size(224, 244);
            this.listMultiLinks.TabIndex = 19;
            // 
            // progressThreads
            // 
            this.progressThreads.Location = new System.Drawing.Point(18, 628);
            this.progressThreads.Name = "progressThreads";
            this.progressThreads.Size = new System.Drawing.Size(531, 16);
            this.progressThreads.Step = 1;
            this.progressThreads.TabIndex = 20;
            this.progressThreads.Visible = false;
            // 
            // groupMultiThread
            // 
            this.groupMultiThread.Controls.Add(this.buttonClear);
            this.groupMultiThread.Controls.Add(this.buttonRemove);
            this.groupMultiThread.Controls.Add(this.listMultiStatus);
            this.groupMultiThread.Controls.Add(this.listMultiNames);
            this.groupMultiThread.Controls.Add(this.listMultiLinks);
            this.groupMultiThread.Location = new System.Drawing.Point(18, 259);
            this.groupMultiThread.Name = "groupMultiThread";
            this.groupMultiThread.Size = new System.Drawing.Size(531, 305);
            this.groupMultiThread.TabIndex = 21;
            this.groupMultiThread.TabStop = false;
            this.groupMultiThread.Text = "Thread List";
            this.groupMultiThread.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(87, 270);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 29);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(6, 270);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 29);
            this.buttonRemove.TabIndex = 22;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listMultiStatus
            // 
            this.listMultiStatus.FormattingEnabled = true;
            this.listMultiStatus.ItemHeight = 15;
            this.listMultiStatus.Location = new System.Drawing.Point(404, 20);
            this.listMultiStatus.Name = "listMultiStatus";
            this.listMultiStatus.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listMultiStatus.Size = new System.Drawing.Size(121, 244);
            this.listMultiStatus.TabIndex = 21;
            this.hoverTip.SetToolTip(this.listMultiStatus, "DLed = Downloaded | Fail = Failed to Download | Prev = Previously Downloaded");
            // 
            // listMultiNames
            // 
            this.listMultiNames.FormattingEnabled = true;
            this.listMultiNames.ItemHeight = 15;
            this.listMultiNames.Location = new System.Drawing.Point(236, 20);
            this.listMultiNames.Name = "listMultiNames";
            this.listMultiNames.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listMultiNames.Size = new System.Drawing.Size(162, 244);
            this.listMultiNames.TabIndex = 20;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 651);
            this.Controls.Add(this.groupMultiThread);
            this.Controls.Add(this.progressThreads);
            this.Controls.Add(this.groupMode);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.groupPreview);
            this.Controls.Add(this.groupDownload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNewURL);
            this.Controls.Add(this.buttonGrab);
            this.Controls.Add(this.buttonCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "STGrab 1.3";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.groupPreview.ResumeLayout(false);
            this.groupPreview.PerformLayout();
            this.groupDownload.ResumeLayout(false);
            this.groupDownload.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupMode.ResumeLayout(false);
            this.groupMode.PerformLayout();
            this.groupMultiThread.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox checkBoxCombine;
        private System.Windows.Forms.RadioButton radioDownPar;
        private System.Windows.Forms.RadioButton radioDownSeq;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupMode;
        private System.Windows.Forms.RadioButton radioS;
        private System.Windows.Forms.RadioButton radioSP;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.ListBox listMultiLinks;
        private System.Windows.Forms.ProgressBar progressThreads;
        private System.Windows.Forms.TextBox textLoadedURL;
        private System.Windows.Forms.GroupBox groupMultiThread;
        private System.Windows.Forms.ListBox listMultiStatus;
        private System.Windows.Forms.ListBox listMultiNames;
        private System.Windows.Forms.ToolTip hoverTip;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemove;
    }
}

