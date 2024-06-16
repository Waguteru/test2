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
    public partial class RegisterFrom : Form
    {

        DataBase dataBase = new DataBase();

        public RegisterFrom()
        {
            InitializeComponent();
        }

        private void register_bt_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            string login = login_tb.Text;
            string password =password_tb.Text;
            string role = "Пользователь";

            string query = $"insert into users (login_user,password_users,role_users) values ('{login}','{password}','{role}')";

            NpgsqlCommand command = new NpgsqlCommand(query,dataBase.GetConnection());

            command.ExecuteNonQuery();

            MessageBox.Show("Регистрация прошла успешно","успех",MessageBoxButtons.OK,MessageBoxIcon.Information);

            AuthoForm authoForm = new AuthoForm();
            this.Hide();
            authoForm.ShowDialog();
            this.Close();

            dataBase.CloseConnection();
        }
    }
}
