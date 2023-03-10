﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AirlineApp
{
    public partial class QueryForm : Form
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;

        public QueryForm()
        {
            InitializeComponent();
        }

        private void query1Button_Click(object sender, EventArgs e)
            // Определить расчётное время полета по всем маршрутам
        {
            string query = "SELECT FlightID, Distance, Speed " +
                           "FROM Flights " +
                           "INNER JOIN Airplanes " +
                           "ON Flights.AirplaneID = Airplanes.AirplaneID";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            DataTable result = new DataTable();
            result.Columns.Add("FlightID", typeof(int));
            result.Columns.Add("FlightTime", typeof(double));

            foreach (DataRow row in dt.Rows)
            {
                var flightTime2 = Convert.ToDouble(row["Distance"]) / Convert.ToDouble(row["Speed"]);
                result.Rows.Add(row["FlightID"], flightTime2);
            }

            dataGridView1.DataSource = result;
        }

        private void query2Button_Click(object sender, EventArgs e)
            // Определить расход топлива по всем маршрутам
        {
            string query = "SELECT FlightID, Distance, Airplanes.FuelConsumption " +
                           "FROM Flights " +
                           "INNER JOIN Airplanes " +
                           "ON Flights.AirplaneID = Airplanes.AirplaneID";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            DataTable result = new DataTable();
            result.Columns.Add("FlightID", typeof(int));
            result.Columns.Add("FuelConsumption", typeof(double));

            foreach (DataRow row in dt.Rows)
            {
                var fuelConsumption = Convert.ToDouble(row["Distance"]) * Convert.ToDouble(row["FuelConsumption"]);
                result.Rows.Add(row["FlightID"], fuelConsumption);
            }

            dataGridView1.DataSource = result;
        }

        private void query3Button_Click(object sender, EventArgs e)
            // Вывести экипаж, совершивший максимальное количество полетов
            // за прошедшую неделю
        {
            string query = @"
                            SELECT c.CrewID, c.CrewCode, cm.FullName, COUNT(*) AS FlightsCount
                            FROM Crew c
                            INNER JOIN Flights f ON c.FlightsID = f.FlightID
                            INNER JOIN CrewMember cm ON c.CrewMemberID = cm.CrewMemberID
                            WHERE f.DepartureDate BETWEEN DATEADD(WEEK, -1, GETDATE()) AND GETDATE()
                            GROUP BY c.CrewID, c.CrewCode, cm.FullName
                            ORDER BY FlightsCount DESC
                            ";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            if (dt.Rows.Count > 0)
            {
                DataRow firstRow = dt.Rows[0];
                int crewMemberID = (int)firstRow["CrewMemberID"];
                string fullName = (string)firstRow["FullName"];
                int flightCount = (int)firstRow["FlightCount"];

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("За последнюю неделю рейсов не было.");
            }
        }

        private void query4Button_Click(object sender, EventArgs e)
            // Вывести данные о том, сколько свободных мест оставалось в
            // самолетах, совершавших полет по одному из рейсов за вчерашний день
        {
            string connectionString = _connectionString;
            string query = "SELECT A.RegistrationNumber, A.NumberOfSeats - COUNT(T.SeatNumber) AS FreeSeats " +
                           "FROM Airplanes AS A " +
                           "INNER JOIN Flights AS F " +
                           "ON A.AirplaneID = F.AirplaneID " +
                           "LEFT JOIN Tickets AS T ON F.FlightID = T.FlightID " +
                           "WHERE F.DepartureDate = DATEADD(day, -1, GETDATE()) " +
                           "GROUP BY A.RegistrationNumber, A.NumberOfSeats";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void query5Button_Click(object sender, EventArgs e)
            // Рассчитать убытки компании за счет непроданных билетов за вчерашний день
        {
            string query = "SELECT SUM(TicketPrice) AS Losses FROM Tickets " +
                           "WHERE FlightID IN (SELECT FlightID FROM Flights " +
                           "WHERE DepartureDate = DATEADD(day, -1, GETDATE())) " +
                           "AND PassengerID IS NULL";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            dataGridView1.DataSource = dt;
        }

        private void query6Button_Click(object sender, EventArgs e)
            // Вывести список самолетов, которые не ремонтировались в течение более чем 3 лет
        {
            string query = "SELECT RegistrationNumber, ManufactureDate, LastRepairDate " +
                           "FROM Airplanes " +
                           "WHERE DATEDIFF(YEAR, LastRepairDate, GETDATE()) > 3";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            dataGridView1.DataSource = dt;
        }

        private void query7Button_Click(object sender, EventArgs e)
            // Определить каким количеством самолетов каждого типа владеет компания
        {
            string query = "SELECT Type, COUNT(*) AS NumberOfAirplanes FROM Airplanes GROUP BY Type";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            dataGridView1.DataSource = dt;
        }

        private void query8Button_Click(object sender, EventArgs e)
            // Определить средний “возраст” самолетов компании
        {
            string query = "SELECT AVG(DATEDIFF(YEAR, ManufactureDate, GETDATE())) AS AverageAge FROM Airplanes";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            dataGridView1.DataSource = dt;
        }

        private void QueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}