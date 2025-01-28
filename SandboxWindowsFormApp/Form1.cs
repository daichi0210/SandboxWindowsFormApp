namespace SandboxWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDatabase_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.Show();
            this.Hide();
        }
    }
}
