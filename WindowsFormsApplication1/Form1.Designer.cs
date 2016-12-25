namespace WindowsFormsApplication1
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
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonRaise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(13, 36);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(75, 23);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(117, 35);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(75, 23);
            this.buttonTwo.TabIndex = 1;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(13, 13);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(41, 12);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "label1";
            // 
            // buttonRaise
            // 
            this.buttonRaise.Location = new System.Drawing.Point(15, 91);
            this.buttonRaise.Name = "buttonRaise";
            this.buttonRaise.Size = new System.Drawing.Size(75, 23);
            this.buttonRaise.TabIndex = 3;
            this.buttonRaise.Text = "button1";
            this.buttonRaise.UseVisualStyleBackColor = true;
            this.buttonRaise.Click += new System.EventHandler(this.buttonRaise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonRaise);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonRaise;
    }
}

