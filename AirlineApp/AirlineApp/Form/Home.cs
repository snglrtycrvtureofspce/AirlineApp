﻿using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AirlineApp.Control;
using AirlineApp.Control.ElControls;

namespace AirlineApp.Form
{
    public partial class Home : System.Windows.Forms.Form
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;

        public Home()
        {
            InitializeComponent();
            _obj = this;
            this.ActiveControl = logo;
        }

        static Home _obj;
        public static Home Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Home();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return InfoPanel; }
            set { InfoPanel = value; }
        }

        public Guna.UI.WinForms.GunaPanel pnlAdmin
        {
            get { return AdminPanel; }
            set { AdminPanel = value; }
        }

        public Guna.UI.WinForms.GunaLabel PnlLableUser
        {
            get { return UserName; }
            set { UserName = value; }
        }
        public Guna.UI.WinForms.GunaPanel pnlBasket
        {
            get { return gunaPanel1; }
            set { gunaPanel1 = value; }
        }

        Point lastPoint;
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = logo;
            lastPoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        //-------------------------------- Admin
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            AdminControl adminControl1 = new AdminControl();
            InfoPanel.Controls.Add(adminControl1);
            adminControl1.Dock = DockStyle.Fill;
            adminControl1.BringToFront();

            PrintListUserAdmin(adminControl1);
            PrintListProductAdmin(adminControl1);
            PrintStatisticAdmin(adminControl1);
        }

        private void PrintStatisticAdmin(AdminControl adminControl1)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tickets", connection);
            connection.Open();
            adminControl1.CountTickets.Text = "0" + cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Tickets", connection);
            connection.Open();
            adminControl1.CountBuyTickets.Text = "0" + cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd = new SqlCommand("SELECT COUNT(*) FROM People", connection);
            connection.Open();
            adminControl1.CountUsers.Text = "0" + cmd.ExecuteScalar().ToString();
            connection.Close();
        }

        private void PrintListProductAdmin(AdminControl adminControl1)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Tickets]", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            adminControl1.flowLayoutPanel1.Controls.Clear();

            while (reader.Read())
            {
                ElProductList Item = new ElProductList();
                Item.gunaLabel1.Text = reader[5].ToString();
                Item.gunaLabel2.Text = reader[3].ToString();
                Item.gunaLabel3.Text = reader[4].ToString();
                Item.gunaLabel4.Text += reader[0].ToString();
                adminControl1.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        private void PrintListUserAdmin(AdminControl adminControl1)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [People]", connection);

            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Tickets", connection);
            var temp = cmd2.ExecuteScalar().ToString();

            SqlDataReader reader = cmd.ExecuteReader();
            adminControl1.flowLayoutPanel3.Controls.Clear();
            while (reader.Read())
            {
                ElUserList Item = new ElUserList();
                Item.gunaLabel1.Text += reader[3].ToString();
                Item.gunaLabel3.Text += reader[4].ToString();
                Item.gunaLabel4.Text += reader[1].ToString();
                Item.gunaLabel2.Text += temp.ToString();
                adminControl1.flowLayoutPanel3.Controls.Add(Item);
            }

            reader.Close();
            connection.Close();
        }

        //--------------------------------- Заказы
        private void btnOrder_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            OrderControl orderControl = new OrderControl();
            InfoPanel.Controls.Add(orderControl);
            orderControl.Dock = DockStyle.Fill;
            orderControl.BringToFront();
            PrintOrder(orderControl);
        }

        private void PrintOrder(OrderControl orderControl)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Tickets]", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Random random = new Random();

            orderControl.flowLayoutPanel1.Controls.Clear();
            while (reader.Read())
            {
                ElOrderList Item = new ElOrderList();
                Item.gunaLabel1.Text = reader[5].ToString();
                Item.gunaLabel2.Text = reader[4].ToString();
                Item.gunaLabel4.Text += random.Next(1, 1500).ToString();
                Item.Size = new Size(709, 36);

                orderControl.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        //-------------------------------- Билеты
        private void PrintTickets(ProductControl productControl)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ElProduct Item = new ElProduct();

                Item.SeatType.Text = reader[5].ToString();

                productControl.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        private void flightsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightsForm flightsForm = new FlightsForm();
            flightsForm.Show();
        }

        private void crewButton_Click(object sender, EventArgs e) // форма экипажа
        {
            this.Hide();
            CrewForm crewForm = new CrewForm();
            crewForm.Show();
        }

        private void ticketsButton_Click(object sender, EventArgs e) // форма билетов
        {
            this.Hide();
            TicketsForm ticketsForm = new TicketsForm();
            ticketsForm.Show();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }

        private void referenceButton_Click(object sender, EventArgs e) // справка
        {
            Process.Start(Directory.GetCurrentDirectory() + @"\reference.chm");
        }

        private void airplanesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AirplanesForm airplanesForm = new AirplanesForm();
            airplanesForm.Show();
        }

        private void crewMemberButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrewMemberForm crewMemberForm = new CrewMemberForm();
            crewMemberForm.Show();
        }

        private void passengersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassengersForm passengersForm = new PassengersForm();
            passengersForm.Show();
        }

        private void sellTicketsButton_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            ProductControl productControl = new ProductControl();
            InfoPanel.Controls.Add(productControl);
            productControl.Dock = DockStyle.Fill;
            productControl.BringToFront();

            PrintTickets(productControl);
        }

        //------------------------------------------ Корзина
        private void btnBasket_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            BasketControl basketControl = new BasketControl();
            InfoPanel.Controls.Add(basketControl);
            basketControl.Dock = DockStyle.Fill;
            basketControl.BringToFront();

            PrintBasket(basketControl);
            CountBasket(basketControl);
        }

        private void CountBasket(BasketControl basketControl)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM basket", connection);
            connection.Open();
            basketControl.gunaLabel5.Text = "Итого: " + cmd.ExecuteScalar().ToString() + " билетов";
            connection.Close();
        }

        private void PrintBasket(BasketControl basketControl)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM basket", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ElBasketList Item = new ElBasketList();

                Item.gunaLabel1.Text = reader[0].ToString();
                Item.gunaLabel2.Text = reader[1].ToString();
                basketControl.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        private void UserPicture_Click(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();
            InfoPanel.Controls.Add(userControl1);

            if (UserName.Text != "Имя")
            {
                userControl1.PanelLogReg.Visible = false;
                userControl1.Size = new Size(134, 45);
            }

            userControl1.Location = new Point(626, 0);
            userControl1.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [basket]", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void crewAdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            crewAdminForm crewAdminForm = new crewAdminForm();
            crewAdminForm.Show();
        }

        private void ticketsAdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ticketsAdminForm ticketsAdminForm = new ticketsAdminForm();
            ticketsAdminForm.Show();
        }

        private void flightsAdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            flightsAdminForm flightsAdminForm = new flightsAdminForm();
            flightsAdminForm.Show();
        }
    }
}