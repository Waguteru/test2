using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class AuthoForm : Form
    {

        private bool closed = false;

        public AuthoForm()
        {
            InitializeComponent();
        }

        private void register_bt_Click(object sender, EventArgs e)
        {
            string login_user = login_tb.Text;
            string password_users = password_tb.Text;

            if (closed)
            {
                return;
            }
            else if (CheckLogin(login_user, password_users))
            {
                ShowUserForm(login_user);
            }
        }

        string connection = "Server = localhost; port = 5432; DataBase = testappli; User Id = postgres; Password = 123";

        private bool CheckLogin(string login_user, string password_users)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connection))
            {
                string query = $"SELECT COUNT(*) FROM users where login_user = @login_user and password_users = @password_users";
                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("login_user", login_user);
                    command.Parameters.AddWithValue("password_users", password_users);

                    conn.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void ShowUserForm(string login)
        {
            string role = GetRoleUser(login);

            if (role == "Работник")
            {
                WorkersApplication workers = new WorkersApplication();
                this.Hide();
                workers.ShowDialog();
                this.Close();
            }
            else if (role == "Пользователь")
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("такой роли нет", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetRoleUser(string login_user)
        {
            string role = "";
            using (NpgsqlConnection conn = new NpgsqlConnection(connection))
            {
                string query = $"select role_users from users where login_user = @login_user";
                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login_user", login_user);
                    try
                    {
                       conn.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            role = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("не удалось получить роль", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"ошибка при получении роли: {ex.Message}","ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return role;
        }
    }
}
