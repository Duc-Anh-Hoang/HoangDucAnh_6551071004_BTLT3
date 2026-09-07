namespace Bai4
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
            ClickMe = new Button();
            SuspendLayout();
            // 
            // ClickMe
            // 
            ClickMe.Dock = DockStyle.Fill;
            ClickMe.Font = new Font("Segoe UI", 40F);
            ClickMe.ForeColor = Color.Crimson;
            ClickMe.Location = new Point(0, 0);
            ClickMe.Name = "ClickMe";
            ClickMe.Size = new Size(800, 450);
            ClickMe.TabIndex = 0;
            ClickMe.Text = "Click Me";
            ClickMe.UseVisualStyleBackColor = true;
            ClickMe.Click += ClickMe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClickMe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button ClickMe;
    }
}
