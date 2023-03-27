using AirlineApp.airlinesDataSetTableAdapters;
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
    public partial class CrewForm : System.Windows.Forms.Form
    {
        public CrewForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            crewBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crewBindingSource.RemoveCurrent();
                crewTableAdapter.Update(airlinesDataSet);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            crewBindingSource.EndEdit();
            crewTableAdapter.Update(airlinesDataSet);
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)crewDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)crewDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
        }

        private void crewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crewBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airlinesDataSet);
        }

        private void CrewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.Crew". При необходимости она может быть перемещена или удалена.
            this.crewTableAdapter.Fill(this.airlinesDataSet.Crew);
        }

        private void CrewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
