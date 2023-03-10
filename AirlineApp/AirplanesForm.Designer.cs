namespace AirlineApp
{
    partial class AirplanesForm
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
            System.Windows.Forms.Label registrationNumberLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label numberOfSeatsLabel;
            System.Windows.Forms.Label payloadLabel;
            System.Windows.Forms.Label speedLabel;
            System.Windows.Forms.Label manufactureDateLabel;
            System.Windows.Forms.Label flightHoursLabel;
            System.Windows.Forms.Label lastRepairDateLabel;
            System.Windows.Forms.Label destinationLabel;
            System.Windows.Forms.Label fuelConsumptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirplanesForm));
            this.airlinesDataSet = new AirlineApp.airlinesDataSet();
            this.airplanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airplanesTableAdapter = new AirlineApp.airlinesDataSetTableAdapters.AirplanesTableAdapter();
            this.tableAdapterManager = new AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager();
            this.airplanesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.airplanesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.airplanesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfSeatsTextBox = new System.Windows.Forms.TextBox();
            this.payloadTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.manufactureDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flightHoursTextBox = new System.Windows.Forms.TextBox();
            this.lastRepairDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.fuelConsumptionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            registrationNumberLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            numberOfSeatsLabel = new System.Windows.Forms.Label();
            payloadLabel = new System.Windows.Forms.Label();
            speedLabel = new System.Windows.Forms.Label();
            manufactureDateLabel = new System.Windows.Forms.Label();
            flightHoursLabel = new System.Windows.Forms.Label();
            lastRepairDateLabel = new System.Windows.Forms.Label();
            destinationLabel = new System.Windows.Forms.Label();
            fuelConsumptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingNavigator)).BeginInit();
            this.airplanesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationNumberLabel
            // 
            registrationNumberLabel.AutoSize = true;
            registrationNumberLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            registrationNumberLabel.Location = new System.Drawing.Point(29, 373);
            registrationNumberLabel.Name = "registrationNumberLabel";
            registrationNumberLabel.Size = new System.Drawing.Size(183, 16);
            registrationNumberLabel.TabIndex = 4;
            registrationNumberLabel.Text = "Регистрационный номер:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            typeLabel.Location = new System.Drawing.Point(29, 399);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(39, 16);
            typeLabel.TabIndex = 6;
            typeLabel.Text = "Тип:";
            // 
            // numberOfSeatsLabel
            // 
            numberOfSeatsLabel.AutoSize = true;
            numberOfSeatsLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            numberOfSeatsLabel.Location = new System.Drawing.Point(29, 425);
            numberOfSeatsLabel.Name = "numberOfSeatsLabel";
            numberOfSeatsLabel.Size = new System.Drawing.Size(135, 16);
            numberOfSeatsLabel.TabIndex = 8;
            numberOfSeatsLabel.Text = "Количество мест:";
            // 
            // payloadLabel
            // 
            payloadLabel.AutoSize = true;
            payloadLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            payloadLabel.Location = new System.Drawing.Point(29, 451);
            payloadLabel.Name = "payloadLabel";
            payloadLabel.Size = new System.Drawing.Size(143, 16);
            payloadLabel.TabIndex = 10;
            payloadLabel.Text = "Грузоподъёмность:";
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            speedLabel.Location = new System.Drawing.Point(29, 477);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new System.Drawing.Size(79, 16);
            speedLabel.TabIndex = 12;
            speedLabel.Text = "Скорость:";
            // 
            // manufactureDateLabel
            // 
            manufactureDateLabel.AutoSize = true;
            manufactureDateLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            manufactureDateLabel.Location = new System.Drawing.Point(29, 504);
            manufactureDateLabel.Name = "manufactureDateLabel";
            manufactureDateLabel.Size = new System.Drawing.Size(111, 16);
            manufactureDateLabel.TabIndex = 14;
            manufactureDateLabel.Text = "Дата выпуска:";
            // 
            // flightHoursLabel
            // 
            flightHoursLabel.AutoSize = true;
            flightHoursLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            flightHoursLabel.Location = new System.Drawing.Point(29, 529);
            flightHoursLabel.Name = "flightHoursLabel";
            flightHoursLabel.Size = new System.Drawing.Size(127, 16);
            flightHoursLabel.TabIndex = 16;
            flightHoursLabel.Text = "Налётано часов:";
            // 
            // lastRepairDateLabel
            // 
            lastRepairDateLabel.AutoSize = true;
            lastRepairDateLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            lastRepairDateLabel.Location = new System.Drawing.Point(29, 556);
            lastRepairDateLabel.Name = "lastRepairDateLabel";
            lastRepairDateLabel.Size = new System.Drawing.Size(199, 16);
            lastRepairDateLabel.TabIndex = 18;
            lastRepairDateLabel.Text = "Дата последнего ремонта:";
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            destinationLabel.Location = new System.Drawing.Point(29, 581);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new System.Drawing.Size(167, 16);
            destinationLabel.TabIndex = 20;
            destinationLabel.Text = "Назначение самолёта:";
            // 
            // fuelConsumptionLabel
            // 
            fuelConsumptionLabel.AutoSize = true;
            fuelConsumptionLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            fuelConsumptionLabel.Location = new System.Drawing.Point(29, 607);
            fuelConsumptionLabel.Name = "fuelConsumptionLabel";
            fuelConsumptionLabel.Size = new System.Drawing.Size(127, 16);
            fuelConsumptionLabel.TabIndex = 22;
            fuelConsumptionLabel.Text = "Расход топлива:";
            // 
            // airlinesDataSet
            // 
            this.airlinesDataSet.DataSetName = "airlinesDataSet";
            this.airlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airplanesBindingSource
            // 
            this.airplanesBindingSource.DataMember = "Airplanes";
            this.airplanesBindingSource.DataSource = this.airlinesDataSet;
            // 
            // airplanesTableAdapter
            // 
            this.airplanesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirplanesTableAdapter = this.airplanesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrewMemberTableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.PassengersTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // airplanesBindingNavigator
            // 
            this.airplanesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.airplanesBindingNavigator.BindingSource = this.airplanesBindingSource;
            this.airplanesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.airplanesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.airplanesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.airplanesBindingNavigatorSaveItem});
            this.airplanesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.airplanesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.airplanesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.airplanesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.airplanesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.airplanesBindingNavigator.Name = "airplanesBindingNavigator";
            this.airplanesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.airplanesBindingNavigator.Size = new System.Drawing.Size(1171, 25);
            this.airplanesBindingNavigator.TabIndex = 0;
            this.airplanesBindingNavigator.Text = "bindingNavigator1";
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
            // airplanesBindingNavigatorSaveItem
            // 
            this.airplanesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.airplanesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("airplanesBindingNavigatorSaveItem.Image")));
            this.airplanesBindingNavigatorSaveItem.Name = "airplanesBindingNavigatorSaveItem";
            this.airplanesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.airplanesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.airplanesBindingNavigatorSaveItem.Click += new System.EventHandler(this.airplanesBindingNavigatorSaveItem_Click);
            // 
            // airplanesDataGridView
            // 
            this.airplanesDataGridView.AutoGenerateColumns = false;
            this.airplanesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airplanesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.airplanesDataGridView.DataSource = this.airplanesBindingSource;
            this.airplanesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.airplanesDataGridView.Name = "airplanesDataGridView";
            this.airplanesDataGridView.Size = new System.Drawing.Size(1139, 330);
            this.airplanesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AirplaneID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AirplaneID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RegistrationNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "RegistrationNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumberOfSeats";
            this.dataGridViewTextBoxColumn4.HeaderText = "NumberOfSeats";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Payload";
            this.dataGridViewTextBoxColumn5.HeaderText = "Payload";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Speed";
            this.dataGridViewTextBoxColumn6.HeaderText = "Speed";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ManufactureDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "ManufactureDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FlightHours";
            this.dataGridViewTextBoxColumn8.HeaderText = "FlightHours";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LastRepairDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "LastRepairDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Destination";
            this.dataGridViewTextBoxColumn10.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FuelConsumption";
            this.dataGridViewTextBoxColumn11.HeaderText = "FuelConsumption";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "RegistrationNumber", true));
            this.registrationNumberTextBox.Location = new System.Drawing.Point(234, 370);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.registrationNumberTextBox.TabIndex = 5;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(234, 396);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(200, 20);
            this.typeTextBox.TabIndex = 7;
            // 
            // numberOfSeatsTextBox
            // 
            this.numberOfSeatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "NumberOfSeats", true));
            this.numberOfSeatsTextBox.Location = new System.Drawing.Point(234, 422);
            this.numberOfSeatsTextBox.Name = "numberOfSeatsTextBox";
            this.numberOfSeatsTextBox.Size = new System.Drawing.Size(200, 20);
            this.numberOfSeatsTextBox.TabIndex = 9;
            // 
            // payloadTextBox
            // 
            this.payloadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "Payload", true));
            this.payloadTextBox.Location = new System.Drawing.Point(234, 448);
            this.payloadTextBox.Name = "payloadTextBox";
            this.payloadTextBox.Size = new System.Drawing.Size(200, 20);
            this.payloadTextBox.TabIndex = 11;
            // 
            // speedTextBox
            // 
            this.speedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "Speed", true));
            this.speedTextBox.Location = new System.Drawing.Point(234, 474);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(200, 20);
            this.speedTextBox.TabIndex = 13;
            // 
            // manufactureDateDateTimePicker
            // 
            this.manufactureDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.airplanesBindingSource, "ManufactureDate", true));
            this.manufactureDateDateTimePicker.Location = new System.Drawing.Point(234, 500);
            this.manufactureDateDateTimePicker.Name = "manufactureDateDateTimePicker";
            this.manufactureDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.manufactureDateDateTimePicker.TabIndex = 15;
            // 
            // flightHoursTextBox
            // 
            this.flightHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "FlightHours", true));
            this.flightHoursTextBox.Location = new System.Drawing.Point(234, 526);
            this.flightHoursTextBox.Name = "flightHoursTextBox";
            this.flightHoursTextBox.Size = new System.Drawing.Size(200, 20);
            this.flightHoursTextBox.TabIndex = 17;
            // 
            // lastRepairDateDateTimePicker
            // 
            this.lastRepairDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.airplanesBindingSource, "LastRepairDate", true));
            this.lastRepairDateDateTimePicker.Location = new System.Drawing.Point(234, 552);
            this.lastRepairDateDateTimePicker.Name = "lastRepairDateDateTimePicker";
            this.lastRepairDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastRepairDateDateTimePicker.TabIndex = 19;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "Destination", true));
            this.destinationTextBox.Location = new System.Drawing.Point(234, 578);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(200, 20);
            this.destinationTextBox.TabIndex = 21;
            // 
            // fuelConsumptionTextBox
            // 
            this.fuelConsumptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "FuelConsumption", true));
            this.fuelConsumptionTextBox.Location = new System.Drawing.Point(234, 604);
            this.fuelConsumptionTextBox.Name = "fuelConsumptionTextBox";
            this.fuelConsumptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.fuelConsumptionTextBox.TabIndex = 23;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.addButton.Location = new System.Drawing.Point(457, 396);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(189, 54);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.saveButton.Location = new System.Drawing.Point(679, 458);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(189, 54);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.deleteButton.Location = new System.Drawing.Point(457, 518);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(189, 54);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AirplanesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 636);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(registrationNumberLabel);
            this.Controls.Add(this.registrationNumberTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(numberOfSeatsLabel);
            this.Controls.Add(this.numberOfSeatsTextBox);
            this.Controls.Add(payloadLabel);
            this.Controls.Add(this.payloadTextBox);
            this.Controls.Add(speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(manufactureDateLabel);
            this.Controls.Add(this.manufactureDateDateTimePicker);
            this.Controls.Add(flightHoursLabel);
            this.Controls.Add(this.flightHoursTextBox);
            this.Controls.Add(lastRepairDateLabel);
            this.Controls.Add(this.lastRepairDateDateTimePicker);
            this.Controls.Add(destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(fuelConsumptionLabel);
            this.Controls.Add(this.fuelConsumptionTextBox);
            this.Controls.Add(this.airplanesDataGridView);
            this.Controls.Add(this.airplanesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AirplanesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirplanesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AirplanesForm_FormClosing);
            this.Load += new System.EventHandler(this.AirplanesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingNavigator)).EndInit();
            this.airplanesBindingNavigator.ResumeLayout(false);
            this.airplanesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airlinesDataSet airlinesDataSet;
        private System.Windows.Forms.BindingSource airplanesBindingSource;
        private airlinesDataSetTableAdapters.AirplanesTableAdapter airplanesTableAdapter;
        private airlinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator airplanesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton airplanesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView airplanesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox numberOfSeatsTextBox;
        private System.Windows.Forms.TextBox payloadTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.DateTimePicker manufactureDateDateTimePicker;
        private System.Windows.Forms.TextBox flightHoursTextBox;
        private System.Windows.Forms.DateTimePicker lastRepairDateDateTimePicker;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox fuelConsumptionTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
    }
}