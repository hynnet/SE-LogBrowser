namespace SE_LogBrowser
{
    partial class MainWindow
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
            this.GroupBoxSetup = new System.Windows.Forms.GroupBox();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonLoadFile = new System.Windows.Forms.Button();
            this.TextBoxLogParseResults = new System.Windows.Forms.RichTextBox();
            this.ProgramStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStripProgressBarFile = new System.Windows.Forms.ToolStripProgressBar();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.GroupBoxSetup.SuspendLayout();
            this.ProgramStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxSetup
            // 
            this.GroupBoxSetup.Controls.Add(this.ButtonReset);
            this.GroupBoxSetup.Controls.Add(this.ButtonLoadFile);
            this.GroupBoxSetup.Location = new System.Drawing.Point(13, 12);
            this.GroupBoxSetup.Name = "GroupBoxSetup";
            this.GroupBoxSetup.Size = new System.Drawing.Size(145, 78);
            this.GroupBoxSetup.TabIndex = 0;
            this.GroupBoxSetup.TabStop = false;
            this.GroupBoxSetup.Text = "Setup";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(6, 47);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(133, 23);
            this.ButtonReset.TabIndex = 1;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonLoadFile
            // 
            this.ButtonLoadFile.Location = new System.Drawing.Point(6, 19);
            this.ButtonLoadFile.Name = "ButtonLoadFile";
            this.ButtonLoadFile.Size = new System.Drawing.Size(133, 23);
            this.ButtonLoadFile.TabIndex = 0;
            this.ButtonLoadFile.Text = "Select Log File";
            this.ButtonLoadFile.UseVisualStyleBackColor = true;
            this.ButtonLoadFile.Click += new System.EventHandler(this.ButtonLoadFile_Click);
            // 
            // TextBoxLogParseResults
            // 
            this.TextBoxLogParseResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLogParseResults.Location = new System.Drawing.Point(165, 18);
            this.TextBoxLogParseResults.Name = "TextBoxLogParseResults";
            this.TextBoxLogParseResults.ReadOnly = true;
            this.TextBoxLogParseResults.Size = new System.Drawing.Size(457, 218);
            this.TextBoxLogParseResults.TabIndex = 2;
            this.TextBoxLogParseResults.Text = "";
            // 
            // ProgramStatusStrip
            // 
            this.ProgramStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabelFile,
            this.StatusStripProgressBarFile});
            this.ProgramStatusStrip.Location = new System.Drawing.Point(0, 239);
            this.ProgramStatusStrip.Name = "ProgramStatusStrip";
            this.ProgramStatusStrip.Size = new System.Drawing.Size(634, 22);
            this.ProgramStatusStrip.TabIndex = 3;
            this.ProgramStatusStrip.Text = "ProgramStatusStrip";
            // 
            // StatusStripLabelFile
            // 
            this.StatusStripLabelFile.Name = "StatusStripLabelFile";
            this.StatusStripLabelFile.Size = new System.Drawing.Size(85, 17);
            this.StatusStripLabelFile.Text = "File not loaded";
            // 
            // StatusStripProgressBarFile
            // 
            this.StatusStripProgressBarFile.Name = "StatusStripProgressBarFile";
            this.StatusStripProgressBarFile.Size = new System.Drawing.Size(100, 16);
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCopyright.AutoSize = true;
            this.LabelCopyright.Location = new System.Drawing.Point(24, 218);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(122, 13);
            this.LabelCopyright.TabIndex = 4;
            this.LabelCopyright.Text = "SE-LogBrowser (c) 2016";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.ProgramStatusStrip);
            this.Controls.Add(this.TextBoxLogParseResults);
            this.Controls.Add(this.GroupBoxSetup);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "MainWindow";
            this.Text = "SE-LogBrowser";
            this.GroupBoxSetup.ResumeLayout(false);
            this.ProgramStatusStrip.ResumeLayout(false);
            this.ProgramStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxSetup;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonLoadFile;
        private System.Windows.Forms.RichTextBox TextBoxLogParseResults;
        private System.Windows.Forms.StatusStrip ProgramStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripLabelFile;
        private System.Windows.Forms.Label LabelCopyright;
        private System.Windows.Forms.ToolStripProgressBar StatusStripProgressBarFile;
    }
}

