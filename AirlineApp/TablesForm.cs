using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AirlineApp
{
    public partial class TablesForm : Form
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;
        private SqlDataAdapter _airplanesDataAdapter;
        private DataTable _airplanesDataTable;
        private SqlCommandBuilder _airplanesCommandBuilder;
        private BindingSource _airplanesBindingSource;

        private SqlDataAdapter _crewDataAdapter;
        private DataTable _crewDataTable;
        private SqlCommandBuilder _crewCommandBuilder;
        private BindingSource _crewBindingSource;

        private SqlDataAdapter _crewMemberDataAdapter;
        private DataTable _crewMemberDataTable;
        private SqlCommandBuilder _crewMemberCommandBuilder;
        private BindingSource _crewMemberBindingSource;

        private SqlDataAdapter _flightsDataAdapter;
        private DataTable _flightsDataTable;
        private SqlCommandBuilder _flightsCommandBuilder;
        private BindingSource _flightsBindingSource;

        private SqlDataAdapter _passengersDataAdapter;
        private DataTable _passengersDataTable;
        private SqlCommandBuilder _passengersCommandBuilder;
        private BindingSource _passengersBindingSource;
        
        private SqlDataAdapter _ticketsDataAdapter;
        private DataTable _ticketsDataTable;
        private SqlCommandBuilder _ticketsCommandBuilder;
        private BindingSource _ticketsBindingSource;
        
        public TablesForm()
        {
            InitializeComponent();
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {
            // загружаем таблицу Airplanes
            _airplanesDataAdapter = new SqlDataAdapter("SELECT * FROM Airplanes", _connectionString);
            _airplanesDataTable = new DataTable();
            _airplanesDataAdapter.Fill(_airplanesDataTable);
            _airplanesCommandBuilder = new SqlCommandBuilder(_airplanesDataAdapter);
            _airplanesBindingSource = new BindingSource();
            _airplanesBindingSource.DataSource = _airplanesDataTable;
            airplanesDataGridView.DataSource = _airplanesBindingSource;

            // загружаем таблицу Crew
            _crewDataAdapter = new SqlDataAdapter("SELECT * FROM Crew", _connectionString);
            _crewDataTable = new DataTable();
            _crewDataAdapter.Fill(_crewDataTable);
            _crewCommandBuilder = new SqlCommandBuilder(_crewDataAdapter);
            _crewBindingSource = new BindingSource();
            _crewBindingSource.DataSource = _crewDataTable;
            crewDataGridView.DataSource = _crewBindingSource;

            // загружаем таблицу CrewMember
            _crewMemberDataAdapter = new SqlDataAdapter("SELECT * FROM CrewMember", _connectionString);
            _crewMemberDataTable = new DataTable();
            _crewMemberDataAdapter.Fill(_crewMemberDataTable);
            _crewMemberCommandBuilder = new SqlCommandBuilder(_crewMemberDataAdapter);
            _crewMemberBindingSource = new BindingSource();
            _crewMemberBindingSource.DataSource = _crewMemberDataTable;
            crewMemberDataGridView.DataSource = _crewMemberBindingSource;

            // загружаем таблицу Flights
            _flightsDataAdapter = new SqlDataAdapter("SELECT * FROM Flights", _connectionString);
            _flightsDataTable = new DataTable();
            _flightsDataAdapter.Fill(_flightsDataTable);
            _flightsCommandBuilder = new SqlCommandBuilder(_flightsDataAdapter);
            _flightsBindingSource = new BindingSource();
            _flightsBindingSource.DataSource = _flightsDataTable;
            flightsDataGridView.DataSource = _flightsBindingSource;

            // загружаем таблицу Passengers
            _passengersDataAdapter = new SqlDataAdapter("SELECT * FROM Passengers", _connectionString);
            _passengersDataTable = new DataTable();
            _passengersDataAdapter.Fill(_passengersDataTable);
            _passengersCommandBuilder = new SqlCommandBuilder(_passengersDataAdapter);
            _passengersBindingSource = new BindingSource();
            _passengersBindingSource.DataSource = _passengersDataTable;
            passengersDataGridView.DataSource = _passengersBindingSource;

            // загружаем таблицу Tickets
            _ticketsDataAdapter = new SqlDataAdapter("SELECT * FROM Tickets", _connectionString);
            _ticketsDataTable = new DataTable();
            _ticketsDataAdapter.Fill(_ticketsDataTable);
            _ticketsCommandBuilder = new SqlCommandBuilder(_ticketsDataAdapter);
            _ticketsBindingSource = new BindingSource();
            _ticketsBindingSource.DataSource = _ticketsDataTable;
            ticketsDataGridView.DataSource = _ticketsBindingSource;
        }

        private void airplanesAddButton_Click(object sender, EventArgs e)
        {
            _airplanesBindingSource.AddNew();
        }

        private void crewAddButton_Click(object sender, EventArgs e)
        {
            _crewBindingSource.AddNew();
        }

        private void flightsAddButton_Click(object sender, EventArgs e)
        {
            _flightsBindingSource.AddNew();
        }

        private void passengersAddButton_Click(object sender, EventArgs e)
        {
            _passengersBindingSource.AddNew();
        }

        private void crewMemberAddButton_Click(object sender, EventArgs e)
        {
            _crewMemberBindingSource.AddNew();
        }

        private void ticketsAddButton_Click(object sender, EventArgs e)
        {
            _ticketsBindingSource.AddNew();
        }

        private void airplanesDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _airplanesBindingSource.RemoveCurrent();
                _airplanesDataAdapter.Update(_airplanesDataTable);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void crewDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _crewBindingSource.RemoveCurrent();
                _crewDataAdapter.Update(_crewDataTable);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void flightsDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _flightsBindingSource.RemoveCurrent();
                _flightsDataAdapter.Update(_flightsDataTable);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void passengersDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _passengersBindingSource.RemoveCurrent();
                _passengersDataAdapter.Update(_passengersDataTable);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void crewMemberDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _crewMemberBindingSource.RemoveCurrent();
                _crewMemberDataAdapter.Update(_crewMemberDataTable);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void ticketsDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ticketsBindingSource.RemoveCurrent();
                _ticketsDataAdapter.Update(_ticketsDataTable);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void airplanesCancelButton_Click(object sender, EventArgs e)
        {
            _airplanesBindingSource.CancelEdit();
        }

        private void crewCancelButton_Click(object sender, EventArgs e)
        {
            _crewBindingSource.CancelEdit();
        }

        private void flightsCancelButton_Click(object sender, EventArgs e)
        {
            _flightsBindingSource.CancelEdit();
        }

        private void passengersCancelButton_Click(object sender, EventArgs e)
        {
            _passengersBindingSource.CancelEdit();
        }

        private void crewMemberCancelButton_Click(object sender, EventArgs e)
        {
            _crewMemberBindingSource.CancelEdit();
        }

        private void ticketsCancelButton_Click(object sender, EventArgs e)
        {
            _ticketsBindingSource.CancelEdit();
        }

        private void airplanesSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _airplanesBindingSource.EndEdit();
                _airplanesDataAdapter.Update(_airplanesDataTable);
                MessageBox.Show("Данные сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}");
            }
        }

        private void crewSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _crewBindingSource.EndEdit();
                _crewDataAdapter.Update(_crewDataTable);
                MessageBox.Show("Данные сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}");
            }
        }

        private void flightsSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _flightsBindingSource.EndEdit();
                _flightsDataAdapter.Update(_flightsDataTable);
                MessageBox.Show("Данные сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}");
            }
        }

        private void passengersSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _passengersBindingSource.EndEdit();
                _passengersDataAdapter.Update(_passengersDataTable);
                MessageBox.Show("Данные сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}");
            }
        }

        private void crewMemberSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _crewMemberBindingSource.EndEdit();
                _crewMemberDataAdapter.Update(_crewMemberDataTable);
                MessageBox.Show("Данные сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}");
            }
        }

        private void ticketsSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _ticketsBindingSource.EndEdit();
                _ticketsDataAdapter.Update(_ticketsDataTable);
                MessageBox.Show("Данные сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}");
            }
        }

        private void TablesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
