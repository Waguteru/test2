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
    public partial class FormUsers : Form
    {

        DataBase dataBase = new DataBase();

        public FormUsers()
        {
            InitializeComponent();
        }

        public void CreateColumns()
        {
            dataGridView1.Columns.Add("fio_users", "фио");
            dataGridView1.Columns.Add("pribor", "прибор");
            dataGridView1.Columns.Add("problema", "проблема");
            dataGridView1.Columns.Add("status_appli", "статус");
        }

        public void ReadSingleRows(DataGridView gridView,IDataRecord record)
        {
            gridView.Rows.Add(record.GetString(0),record.GetString(1),record.GetString(2),record.GetString(3));
        }

        public void RefreshData(DataGridView gridView)
        {
            gridView.Rows.Clear();

            dataBase.OpenConnection();

            string queru = "select fio_users,pribor,problema,status_appli from application_users";

            NpgsqlCommand command = new NpgsqlCommand(queru,dataBase.GetConnection());

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(gridView,reader);
            }
            reader.Close();
            dataBase.CloseConnection();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshData(dataGridView1);
        }

        private void exit_prog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
