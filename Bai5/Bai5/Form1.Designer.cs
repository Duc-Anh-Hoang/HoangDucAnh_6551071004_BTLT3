namespace Bai5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtNhapTen = new TextBox();
            label1 = new Label();
            radColor = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            chkBold = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            btnThoat = new Button();
            lblLapTrinh = new Label();
            radColor.SuspendLayout();
            chkBold.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(126, 15);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(644, 31);
            txtNhapTen.TabIndex = 2;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(35, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 2;
            label1.Text = "Nhập tên";
            // 
            // radColor
            // 
            radColor.BackColor = SystemColors.ActiveCaption;
            radColor.Controls.Add(radioButton4);
            radColor.Controls.Add(radioButton3);
            radColor.Controls.Add(radioButton2);
            radColor.Controls.Add(radioButton1);
            radColor.Location = new Point(35, 85);
            radColor.Name = "radColor";
            radColor.Size = new Size(165, 199);
            radColor.TabIndex = 4;
            radColor.TabStop = false;
            radColor.Text = "Color";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(13, 135);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(77, 29);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Black";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.Blue;
            radioButton3.Location = new Point(12, 100);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(70, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Blue";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.Green;
            radioButton2.Location = new Point(13, 66);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Green";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.ForeColor = Color.Red;
            radioButton1.Location = new Point(13, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Red";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.BackColor = Color.FromArgb(255, 192, 128);
            chkBold.Controls.Add(checkBox3);
            chkBold.Controls.Add(checkBox2);
            chkBold.Controls.Add(checkBox1);
            chkBold.Location = new Point(254, 85);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(184, 199);
            chkBold.TabIndex = 5;
            chkBold.TabStop = false;
            chkBold.Text = "Font";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            checkBox3.ForeColor = Color.Blue;
            checkBox3.Location = new Point(10, 105);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(119, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Gạch chân";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            checkBox2.ForeColor = Color.Blue;
            checkBox2.Location = new Point(10, 70);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(150, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Nghiêng Italic";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox1.ForeColor = Color.Blue;
            checkBox1.Location = new Point(10, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Đậm Bold";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(35, 315);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 6;
            label2.Text = "Lập trình bởi: ";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(402, 302);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 56);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.ForeColor = Color.Red;
            lblLapTrinh.Location = new Point(162, 315);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(221, 38);
            lblLapTrinh.TabIndex = 9;
            lblLapTrinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLapTrinh);
            Controls.Add(btnThoat);
            Controls.Add(label2);
            Controls.Add(chkBold);
            Controls.Add(radColor);
            Controls.Add(label1);
            Controls.Add(txtNhapTen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            radColor.ResumeLayout(false);
            radColor.PerformLayout();
            chkBold.ResumeLayout(false);
            chkBold.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtNhapTen;
        private Label label1;
        private GroupBox radColor;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox chkBold;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label2;
        private TextBox textBox1;
        private Button btnThoat;
        private Label lblLapTrinh;
    }
}
