namespace Picture
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
            this.btFile = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(218, 324);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(132, 37);
            this.btFile.TabIndex = 6;
            this.btFile.Text = "File...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(57, 320);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(52, 44);
            this.btLeft.TabIndex = 4;
            this.btLeft.Text = "<-";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(115, 320);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(52, 44);
            this.btRight.TabIndex = 5;
            this.btRight.Text = "->";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.btRight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
    }
}

