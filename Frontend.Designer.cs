﻿namespace nsZip
{
    partial class Frontend
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frontend));
			this.SelectNspFileToCompressButton = new System.Windows.Forms.Button();
			this.DebugOutput = new System.Windows.Forms.RichTextBox();
			this.SelectNspXciDialog = new System.Windows.Forms.OpenFileDialog();
			this.TaskQueue = new System.Windows.Forms.ListBox();
			this.SelectNszFileToDecompressButton = new System.Windows.Forms.Button();
			this.RunButton = new System.Windows.Forms.Button();
			this.SelectNspzDialog = new System.Windows.Forms.OpenFileDialog();
			this.SelectOutputDictionaryButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.SelectOutputDictionaryDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.nsZipSettingsGroupBox = new System.Windows.Forms.GroupBox();
			this.BlockSizeComboBox = new System.Windows.Forms.ComboBox();
			this.BlockSizeLabel = new System.Windows.Forms.Label();
			this.CompressionLevelLabel = new System.Windows.Forms.Label();
			this.CompressionLevelComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nsZipGitHubLinkLabel = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.VerifyAfterCompressCheckBox = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.nsZipSettingsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// SelectNspFileToCompressButton
			// 
			this.SelectNspFileToCompressButton.BackColor = System.Drawing.Color.Lime;
			this.SelectNspFileToCompressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectNspFileToCompressButton.Location = new System.Drawing.Point(0, 3);
			this.SelectNspFileToCompressButton.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
			this.SelectNspFileToCompressButton.Name = "SelectNspFileToCompressButton";
			this.SelectNspFileToCompressButton.Size = new System.Drawing.Size(400, 156);
			this.SelectNspFileToCompressButton.TabIndex = 1;
			this.SelectNspFileToCompressButton.Text = "Select NSP/XCI files to Compress";
			this.SelectNspFileToCompressButton.UseVisualStyleBackColor = false;
			this.SelectNspFileToCompressButton.Click += new System.EventHandler(this.SelectNspFileToCompressButton_Click);
			// 
			// DebugOutput
			// 
			this.DebugOutput.BackColor = System.Drawing.Color.Black;
			this.DebugOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DebugOutput.ForeColor = System.Drawing.Color.White;
			this.DebugOutput.Location = new System.Drawing.Point(33, 473);
			this.DebugOutput.Name = "DebugOutput";
			this.DebugOutput.ReadOnly = true;
			this.DebugOutput.Size = new System.Drawing.Size(1660, 545);
			this.DebugOutput.TabIndex = 100;
			this.DebugOutput.Text = "";
			this.DebugOutput.TextChanged += new System.EventHandler(this.DebugOutput_TextChanged);
			// 
			// SelectNspXciDialog
			// 
			this.SelectNspXciDialog.Filter = "Switch Games (*.nsp;*.xci)|*.nsp;*.xci|Switch Package (*.nsp)|*.ns|Switch Cartrid" +
    "ge (*.xci)|*.xci";
			this.SelectNspXciDialog.Multiselect = true;
			this.SelectNspXciDialog.Title = "Select input NSP fIles...";
			// 
			// TaskQueue
			// 
			this.TaskQueue.BackColor = System.Drawing.Color.Black;
			this.TaskQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TaskQueue.ForeColor = System.Drawing.Color.Lime;
			this.TaskQueue.FormattingEnabled = true;
			this.TaskQueue.HorizontalScrollbar = true;
			this.TaskQueue.IntegralHeight = false;
			this.TaskQueue.ItemHeight = 37;
			this.TaskQueue.Location = new System.Drawing.Point(33, 202);
			this.TaskQueue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TaskQueue.Name = "TaskQueue";
			this.TaskQueue.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.TaskQueue.Size = new System.Drawing.Size(1240, 249);
			this.TaskQueue.TabIndex = 5;
			this.TaskQueue.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listBox_KeyDown);
			// 
			// SelectNszFileToDecompressButton
			// 
			this.SelectNszFileToDecompressButton.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.SelectNszFileToDecompressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectNszFileToDecompressButton.Location = new System.Drawing.Point(420, 3);
			this.SelectNszFileToDecompressButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
			this.SelectNszFileToDecompressButton.Name = "SelectNszFileToDecompressButton";
			this.SelectNszFileToDecompressButton.Size = new System.Drawing.Size(400, 156);
			this.SelectNszFileToDecompressButton.TabIndex = 2;
			this.SelectNszFileToDecompressButton.Text = "Select NSPZ files to Decompress";
			this.SelectNszFileToDecompressButton.UseVisualStyleBackColor = false;
			this.SelectNszFileToDecompressButton.Click += new System.EventHandler(this.SelectNszFileToDecompressButton_Click);
			// 
			// RunButton
			// 
			this.RunButton.BackColor = System.Drawing.Color.DarkOrange;
			this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RunButton.Location = new System.Drawing.Point(1260, 3);
			this.RunButton.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
			this.RunButton.Name = "RunButton";
			this.RunButton.Size = new System.Drawing.Size(400, 156);
			this.RunButton.TabIndex = 4;
			this.RunButton.Text = "RUN!";
			this.RunButton.UseVisualStyleBackColor = false;
			this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
			// 
			// SelectNspzDialog
			// 
			this.SelectNspzDialog.Filter = "Compressed Switch File (*.nspz)|*.nspz|XCIZ to not-installable NSP (*.xciz)|*.xci" +
    "z";
			this.SelectNspzDialog.Multiselect = true;
			this.SelectNspzDialog.Title = "Select input nspz fIles...";
			// 
			// SelectOutputDictionaryButton
			// 
			this.SelectOutputDictionaryButton.BackColor = System.Drawing.Color.Gold;
			this.SelectOutputDictionaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectOutputDictionaryButton.Location = new System.Drawing.Point(840, 3);
			this.SelectOutputDictionaryButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
			this.SelectOutputDictionaryButton.Name = "SelectOutputDictionaryButton";
			this.SelectOutputDictionaryButton.Size = new System.Drawing.Size(400, 156);
			this.SelectOutputDictionaryButton.TabIndex = 3;
			this.SelectOutputDictionaryButton.Text = "Select Output Dictionary";
			this.SelectOutputDictionaryButton.UseVisualStyleBackColor = false;
			this.SelectOutputDictionaryButton.Click += new System.EventHandler(this.SelectOutputDictionaryButton_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.SelectNspFileToCompressButton);
			this.flowLayoutPanel1.Controls.Add(this.SelectNszFileToDecompressButton);
			this.flowLayoutPanel1.Controls.Add(this.SelectOutputDictionaryButton);
			this.flowLayoutPanel1.Controls.Add(this.RunButton);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 24);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1660, 173);
			this.flowLayoutPanel1.TabIndex = 39;
			// 
			// SelectOutputDictionaryDialog
			// 
			this.SelectOutputDictionaryDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// nsZipSettingsGroupBox
			// 
			this.nsZipSettingsGroupBox.Controls.Add(this.BlockSizeComboBox);
			this.nsZipSettingsGroupBox.Controls.Add(this.BlockSizeLabel);
			this.nsZipSettingsGroupBox.Controls.Add(this.CompressionLevelLabel);
			this.nsZipSettingsGroupBox.Controls.Add(this.CompressionLevelComboBox);
			this.nsZipSettingsGroupBox.Controls.Add(this.label2);
			this.nsZipSettingsGroupBox.Controls.Add(this.nsZipGitHubLinkLabel);
			this.nsZipSettingsGroupBox.Controls.Add(this.label1);
			this.nsZipSettingsGroupBox.Controls.Add(this.VerifyAfterCompressCheckBox);
			this.nsZipSettingsGroupBox.ForeColor = System.Drawing.Color.LightCyan;
			this.nsZipSettingsGroupBox.Location = new System.Drawing.Point(1293, 202);
			this.nsZipSettingsGroupBox.Name = "nsZipSettingsGroupBox";
			this.nsZipSettingsGroupBox.Size = new System.Drawing.Size(399, 249);
			this.nsZipSettingsGroupBox.TabIndex = 101;
			this.nsZipSettingsGroupBox.TabStop = false;
			this.nsZipSettingsGroupBox.Text = "nsZip Settings:";
			// 
			// BlockSizeComboBox
			// 
			this.BlockSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BlockSizeComboBox.FormattingEnabled = true;
			this.BlockSizeComboBox.Items.AddRange(new object[] {
            "256 KB",
            "512 KB"});
			this.BlockSizeComboBox.Location = new System.Drawing.Point(200, 109);
			this.BlockSizeComboBox.Name = "BlockSizeComboBox";
			this.BlockSizeComboBox.Size = new System.Drawing.Size(181, 33);
			this.BlockSizeComboBox.TabIndex = 11;
			this.BlockSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.BlockSizeComboBox_SelectedIndexChanged);
			// 
			// BlockSizeLabel
			// 
			this.BlockSizeLabel.AutoSize = true;
			this.BlockSizeLabel.Location = new System.Drawing.Point(75, 117);
			this.BlockSizeLabel.Name = "BlockSizeLabel";
			this.BlockSizeLabel.Size = new System.Drawing.Size(119, 25);
			this.BlockSizeLabel.TabIndex = 10;
			this.BlockSizeLabel.Text = "Block Size:";
			// 
			// CompressionLevelLabel
			// 
			this.CompressionLevelLabel.AutoSize = true;
			this.CompressionLevelLabel.Location = new System.Drawing.Point(6, 73);
			this.CompressionLevelLabel.Name = "CompressionLevelLabel";
			this.CompressionLevelLabel.Size = new System.Drawing.Size(191, 25);
			this.CompressionLevelLabel.TabIndex = 9;
			this.CompressionLevelLabel.Text = "Compresion Level:";
			// 
			// CompressionLevelComboBox
			// 
			this.CompressionLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CompressionLevelComboBox.FormattingEnabled = true;
			this.CompressionLevelComboBox.Items.AddRange(new object[] {
            "[Lv. 08] Faster",
            "[Lv. 12] Fast",
            "[Lv. 14] Normal",
            "[Lv. 18] Great",
            "[Lv. 22] Ultra"});
			this.CompressionLevelComboBox.Location = new System.Drawing.Point(200, 65);
			this.CompressionLevelComboBox.Name = "CompressionLevelComboBox";
			this.CompressionLevelComboBox.Size = new System.Drawing.Size(181, 33);
			this.CompressionLevelComboBox.TabIndex = 8;
			this.CompressionLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.CompressionLevelComboBox_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.LightCyan;
			this.label2.Location = new System.Drawing.Point(6, 162);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(387, 50);
			this.label2.TabIndex = 7;
			this.label2.Text = "Note: XCIZ to XCI isn\'t implemented yet\r\nReport bugs and suggestions under:";
			// 
			// nsZipGitHubLinkLabel
			// 
			this.nsZipGitHubLinkLabel.ActiveLinkColor = System.Drawing.Color.Orange;
			this.nsZipGitHubLinkLabel.AutoSize = true;
			this.nsZipGitHubLinkLabel.LinkColor = System.Drawing.Color.Aqua;
			this.nsZipGitHubLinkLabel.Location = new System.Drawing.Point(6, 212);
			this.nsZipGitHubLinkLabel.Name = "nsZipGitHubLinkLabel";
			this.nsZipGitHubLinkLabel.Size = new System.Drawing.Size(333, 25);
			this.nsZipGitHubLinkLabel.TabIndex = 6;
			this.nsZipGitHubLinkLabel.TabStop = true;
			this.nsZipGitHubLinkLabel.Text = "https://github.com/nicoboss/nsZip";
			this.nsZipGitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nsZipGitHubLinkLabel_LinkClicked);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.LightCyan;
			this.label1.Location = new System.Drawing.Point(6, 212);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 25);
			this.label1.TabIndex = 5;
			// 
			// VerifyAfterCompressCheckBox
			// 
			this.VerifyAfterCompressCheckBox.AutoSize = true;
			this.VerifyAfterCompressCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.VerifyAfterCompressCheckBox.Checked = true;
			this.VerifyAfterCompressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.VerifyAfterCompressCheckBox.ForeColor = System.Drawing.Color.LightCyan;
			this.VerifyAfterCompressCheckBox.Location = new System.Drawing.Point(6, 30);
			this.VerifyAfterCompressCheckBox.Name = "VerifyAfterCompressCheckBox";
			this.VerifyAfterCompressCheckBox.Size = new System.Drawing.Size(375, 29);
			this.VerifyAfterCompressCheckBox.TabIndex = 0;
			this.VerifyAfterCompressCheckBox.Text = "Verify after compress (default: ON)";
			this.VerifyAfterCompressCheckBox.UseVisualStyleBackColor = false;
			this.VerifyAfterCompressCheckBox.CheckedChanged += new System.EventHandler(this.VerifyAfterCompressCheckBox_CheckedChanged);
			// 
			// Frontend
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(1724, 1066);
			this.Controls.Add(this.nsZipSettingsGroupBox);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.TaskQueue);
			this.Controls.Add(this.DebugOutput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1750, 1137);
			this.Name = "Frontend";
			this.Text = "nsZip File Manager v1.0.1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Move += new System.EventHandler(this.Frontend_Move);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.nsZipSettingsGroupBox.ResumeLayout(false);
			this.nsZipSettingsGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Button SelectNspFileToCompressButton;
		private System.Windows.Forms.RichTextBox DebugOutput;
		private System.Windows.Forms.OpenFileDialog SelectNspXciDialog;
		private System.Windows.Forms.ListBox TaskQueue;
		private System.Windows.Forms.Button SelectNszFileToDecompressButton;
		private System.Windows.Forms.Button RunButton;
		private System.Windows.Forms.OpenFileDialog SelectNspzDialog;
		private System.Windows.Forms.Button SelectOutputDictionaryButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FolderBrowserDialog SelectOutputDictionaryDialog;
		private System.Windows.Forms.GroupBox nsZipSettingsGroupBox;
		private System.Windows.Forms.CheckBox VerifyAfterCompressCheckBox;
		private System.Windows.Forms.Label CompressionLevelLabel;
		private System.Windows.Forms.ComboBox CompressionLevelComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel nsZipGitHubLinkLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox BlockSizeComboBox;
		private System.Windows.Forms.Label BlockSizeLabel;
	}
}

