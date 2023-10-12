namespace Picturebox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRight = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(97, 298);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(52, 44);
            this.btRight.TabIndex = 1;
            this.btRight.Text = "->";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(39, 298);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(52, 44);
            this.btLeft.TabIndex = 1;
            this.btLeft.Text = "<-";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(200, 302);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(132, 37);
            this.btFile.TabIndex = 2;
            this.btFile.Text = "File...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Simple Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btFile;
    }
}

