using System;
using System.Data;
using System.Windows.Forms;

namespace AirlineApp.Form
{
    public partial class TicketsForm : System.Windows.Forms.Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ticketsBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ticketsBindingSource.RemoveCurrent();
                ticketsTableAdapter.Update(airlinesDataSet);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ticketsBindingSource.EndEdit();
            ticketsTableAdapter.Update(airlinesDataSet);
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)ticketsDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)ticketsDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airlinesDataSet);
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.airlinesDataSet.Tickets);
        }

        private void TicketsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}