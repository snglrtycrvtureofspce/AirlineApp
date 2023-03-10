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
            System.Windows.Forms.Label departureAirportLabel;
            System.Windows.Forms.Label distanceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightsForm));
            this.airlinesDataSet = new AirlineApp.airlinesDataSet();
            this.v1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v1TableAdapter = new AirlineApp.airlinesDataSetTableAdapters.V1TableAdapter();
            this.tableAdapterManager = new AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager();
            this.v1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.v1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.v1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departureAirportComboBox = new System.Windows.Forms.ComboBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            departureDateLabel = new System.Windows.Forms.Label();
            departureAirportLabel = new System.Windows.Forms.Label();
            distanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1BindingNavigator)).BeginInit();
            this.v1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // departureDateLabel
            // 
            departureDateLabel.AutoSize = true;
            departureDateLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            departureDateLabel.Location = new System.Drawing.Point(12, 378);
            departureDateLabel.Name = "departureDateLabel";
            departureDateLabel.Size = new System.Drawing.Size(127, 16);
            departureDateLabel.TabIndex = 2;
            departureDateLabel.Text = "Departure Date:";
            // 
            // departureAirportLabel
            // 
            departureAirportLabel.AutoSize = true;
            departureAirportLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            departureAirportLabel.Location = new System.Drawing.Point(12, 411);
            departureAirportLabel.Name = "departureAirportLabel";
            departureAirportLabel.Size = new System.Drawing.Size(151, 16);
            departureAirportLabel.TabIndex = 4;
            departureAirportLabel.Text = "Departure Airport:";
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            distanceLabel.Location = new System.Drawing.Point(12, 442);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(79, 16);
            distanceLabel.TabIndex = 6;
            distanceLabel.Text = "Distance:";
            // 
            // airlinesDataSet
            // 
            this.airlinesDataSet.DataSetName = "airlinesDataSet";
            this.airlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v1BindingSource
            // 
            this.v1BindingSource.DataMember = "V1";
            this.v1BindingSource.DataSource = this.airlinesDataSet;
            // 
            // v1TableAdapter
            // 
            this.v1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirplanesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CrewMemberTableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.PassengersTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v1BindingNavigator
            // 
            this.v1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.v1BindingNavigator.BindingSource = this.v1BindingSource;
            this.v1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.v1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.v1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.v1BindingNavigatorSaveItem});
            this.v1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.v1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.v1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.v1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.v1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.v1BindingNavigator.Name = "v1BindingNavigator";
            this.v1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.v1BindingNavigator.Size = new System.Drawing.Size(673, 25);
            this.v1BindingNavigator.TabIndex = 0;
            this.v1BindingNavigator.Text = "bindingNavigator1";
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
            // v1BindingNavigatorSaveItem
            // 
            this.v1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.v1BindingNavigatorSaveItem.Enabled = false;
            this.v1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("v1BindingNavigatorSaveItem.Image")));
            this.v1BindingNavigatorSaveItem.Name = "v1BindingNavigatorSaveItem";
            this.v1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.v1BindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // v1DataGridView
            // 
            this.v1DataGridView.AutoGenerateColumns = false;
            this.v1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.v1DataGridView.DataSource = this.v1BindingSource;
            this.v1DataGridView.Location = new System.Drawing.Point(12, 28);
            this.v1DataGridView.Name = "v1DataGridView";
            this.v1DataGridView.Size = new System.Drawing.Size(641, 314);
            this.v1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DepartureDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "DepartureDate";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DepartureTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "DepartureTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepartureAirport";
            this.dataGridViewTextBoxColumn3.HeaderText = "DepartureAirport";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ArrivalAirport";
            this.dataGridViewTextBoxColumn4.HeaderText = "ArrivalAirport";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Distance";
            this.dataGridViewTextBoxColumn5.HeaderText = "Distance";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AirplaneID";
            this.dataGridViewTextBoxColumn6.HeaderText = "AirplaneID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // departureDateDateTimePicker
            // 
            this.departureDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.v1BindingSource, "DepartureDate", true));
            this.departureDateDateTimePicker.Location = new System.Drawing.Point(169, 374);
            this.departureDateDateTimePicker.Name = "departureDateDateTimePicker";
            this.departureDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.departureDateDateTimePicker.TabIndex = 3;
            // 
            // departureAirportComboBox
            // 
            this.departureAirportComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v1BindingSource, "DepartureAirport", true));
            this.departureAirportComboBox.DataSource = this.v1BindingSource;
            this.departureAirportComboBox.DisplayMember = "DepartureAirport";
            this.departureAirportComboBox.FormattingEnabled = true;
            this.departureAirportComboBox.Location = new System.Drawing.Point(169, 408);
            this.departureAirportComboBox.Name = "departureAirportComboBox";
            this.departureAirportComboBox.Size = new System.Drawing.Size(121, 21);
            this.departureAirportComboBox.TabIndex = 5;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v1BindingSource, "Distance", true));
            this.distanceTextBox.Location = new System.Drawing.Point(169, 438);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.addButton.Location = new System.Drawing.Point(393, 373);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(189, 54);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.deleteButton.Location = new System.Drawing.Point(393, 442);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(189, 54);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.saveButton.Location = new System.Drawing.Point(180, 486);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(189, 54);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 566);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(distanceLabel);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(departureAirportLabel);
            this.Controls.Add(this.departureAirportComboBox);
            this.Controls.Add(departureDateLabel);
            this.Controls.Add(this.departureDateDateTimePicker);
            this.Controls.Add(this.v1DataGridView);
            this.Controls.Add(this.v1BindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlightsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AirplanesForm_FormClosing);
            this.Load += new System.EventHandler(this.FlightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1BindingNavigator)).EndInit();
            this.v1BindingNavigator.ResumeLayout(false);
            this.v1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airlinesDataSet airlinesDataSet;
        private System.Windows.Forms.BindingSource v1BindingSource;
        private airlinesDataSetTableAdapters.V1TableAdapter v1TableAdapter;
        private airlinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator v1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton v1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView v1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DateTimePicker departureDateDateTimePicker;
        private System.Windows.Forms.ComboBox departureAirportComboBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
    }
}