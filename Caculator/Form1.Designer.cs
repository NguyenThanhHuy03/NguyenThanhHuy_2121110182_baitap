namespace Caculator
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
            this.tbCong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.tbNhan = new System.Windows.Forms.Button();
            this.tbThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCong
            // 
            this.tbCong.Location = new System.Drawing.Point(27, 181);
            this.tbCong.Name = "tbCong";
            this.tbCong.Size = new System.Drawing.Size(84, 35);
            this.tbCong.TabIndex = 0;
            this.tbCong.Text = "Cộng";
            this.tbCong.UseVisualStyleBackColor = true;
            this.tbCong.Click += new System.EventHandler(this.tbCong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số x";
            // 
            // tbSoX
            // 
            this.tbSoX.Location = new System.Drawing.Point(111, 24);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(261, 22);
            this.tbSoX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kết quả";
            // 
            // tbSoY
            // 
            this.tbSoY.Location = new System.Drawing.Point(111, 67);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(261, 22);
            this.tbSoY.TabIndex = 2;
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(111, 110);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(261, 22);
            this.tbKetQua.TabIndex = 2;
            // 
            // tbNhan
            // 
            this.tbNhan.Location = new System.Drawing.Point(128, 181);
            this.tbNhan.Name = "tbNhan";
            this.tbNhan.Size = new System.Drawing.Size(84, 35);
            this.tbNhan.TabIndex = 0;
            this.tbNhan.Text = "Nhân";
            this.tbNhan.UseVisualStyleBackColor = true;
            this.tbNhan.Click += new System.EventHandler(this.tbNhan_Click);
            // 
            // tbThoat
            // 
            this.tbThoat.Location = new System.Drawing.Point(288, 181);
            this.tbThoat.Name = "tbThoat";
            this.tbThoat.Size = new System.Drawing.Size(84, 35);
            this.tbThoat.TabIndex = 0;
            this.tbThoat.Text = "Thoát";
            this.tbThoat.UseVisualStyleBackColor = true;
            this.tbThoat.Click += new System.EventHandler(this.tbThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 247);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.tbSoX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbThoat);
            this.Controls.Add(this.tbNhan);
            this.Controls.Add(this.tbCong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Button tbNhan;
        private System.Windows.Forms.Button tbThoat;
    }
}

