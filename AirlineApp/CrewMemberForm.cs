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

namespace AirlineApp
{
    public partial class CrewMemberForm : Form
    {
        public CrewMemberForm()
        {
            InitializeComponent();
        }

        private void crewMemberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crewMemberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airlinesDataSet);
        }

        private void CrewMemberForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.CrewMember". При необходимости она может быть перемещена или удалена.
            this.crewMemberTableAdapter.Fill(this.airlinesDataSet.CrewMember);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            crewMemberBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crewMemberBindingSource.RemoveCurrent();
                crewMemberTableAdapter.Update(airlinesDataSet);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            crewMemberBindingSource.EndEdit();
            crewMemberTableAdapter.Update(airlinesDataSet);
        }

        private void CrewMemberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)crewMemberDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)crewMemberDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
        }
    }
}
