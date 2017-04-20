namespace DownLoadFileTool
{
    partial class ShowFiles
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.SourceFilePath = new System.Windows.Forms.TabPage();
            this.TargetFilePath = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txbForT = new System.Windows.Forms.TextBox();
            this.btnShowFileT = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.TargetFilePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.SourceFilePath);
            this.tabControl.Controls.Add(this.TargetFilePath);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(22, 42);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(300, 300);
            this.tabControl.TabIndex = 0;
            // 
            // SourceFilePath
            // 
            this.SourceFilePath.Location = new System.Drawing.Point(4, 22);
            this.SourceFilePath.Name = "SourceFilePath";
            this.SourceFilePath.Padding = new System.Windows.Forms.Padding(3);
            this.SourceFilePath.Size = new System.Drawing.Size(259, 274);
            this.SourceFilePath.TabIndex = 0;
            this.SourceFilePath.Text = "SourceFilePath";
            this.SourceFilePath.UseVisualStyleBackColor = true;
            this.SourceFilePath.Click += new System.EventHandler(this.SourceFilePath_Click);
            // 
            // TargetFilePath
            // 
            this.TargetFilePath.AutoScroll = true;
            this.TargetFilePath.Controls.Add(this.btnShowFileT);
            this.TargetFilePath.Controls.Add(this.txbForT);
            this.TargetFilePath.Location = new System.Drawing.Point(4, 22);
            this.TargetFilePath.Name = "TargetFilePath";
            this.TargetFilePath.Padding = new System.Windows.Forms.Padding(3);
            this.TargetFilePath.Size = new System.Drawing.Size(292, 274);
            this.TargetFilePath.TabIndex = 1;
            this.TargetFilePath.Text = "TargetFilePath";
            this.TargetFilePath.UseVisualStyleBackColor = true;
            this.TargetFilePath.Click += new System.EventHandler(this.TargetFilePath_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(259, 74);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txbForT
            // 
            this.txbForT.Location = new System.Drawing.Point(6, 6);
            this.txbForT.Multiline = true;
            this.txbForT.Name = "txbForT";
            this.txbForT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbForT.Size = new System.Drawing.Size(196, 262);
            this.txbForT.TabIndex = 1;
            this.txbForT.WordWrap = false;
            // 
            // btnShowFileT
            // 
            this.btnShowFileT.Location = new System.Drawing.Point(209, 38);
            this.btnShowFileT.Name = "btnShowFileT";
            this.btnShowFileT.Size = new System.Drawing.Size(75, 23);
            this.btnShowFileT.TabIndex = 2;
            this.btnShowFileT.Text = "Show Files";
            this.btnShowFileT.UseVisualStyleBackColor = true;
            this.btnShowFileT.Click += new System.EventHandler(this.btnShowFileT_Click);
            // 
            // ShowFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 387);
            this.Controls.Add(this.tabControl);
            this.Name = "ShowFiles";
            this.Text = "ShowFiles";
            this.tabControl.ResumeLayout(false);
            this.TargetFilePath.ResumeLayout(false);
            this.TargetFilePath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage SourceFilePath;
        private System.Windows.Forms.TabPage TargetFilePath;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txbForT;
        private System.Windows.Forms.Button btnShowFileT;
    }
}