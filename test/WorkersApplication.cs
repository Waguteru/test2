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
    public partial class WorkersApplication : Form
    {
        DataBase dataBase = new DataBase();

        enum RowState
        {
            Deleted,
            New,
            Modifiend,
            ModifiendNew
        }

        int selected;

        public WorkersApplication()
        {
            InitializeComponent();
            
        }


        public void CreateColumns()
        {
            dataGridView1.Columns.Add("id_appli", "номер заявки");
            dataGridView1.Columns.Add("fio_users", "фио заявителя");
            dataGridView1.Columns.Add("pribor", "Прибор");
            dataGridView1.Columns.Add("problema", "Проблема");
            dataGridView1.Columns.Add("status_appli", "Статус заявки");
            dataGridView1.Columns.Add("IsNew",String.Empty);
            dataGridView1.Columns["IsNew"].Visible = false;
        }

        public void ReadSingleRows(DataGridView gridView,IDataRecord record)
        {
            gridView.Rows.Add(record.GetInt64(0),record.GetString(1),record.GetString(2),record.GetString(3),record.GetString(4),RowState.Modifiend);
        }

        public void RefreshData(DataGridView gridView)
        {
            gridView.Rows.Clear();

            dataBase.OpenConnection();

            string query = "select * from application_users";

            NpgsqlCommand command = new NpgsqlCommand(query,dataBase.GetConnection());

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(gridView,reader);
            }
            reader.Close();

            dataBase.CloseConnection();
        }

        private void WorkersApplication_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshData(dataGridView1);
        }

        private void updateApplication_bt_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            string id = id_tb.Text;
            string status = status_cb.Text;

            string query = $"update application_users set status_appli = '{status}' where id_appli = " + id;

            NpgsqlCommand command = new NpgsqlCommand(query,dataBase.GetConnection());

            command.ExecuteNonQuery();

            dataBase.CloseConnection();

            RefreshData(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;

            if(selected >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selected];
                id_tb.Text = row.Cells[0].Value.ToString();
                status_cb.Text = row.Cells[4].Value.ToString();
                fio_tb.Text = row.Cells[1].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            string id = id_tb.Text;

            string query = $"DELETE FROM application_users WHERE id_appli = " + id;

            NpgsqlCommand command = new NpgsqlCommand( query,dataBase.GetConnection());

            command.ExecuteNonQuery();

            dataBase.CloseConnection();

            RefreshData(dataGridView1);
        }
    }
}
