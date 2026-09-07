namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textHienThi.Text = textPass.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textPass.Clear();
            textHienThi.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }
    }
}
