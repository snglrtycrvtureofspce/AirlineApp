using AirlineApp.airlinesDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineApp
{
    public partial class FlightsForm : Form
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;
        public FlightsForm()
        {
            InitializeComponent();
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.V1". При необходимости она может быть перемещена или удалена.
            this.v1TableAdapter.Fill(this.airlinesDataSet.V1);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            v1BindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    string query = "DELETE FROM v1 WHERE AirplaneID = @AirplaneID";

            //    using (SqlConnection connection = new SqlConnection(_connectionString))
            //    {
            //        SqlCommand command = new SqlCommand(query, connection);
            //        command.Parameters.AddWithValue("@AirplaneID", airplaneID);

            //        connection.Open();
            //        command.ExecuteNonQuery();
            //        connection.Close();
            //    }
            //}
            v1BindingSource.RemoveCurrent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //v1BindingSource.EndEdit();
            //v1TableAdapter.Update(airlinesDataSet);
        }
        private void AirplanesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
