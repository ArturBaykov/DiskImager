﻿namespace DynamicDevices.DiskWriter
{
    partial class MainForm
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
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelDriveTitle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxCompression = new System.Windows.Forms.GroupBox();
            this.radioButtonCompNone = new System.Windows.Forms.RadioButton();
            this.radioButtonCompTgz = new System.Windows.Forms.RadioButton();
            this.radioButtonCompGz = new System.Windows.Forms.RadioButton();
            this.radioButtonCompZip = new System.Windows.Forms.RadioButton();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllDrivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxTruncation = new System.Windows.Forms.GroupBox();
            this.checkBoxUseMBR = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1.SuspendLayout();
            this.groupBoxCompression.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.groupBoxTruncation.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(10, 61);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(420, 20);
            this.textBoxFileName.TabIndex = 1;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.TextBoxFileNameTextChanged);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(10, 115);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.ButtonReadClick);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(93, 115);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonWrite.TabIndex = 3;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.ButtonWriteClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(255, 115);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Location = new System.Drawing.Point(436, 60);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(25, 20);
            this.buttonChooseFile.TabIndex = 5;
            this.buttonChooseFile.Text = "...";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.ButtonChooseFileClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(620, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.DefaultExt = "img";
            this.saveFileDialog1.Filter = "Image Files (*.img)|*.img|Binary files (*.bin)|*.bin|All files (*.*)|*.*";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(12, 34);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(54, 13);
            this.labelFileName.TabIndex = 7;
            this.labelFileName.Text = "File Name";
            // 
            // labelDriveTitle
            // 
            this.labelDriveTitle.AutoSize = true;
            this.labelDriveTitle.Location = new System.Drawing.Point(466, 34);
            this.labelDriveTitle.Name = "labelDriveTitle";
            this.labelDriveTitle.Size = new System.Drawing.Size(89, 13);
            this.labelDriveTitle.TabIndex = 8;
            this.labelDriveTitle.Text = "Removable Drive";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(174, 115);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // groupBoxCompression
            // 
            this.groupBoxCompression.Controls.Add(this.radioButtonCompNone);
            this.groupBoxCompression.Controls.Add(this.radioButtonCompTgz);
            this.groupBoxCompression.Controls.Add(this.radioButtonCompGz);
            this.groupBoxCompression.Controls.Add(this.radioButtonCompZip);
            this.groupBoxCompression.Location = new System.Drawing.Point(98, 176);
            this.groupBoxCompression.Name = "groupBoxCompression";
            this.groupBoxCompression.Size = new System.Drawing.Size(252, 49);
            this.groupBoxCompression.TabIndex = 11;
            this.groupBoxCompression.TabStop = false;
            this.groupBoxCompression.Text = "Compression";
            // 
            // radioButtonCompNone
            // 
            this.radioButtonCompNone.AutoSize = true;
            this.radioButtonCompNone.Checked = true;
            this.radioButtonCompNone.Location = new System.Drawing.Point(170, 19);
            this.radioButtonCompNone.Name = "radioButtonCompNone";
            this.radioButtonCompNone.Size = new System.Drawing.Size(56, 17);
            this.radioButtonCompNone.TabIndex = 3;
            this.radioButtonCompNone.TabStop = true;
            this.radioButtonCompNone.Text = "NONE";
            this.radioButtonCompNone.UseVisualStyleBackColor = true;
            this.radioButtonCompNone.CheckedChanged += new System.EventHandler(this.RadioButtonCompNoneCheckedChanged);
            // 
            // radioButtonCompTgz
            // 
            this.radioButtonCompTgz.AutoSize = true;
            this.radioButtonCompTgz.Location = new System.Drawing.Point(117, 19);
            this.radioButtonCompTgz.Name = "radioButtonCompTgz";
            this.radioButtonCompTgz.Size = new System.Drawing.Size(47, 17);
            this.radioButtonCompTgz.TabIndex = 2;
            this.radioButtonCompTgz.Text = "TGZ";
            this.radioButtonCompTgz.UseVisualStyleBackColor = true;
            this.radioButtonCompTgz.CheckedChanged += new System.EventHandler(this.RadioButtonCompTgzCheckedChanged);
            // 
            // radioButtonCompGz
            // 
            this.radioButtonCompGz.AutoSize = true;
            this.radioButtonCompGz.Location = new System.Drawing.Point(71, 19);
            this.radioButtonCompGz.Name = "radioButtonCompGz";
            this.radioButtonCompGz.Size = new System.Drawing.Size(40, 17);
            this.radioButtonCompGz.TabIndex = 1;
            this.radioButtonCompGz.Text = "GZ";
            this.radioButtonCompGz.UseVisualStyleBackColor = true;
            this.radioButtonCompGz.CheckedChanged += new System.EventHandler(this.RadioButtonCompGzCheckedChanged);
            // 
            // radioButtonCompZip
            // 
            this.radioButtonCompZip.AutoSize = true;
            this.radioButtonCompZip.Location = new System.Drawing.Point(23, 19);
            this.radioButtonCompZip.Name = "radioButtonCompZip";
            this.radioButtonCompZip.Size = new System.Drawing.Size(42, 17);
            this.radioButtonCompZip.TabIndex = 0;
            this.radioButtonCompZip.Text = "ZIP";
            this.radioButtonCompZip.UseVisualStyleBackColor = true;
            this.radioButtonCompZip.CheckedChanged += new System.EventHandler(this.RadioButtonCompZipCheckedChanged);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(620, 24);
            this.menuStripMain.TabIndex = 12;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAllDrivesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // displayAllDrivesToolStripMenuItem
            // 
            this.displayAllDrivesToolStripMenuItem.CheckOnClick = true;
            this.displayAllDrivesToolStripMenuItem.Name = "displayAllDrivesToolStripMenuItem";
            this.displayAllDrivesToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.displayAllDrivesToolStripMenuItem.Text = "Display All Drives  *** DANGEROUS ***";
            this.displayAllDrivesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.DisplayAllDrivesToolStripMenuItemCheckedChanged);
            // 
            // groupBoxTruncation
            // 
            this.groupBoxTruncation.Controls.Add(this.checkBoxUseMBR);
            this.groupBoxTruncation.Location = new System.Drawing.Point(356, 177);
            this.groupBoxTruncation.Name = "groupBoxTruncation";
            this.groupBoxTruncation.Size = new System.Drawing.Size(252, 48);
            this.groupBoxTruncation.TabIndex = 13;
            this.groupBoxTruncation.TabStop = false;
            this.groupBoxTruncation.Text = "Image Truncation";
            // 
            // checkBoxUseMBR
            // 
            this.checkBoxUseMBR.AutoSize = true;
            this.checkBoxUseMBR.Location = new System.Drawing.Point(23, 19);
            this.checkBoxUseMBR.Name = "checkBoxUseMBR";
            this.checkBoxUseMBR.Size = new System.Drawing.Size(138, 17);
            this.checkBoxUseMBR.TabIndex = 0;
            this.checkBoxUseMBR.Text = "Use MBR partition sizes";
            this.checkBoxUseMBR.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(469, 58);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(139, 109);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 231);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(211, 100);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(229, 231);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(379, 100);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 357);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBoxTruncation);
            this.Controls.Add(this.groupBoxCompression);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelDriveTitle);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.textBoxFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Disk Imager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxCompression.ResumeLayout(false);
            this.groupBoxCompression.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxTruncation.ResumeLayout(false);
            this.groupBoxTruncation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelDriveTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxCompression;
        private System.Windows.Forms.RadioButton radioButtonCompNone;
        private System.Windows.Forms.RadioButton radioButtonCompTgz;
        private System.Windows.Forms.RadioButton radioButtonCompGz;
        private System.Windows.Forms.RadioButton radioButtonCompZip;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllDrivesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxTruncation;
        private System.Windows.Forms.CheckBox checkBoxUseMBR;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

