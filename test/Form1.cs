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
    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();

        public Form1()
        {
            InitializeComponent();
        }

        private void addAplli_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            string fio = fio_user.Text;
            string pribor = pribor_repair.Text;
            string problema = problema_cb.Text;
            string status = "в обработке";

            string query = $"insert into application_users (fio_users,pribor,problema,status_appli) values ('{fio}','{pribor}','{problema}','{status}')";

            NpgsqlCommand command = new NpgsqlCommand(query,dataBase.GetConnection());

            command.ExecuteNonQuery();

            MessageBox.Show("заявка отправлена","успех",MessageBoxButtons.OK,MessageBoxIcon.Information);

            FormUsers formUsers = new FormUsers();
            this.Hide();
            formUsers.ShowDialog();
            this.Close();

            dataBase.CloseConnection();
        }
    }
}
