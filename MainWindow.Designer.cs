
namespace RBLXCompressor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.currentFile = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.processStatus = new System.Windows.Forms.Label();
            this.novetusLink = new System.Windows.Forms.LinkLabel();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.personalWebLink = new System.Windows.Forms.LinkLabel();
            this.versionString = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current File:";
            // 
            // currentFile
            // 
            this.currentFile.AutoSize = true;
            this.currentFile.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.currentFile.ForeColor = System.Drawing.SystemColors.Control;
            this.currentFile.Location = new System.Drawing.Point(81, 56);
            this.currentFile.Name = "currentFile";
            this.currentFile.Size = new System.Drawing.Size(43, 13);
            this.currentFile.TabIndex = 1;
            this.currentFile.Text = "currfile";
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.Gray;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.selectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.selectButton.Location = new System.Drawing.Point(12, 30);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(336, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select Place";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // processStatus
            // 
            this.processStatus.AutoSize = true;
            this.processStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.processStatus.Location = new System.Drawing.Point(60, 14);
            this.processStatus.Name = "processStatus";
            this.processStatus.Size = new System.Drawing.Size(78, 13);
            this.processStatus.TabIndex = 5;
            this.processStatus.Text = "processStatus";
            // 
            // novetusLink
            // 
            this.novetusLink.AutoSize = true;
            this.novetusLink.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.novetusLink.ForeColor = System.Drawing.SystemColors.Control;
            this.novetusLink.LinkColor = System.Drawing.Color.White;
            this.novetusLink.Location = new System.Drawing.Point(9, 80);
            this.novetusLink.Name = "novetusLink";
            this.novetusLink.Size = new System.Drawing.Size(259, 13);
            this.novetusLink.TabIndex = 6;
            this.novetusLink.TabStop = true;
            this.novetusLink.Text = "Also check out Novetus! an old ROBLOX launcher";
            this.novetusLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.githubLink.ForeColor = System.Drawing.SystemColors.Control;
            this.githubLink.LinkColor = System.Drawing.Color.White;
            this.githubLink.Location = new System.Drawing.Point(290, 67);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(44, 13);
            this.githubLink.TabIndex = 7;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "GitHub";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // personalWebLink
            // 
            this.personalWebLink.AutoSize = true;
            this.personalWebLink.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.personalWebLink.ForeColor = System.Drawing.SystemColors.Control;
            this.personalWebLink.LinkColor = System.Drawing.Color.White;
            this.personalWebLink.Location = new System.Drawing.Point(276, 80);
            this.personalWebLink.Name = "personalWebLink";
            this.personalWebLink.Size = new System.Drawing.Size(74, 13);
            this.personalWebLink.TabIndex = 8;
            this.personalWebLink.TabStop = true;
            this.personalWebLink.Text = "system64.dev";
            this.personalWebLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // versionString
            // 
            this.versionString.AutoSize = true;
            this.versionString.ForeColor = System.Drawing.SystemColors.Control;
            this.versionString.Location = new System.Drawing.Point(339, 3);
            this.versionString.Name = "versionString";
            this.versionString.Size = new System.Drawing.Size(22, 13);
            this.versionString.TabIndex = 9;
            this.versionString.Text = "1.1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(364, 111);
            this.Controls.Add(this.versionString);
            this.Controls.Add(this.personalWebLink);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.novetusLink);
            this.Controls.Add(this.processStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.currentFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Compressor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentFile;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label processStatus;
        private System.Windows.Forms.LinkLabel novetusLink;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.LinkLabel personalWebLink;
        private System.Windows.Forms.Label versionString;
    }
}

