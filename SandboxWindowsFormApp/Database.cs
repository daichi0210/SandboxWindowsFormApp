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
        // データベースファイルへの接続文字列
        string connectionString = "Data Source=sample.db;Version=3;";

        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            // SQLiteの接続を開く
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open(); // データベース接続を開く

                // テーブルがなければ作成するSQL
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY, Name TEXT)";
                using (var cmd = new SQLiteCommand(createTableQuery, connection))
                {
                    cmd.ExecuteNonQuery(); // SQL文を実行してテーブルを作成
                }

                //// データを挿入するSQL
                //string insertQuery = "INSERT INTO Users (Name) VALUES (@name)";
                //using (var cmd = new SQLiteCommand(insertQuery, connection))
                //{
                //    cmd.Parameters.AddWithValue("@name", "Taro"); // データを挿入
                //    cmd.ExecuteNonQuery(); // SQL実行
                //}

                // データを取得するSQL
                string selectQuery = "SELECT * FROM Users";

                // データをDataTableに読み込む
                using (var cmd = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);  // データをDataTableに埋め込む

                        // DataGridViewにデータをバインドする
                        dataGridView1.DataSource = dataTable;
                    }
                }

                // 接続を閉じる
                connection.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // SQLiteの接続を開く
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open(); // データベース接続を開く

                // データを挿入するSQL
                string insertQuery = "INSERT INTO Users (Name) VALUES (@name)";
                using (var cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text); // データを挿入
                    cmd.ExecuteNonQuery(); // SQL実行
                }

                // データを取得するSQL
                string selectQuery = "SELECT * FROM Users";

                // データをDataTableに読み込む
                using (var cmd = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);  // データをDataTableに埋め込む

                        // DataGridViewにデータをバインドする
                        dataGridView1.DataSource = dataTable;
                    }
                }

                // 値を消去
                textBoxName.Text = "";

                // 接続を閉じる
                connection.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // SQLiteの接続を開く
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open(); // データベース接続を開く

                // データを削除するSQL
                string deleteQuery = "DELETE FROM Users WHERE (Id) = (@id)";
                using (var cmd = new SQLiteCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@id", Int32.Parse(textBoxId.Text)); // データを挿入
                    cmd.ExecuteNonQuery(); // SQL実行
                }

                // データを取得するSQL
                string selectQuery = "SELECT * FROM Users";

                // データをDataTableに読み込む
                using (var cmd = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);  // データをDataTableに埋め込む

                        // DataGridViewにデータをバインドする
                        dataGridView1.DataSource = dataTable;
                    }
                }

                // 値を消去
                textBoxId.Text = "";

                // 接続を閉じる
                connection.Close();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // SQLiteの接続を開く
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open(); // データベース接続を開く

                // データを編集するSQL
                string editQuery = "UPDATE Users SET Name = (@name) WHERE (Id) = (@id)";
                using (var cmd = new SQLiteCommand(editQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", textBoxEditName.Text); // データを挿入
                    cmd.Parameters.AddWithValue("@id", Int32.Parse(textBoxEditId.Text)); // データを挿入
                    cmd.ExecuteNonQuery(); // SQL実行
                }

                // データを取得するSQL
                string selectQuery = "SELECT * FROM Users";

                // データをDataTableに読み込む
                using (var cmd = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);  // データをDataTableに埋め込む

                        // DataGridViewにデータをバインドする
                        dataGridView1.DataSource = dataTable;
                    }
                }

                // 値を消去
                textBoxId.Text = "";

                // 接続を閉じる
                connection.Close();
            }
        }
    }
}
