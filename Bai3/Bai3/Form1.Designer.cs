namespace Bai3
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
            lblHoTen = new Label();
            label1 = new Label();
            label2 = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.MenuHighlight;
            lblHoTen.Location = new Point(-3, -2);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(805, 99);
            lblHoTen.TabIndex = 0;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 169);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 1;
            label1.Text = "Họ lót";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 229);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(169, 169);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(574, 31);
            txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.RosyBrown;
            txtTen.Location = new Point(169, 223);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(574, 31);
            txtTen.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(93, 273);
            button1.Name = "button1";
            button1.Size = new Size(128, 68);
            button1.TabIndex = 5;
            button1.Text = "Họ lót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(304, 273);
            button2.Name = "button2";
            button2.Size = new Size(140, 73);
            button2.TabIndex = 6;
            button2.Text = "Tên";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(516, 278);
            button3.Name = "button3";
            button3.Size = new Size(142, 68);
            button3.TabIndex = 7;
            button3.Text = "Họ và Tên";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(304, 377);
            button4.Name = "button4";
            button4.Size = new Size(140, 61);
            button4.TabIndex = 8;
            button4.Text = "Thoát chương trình";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label label1;
        private Label label2;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
