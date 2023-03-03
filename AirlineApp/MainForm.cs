using System;
using System.Windows.Forms;

namespace AirlineApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void changeDBButton_Click(object sender, EventArgs e)
        {
            TablesForm tablesForm = new TablesForm();
            tablesForm.Show();
            this.Hide();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
