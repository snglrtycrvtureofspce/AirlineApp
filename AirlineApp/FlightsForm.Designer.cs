namespace AirlineApp
{
    partial class FlightsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label departureDateLabel;
            System.Windows.Forms.Label departureTimeLabel;
            System.Windows.Forms.Label departureAirportLabel;
            System.Windows.Forms.Label arrivalAirportLabel;
            System.Windows.Forms.Label distanceLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightsForm));
            System.Windows.Forms.Label label2;
            this.airlinesDataSet = new AirlineApp.airlinesDataSet();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightsTableAdapter = new AirlineApp.airlinesDataSetTableAdapters.FlightsTableAdapter();
            this.tableAdapterManager = new AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager();
            this.flightsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.flightsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.flightsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.departureDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departureAirportTextBox = new System.Windows.Forms.TextBox();
            this.arrivalAirportTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.departureTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            departureDateLabel = new System.Windows.Forms.Label();
            departureTimeLabel = new System.Windows.Forms.Label();
            departureAirportLabel = new System.Windows.Forms.Label();
            arrivalAirportLabel = new System.Windows.Forms.Label();
            distanceLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingNavigator)).BeginInit();
            this.flightsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // departureDateLabel
            // 
            departureDateLabel.AutoSize = true;
            departureDateLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            departureDateLabel.Location = new System.Drawing.Point(12, 325);
            departureDateLabel.Name = "departureDateLabel";
            departureDateLabel.Size = new System.Drawing.Size(103, 16);
            departureDateLabel.TabIndex = 33;
            departureDateLabel.Text = "Дата вылета:";
            // 
            // departureTimeLabel
            // 
            departureTimeLabel.AutoSize = true;
            departureTimeLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            departureTimeLabel.Location = new System.Drawing.Point(12, 350);
            departureTimeLabel.Name = "departureTimeLabel";
            departureTimeLabel.Size = new System.Drawing.Size(111, 16);
            departureTimeLabel.TabIndex = 35;
            departureTimeLabel.Text = "Время вылета:";
            // 
            // departureAirportLabel
            // 
            departureAirportLabel.AutoSize = true;
            departureAirportLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            departureAirportLabel.Location = new System.Drawing.Point(12, 376);
            departureAirportLabel.Name = "departureAirportLabel";
            departureAirportLabel.Size = new System.Drawing.Size(135, 16);
            departureAirportLabel.TabIndex = 37;
            departureAirportLabel.Text = "Аэропорт вылета:";
            // 
            // arrivalAirportLabel
            // 
            arrivalAirportLabel.AutoSize = true;
            arrivalAirportLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            arrivalAirportLabel.Location = new System.Drawing.Point(12, 402);
            arrivalAirportLabel.Name = "arrivalAirportLabel";
            arrivalAirportLabel.Size = new System.Drawing.Size(167, 16);
            arrivalAirportLabel.TabIndex = 39;
            arrivalAirportLabel.Text = "Аэропорт назначения:";
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            distanceLabel.Location = new System.Drawing.Point(12, 428);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(95, 16);
            distanceLabel.TabIndex = 41;
            distanceLabel.Text = "Расстояние:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 9.75F);
            label1.Location = new System.Drawing.Point(12, 464);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 16);
            label1.TabIndex = 45;
            label1.Text = "Фильтрация:";
            // 
            // airlinesDataSet
            // 
            this.airlinesDataSet.DataSetName = "airlinesDataSet";
            this.airlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.airlinesDataSet;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirplanesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrewMemberTableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.FlightsTableAdapter = this.flightsTableAdapter;
            this.tableAdapterManager.PassengersTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flightsBindingNavigator
            // 
            this.flightsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.flightsBindingNavigator.BindingSource = this.flightsBindingSource;
            this.flightsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.flightsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.flightsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.flightsBindingNavigatorSaveItem});
            this.flightsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.flightsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.flightsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.flightsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.flightsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.flightsBindingNavigator.Name = "flightsBindingNavigator";
            this.flightsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.flightsBindingNavigator.Size = new System.Drawing.Size(757, 25);
            this.flightsBindingNavigator.TabIndex = 0;
            this.flightsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // flightsBindingNavigatorSaveItem
            // 
            this.flightsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flightsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("flightsBindingNavigatorSaveItem.Image")));
            this.flightsBindingNavigatorSaveItem.Name = "flightsBindingNavigatorSaveItem";
            this.flightsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.flightsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.flightsBindingNavigatorSaveItem.Click += new System.EventHandler(this.flightsBindingNavigatorSaveItem_Click);
            // 
            // flightsDataGridView
            // 
            this.flightsDataGridView.AutoGenerateColumns = false;
            this.flightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.flightsDataGridView.DataSource = this.flightsBindingSource;
            this.flightsDataGridView.Location = new System.Drawing.Point(8, 21);
            this.flightsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.flightsDataGridView.Name = "flightsDataGridView";
            this.flightsDataGridView.Size = new System.Drawing.Size(742, 290);
            this.flightsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FlightID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FlightID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AirplaneID";
            this.dataGridViewTextBoxColumn2.HeaderText = "AirplaneID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepartureDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "DepartureDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DepartureTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "DepartureTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DepartureAirport";
            this.dataGridViewTextBoxColumn5.HeaderText = "DepartureAirport";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ArrivalAirport";
            this.dataGridViewTextBoxColumn6.HeaderText = "ArrivalAirport";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Distance";
            this.dataGridViewTextBoxColumn7.HeaderText = "Distance";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.addButton.Location = new System.Drawing.Point(391, 324);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(173, 46);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.deleteButton.Location = new System.Drawing.Point(577, 324);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(173, 46);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.saveButton.Location = new System.Drawing.Point(391, 376);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(359, 72);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // departureDateDateTimePicker
            // 
            this.departureDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.flightsBindingSource, "DepartureDate", true));
            this.departureDateDateTimePicker.Location = new System.Drawing.Point(185, 324);
            this.departureDateDateTimePicker.Name = "departureDateDateTimePicker";
            this.departureDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.departureDateDateTimePicker.TabIndex = 34;
            // 
            // departureAirportTextBox
            // 
            this.departureAirportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightsBindingSource, "DepartureAirport", true));
            this.departureAirportTextBox.Location = new System.Drawing.Point(185, 376);
            this.departureAirportTextBox.Name = "departureAirportTextBox";
            this.departureAirportTextBox.Size = new System.Drawing.Size(200, 20);
            this.departureAirportTextBox.TabIndex = 38;
            // 
            // arrivalAirportTextBox
            // 
            this.arrivalAirportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightsBindingSource, "ArrivalAirport", true));
            this.arrivalAirportTextBox.Location = new System.Drawing.Point(185, 402);
            this.arrivalAirportTextBox.Name = "arrivalAirportTextBox";
            this.arrivalAirportTextBox.Size = new System.Drawing.Size(200, 20);
            this.arrivalAirportTextBox.TabIndex = 40;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightsBindingSource, "Distance", true));
            this.distanceTextBox.Location = new System.Drawing.Point(185, 428);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(200, 20);
            this.distanceTextBox.TabIndex = 42;
            // 
            // departureTimeDateTimePicker
            // 
            this.departureTimeDateTimePicker.CustomFormat = "HH:mm";
            this.departureTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.flightsBindingSource, "DepartureTime", true));
            this.departureTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departureTimeDateTimePicker.Location = new System.Drawing.Point(185, 350);
            this.departureTimeDateTimePicker.Name = "departureTimeDateTimePicker";
            this.departureTimeDateTimePicker.ShowUpDown = true;
            this.departureTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.departureTimeDateTimePicker.TabIndex = 43;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "DepartureAirport",
            "ArrivalAirport"});
            this.cbFilter.Location = new System.Drawing.Point(476, 462);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(274, 21);
            this.cbFilter.TabIndex = 44;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(185, 462);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(200, 20);
            this.tbFilter.TabIndex = 46;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Courier New", 9.75F);
            label2.Location = new System.Drawing.Point(391, 464);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 16);
            label2.TabIndex = 55;
            label2.Text = "Критерий:";
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 491);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.departureTimeDateTimePicker);
            this.Controls.Add(departureDateLabel);
            this.Controls.Add(this.departureDateDateTimePicker);
            this.Controls.Add(departureTimeLabel);
            this.Controls.Add(departureAirportLabel);
            this.Controls.Add(this.departureAirportTextBox);
            this.Controls.Add(arrivalAirportLabel);
            this.Controls.Add(this.arrivalAirportTextBox);
            this.Controls.Add(distanceLabel);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.flightsDataGridView);
            this.Controls.Add(this.flightsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlightsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightsForm_FormClosing);
            this.Load += new System.EventHandler(this.FlightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingNavigator)).EndInit();
            this.flightsBindingNavigator.ResumeLayout(false);
            this.flightsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airlinesDataSet airlinesDataSet;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private airlinesDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private airlinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator flightsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton flightsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView flightsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker departureDateDateTimePicker;
        private System.Windows.Forms.TextBox departureAirportTextBox;
        private System.Windows.Forms.TextBox arrivalAirportTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.DateTimePicker departureTimeDateTimePicker;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbFilter;
    }
}