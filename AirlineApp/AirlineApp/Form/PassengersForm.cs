using System;
using System.Windows.Forms;

namespace AirlineApp.Form
{
    public partial class PassengersForm : System.Windows.Forms.Form
    {
        public PassengersForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            passengersBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                passengersBindingSource.RemoveCurrent();
                passengersTableAdapter.Update(airlinesDataSet);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            passengersBindingSource.EndEdit();
            passengersTableAdapter.Update(airlinesDataSet);
        }

        private void passengersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passengersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airlinesDataSet);
        }

        private void PassengersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.Passengers". При необходимости она может быть перемещена или удалена.
            this.passengersTableAdapter.Fill(this.airlinesDataSet.Passengers);
        }

        private void PassengersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
