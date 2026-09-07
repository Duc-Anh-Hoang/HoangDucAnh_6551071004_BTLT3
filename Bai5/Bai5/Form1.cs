namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhapTen.Focus();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Red;
            txtNhapTen.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Green;
            txtNhapTen.ForeColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Blue;
            txtNhapTen.ForeColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Black;
            txtNhapTen.ForeColor = Color.Black;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style | FontStyle.Bold);
            else
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style & ~FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style | FontStyle.Italic);
            else
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style & ~FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style | FontStyle.Underline);
            else
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style & ~FontStyle.Underline);
        }
    }
}
