using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace SandboxWindowsFormApp
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                MessageBox.Show("OK");
            }
        }
    }
}
