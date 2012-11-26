﻿namespace M43RawAnalyzer
{
    partial class Form1
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
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.labelProcessing = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Location = new System.Drawing.Point(23, 13);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(118, 23);
            this.buttonSelectDirectory.TabIndex = 0;
            this.buttonSelectDirectory.Text = "Select Directory";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.buttonSelectDirectory_Click);
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Location = new System.Drawing.Point(23, 43);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(118, 23);
            this.buttonAnalyze.TabIndex = 1;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // labelDirectory
            // 
            this.labelDirectory.Location = new System.Drawing.Point(148, 22);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(375, 14);
            this.labelDirectory.TabIndex = 2;
            this.labelDirectory.Text = "Directory: ";
            // 
            // labelFile
            // 
            this.labelFile.Location = new System.Drawing.Point(148, 43);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(375, 13);
            this.labelFile.TabIndex = 3;
            this.labelFile.Text = "File: ";
            // 
            // labelProcessing
            // 
            this.labelProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProcessing.Location = new System.Drawing.Point(148, 65);
            this.labelProcessing.Name = "labelProcessing";
            this.labelProcessing.Size = new System.Drawing.Size(373, 18);
            this.labelProcessing.TabIndex = 4;
            this.labelProcessing.Text = "Processing file 1 from 1.";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(151, 93);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(327, 23);
            this.progressBar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 132);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelProcessing);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.buttonSelectDirectory);
            this.MinimumSize = new System.Drawing.Size(0, 170);
            this.Name = "Form1";
            this.Text = "M43RawAnalyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProcessing;
    }
}

