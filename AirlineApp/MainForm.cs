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

        private void airplanesButton_Click(object sender, EventArgs e)
        {
            AirplanesForm airplanesForm = new AirplanesForm();
            airplanesForm.Show();
            this.Hide();
        }

        private void passengersButton_Click(object sender, EventArgs e)
        {
            PassengersForm passengersForm = new PassengersForm();
            passengersForm.Show();
            this.Hide();
        }

        private void flightsButton_Click(object sender, EventArgs e)
        {
            FlightsForm flightsForm = new FlightsForm();
            flightsForm.Show();
            this.Hide();
        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {
            TicketsForm ticketsForm = new TicketsForm();
            ticketsForm.Show();
            this.Hide();
        }

        private void crewMemberButton_Click(object sender, EventArgs e)
        {
            CrewMemberForm crewMemberForm = new CrewMemberForm();
            crewMemberForm.Show();
            this.Hide();
        }
    }
}
