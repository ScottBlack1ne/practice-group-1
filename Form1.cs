namespace practice_group
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string nameUser = txtName.Text;
            MessageBox.Show($"Hello {nameUser}");
        }
    }
}
