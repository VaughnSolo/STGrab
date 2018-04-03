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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.groupPreview.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGrab
            // 
            this.buttonGrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonGrab.Location = new System.Drawing.Point(458, 5);
            this.buttonGrab.Name = "buttonGrab";
            this.buttonGrab.Size = new System.Drawing.Size(91, 23);
            this.buttonGrab.TabIndex = 0;
            this.buttonGrab.Text = "Grab";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 158);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download";
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox1.Location = new System.Drawing.Point(86, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(383, 21);
            this.textBox1.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(109, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(231, 19);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "/Board Name/Thread Name/Files.type";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 78);
            this.panel1.TabIndex = 12;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(109, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(158, 19);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "/Thread Name/Files.type";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Folder Structure:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(109, 53);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(144, 19);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "/Files.type (No Folder)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.Location = new System.Drawing.Point(475, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 78);
            this.button2.TabIndex = 15;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(525, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 505);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

