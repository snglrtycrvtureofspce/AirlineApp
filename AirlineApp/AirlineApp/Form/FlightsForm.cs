using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineApp.Form
{
    public partial class FlightsForm : System.Windows.Forms.Form
    {
        public FlightsForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            flightsBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flightsBindingSource.RemoveCurrent();
                flightsTableAdapter.Update(airlinesDataSet);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            flightsBindingSource.EndEdit();
            flightsTableAdapter.Update(airlinesDataSet);
        }

        private void flightsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flightsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airlinesDataSet);
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.Flights". При необходимости она может быть перемещена или удалена.
            this.flightsTableAdapter.Fill(this.airlinesDataSet.Flights);
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)flightsDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)flightsDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
        }

        private void FlightsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}