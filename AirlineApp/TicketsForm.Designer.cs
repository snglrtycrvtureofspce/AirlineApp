namespace AirlineApp
{
    partial class TicketsForm
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
            System.Windows.Forms.Label ticketPriceLabel;
            System.Windows.Forms.Label seatNumberLabel;
            System.Windows.Forms.Label seatTypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsForm));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.airlinesDataSet = new AirlineApp.airlinesDataSet();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new AirlineApp.airlinesDataSetTableAdapters.TicketsTableAdapter();
            this.tableAdapterManager = new AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager();
            this.ticketsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ticketsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ticketsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriceTextBox = new System.Windows.Forms.TextBox();
            this.seatNumberTextBox = new System.Windows.Forms.TextBox();
            this.seatTypeTextBox = new System.Windows.Forms.TextBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            ticketPriceLabel = new System.Windows.Forms.Label();
            seatNumberLabel = new System.Windows.Forms.Label();
            seatTypeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).BeginInit();
            this.ticketsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketPriceLabel
            // 
            ticketPriceLabel.AutoSize = true;
            ticketPriceLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            ticketPriceLabel.Location = new System.Drawing.Point(12, 334);
            ticketPriceLabel.Name = "ticketPriceLabel";
            ticketPriceLabel.Size = new System.Drawing.Size(103, 16);
            ticketPriceLabel.TabIndex = 36;
            ticketPriceLabel.Text = "Цена билета:";
            // 
            // seatNumberLabel
            // 
            seatNumberLabel.AutoSize = true;
            seatNumberLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            seatNumberLabel.Location = new System.Drawing.Point(12, 360);
            seatNumberLabel.Name = "seatNumberLabel";
            seatNumberLabel.Size = new System.Drawing.Size(103, 16);
            seatNumberLabel.TabIndex = 38;
            seatNumberLabel.Text = "Номер места:";
            // 
            // seatTypeLabel
            // 
            seatTypeLabel.AutoSize = true;
            seatTypeLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            seatTypeLabel.Location = new System.Drawing.Point(12, 386);
            seatTypeLabel.Name = "seatTypeLabel";
            seatTypeLabel.Size = new System.Drawing.Size(87, 16);
            seatTypeLabel.TabIndex = 40;
            seatTypeLabel.Text = "Тип места:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.addButton.Location = new System.Drawing.Point(334, 331);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(157, 30);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.deleteButton.Location = new System.Drawing.Point(497, 331);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(157, 30);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.saveButton.Location = new System.Drawing.Point(334, 367);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(320, 37);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // airlinesDataSet
            // 
            this.airlinesDataSet.DataSetName = "airlinesDataSet";
            this.airlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.airlinesDataSet;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirplanesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrewMemberTableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.PassengersTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = this.ticketsTableAdapter;
            this.tableAdapterManager.UpdateOrder = AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ticketsBindingNavigator
            // 
            this.ticketsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ticketsBindingNavigator.BindingSource = this.ticketsBindingSource;
            this.ticketsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ticketsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ticketsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ticketsBindingNavigatorSaveItem});
            this.ticketsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ticketsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ticketsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ticketsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ticketsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ticketsBindingNavigator.Name = "ticketsBindingNavigator";
            this.ticketsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ticketsBindingNavigator.Size = new System.Drawing.Size(666, 25);
            this.ticketsBindingNavigator.TabIndex = 30;
            this.ticketsBindingNavigator.Text = "bindingNavigator1";
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
            // ticketsBindingNavigatorSaveItem
            // 
            this.ticketsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ticketsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ticketsBindingNavigatorSaveItem.Image")));
            this.ticketsBindingNavigatorSaveItem.Name = "ticketsBindingNavigatorSaveItem";
            this.ticketsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ticketsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ticketsBindingNavigatorSaveItem.Click += new System.EventHandler(this.ticketsBindingNavigatorSaveItem_Click);
            // 
            // ticketsDataGridView
            // 
            this.ticketsDataGridView.AutoGenerateColumns = false;
            this.ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ticketsDataGridView.DataSource = this.ticketsBindingSource;
            this.ticketsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.ticketsDataGridView.Name = "ticketsDataGridView";
            this.ticketsDataGridView.Size = new System.Drawing.Size(642, 296);
            this.ticketsDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TicketID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TicketID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FlightID";
            this.dataGridViewTextBoxColumn2.HeaderText = "FlightID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PassengerID";
            this.dataGridViewTextBoxColumn3.HeaderText = "PassengerID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TicketPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "TicketPrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SeatNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "SeatNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SeatType";
            this.dataGridViewTextBoxColumn6.HeaderText = "SeatType";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ticketPriceTextBox
            // 
            this.ticketPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "TicketPrice", true));
            this.ticketPriceTextBox.Location = new System.Drawing.Point(121, 332);
            this.ticketPriceTextBox.Name = "ticketPriceTextBox";
            this.ticketPriceTextBox.Size = new System.Drawing.Size(207, 20);
            this.ticketPriceTextBox.TabIndex = 37;
            // 
            // seatNumberTextBox
            // 
            this.seatNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "SeatNumber", true));
            this.seatNumberTextBox.Location = new System.Drawing.Point(121, 358);
            this.seatNumberTextBox.Name = "seatNumberTextBox";
            this.seatNumberTextBox.Size = new System.Drawing.Size(207, 20);
            this.seatNumberTextBox.TabIndex = 39;
            // 
            // seatTypeTextBox
            // 
            this.seatTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "SeatType", true));
            this.seatTypeTextBox.Location = new System.Drawing.Point(121, 384);
            this.seatTypeTextBox.Name = "seatTypeTextBox";
            this.seatTypeTextBox.Size = new System.Drawing.Size(207, 20);
            this.seatTypeTextBox.TabIndex = 41;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(121, 416);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(207, 20);
            this.tbFilter.TabIndex = 49;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 9.75F);
            label1.Location = new System.Drawing.Point(12, 418);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 16);
            label1.TabIndex = 48;
            label1.Text = "Фильтрация:";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "SeatType"});
            this.cbFilter.Location = new System.Drawing.Point(419, 416);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(235, 21);
            this.cbFilter.TabIndex = 47;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Courier New", 9.75F);
            label2.Location = new System.Drawing.Point(334, 418);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 16);
            label2.TabIndex = 50;
            label2.Text = "Критерий:";
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 446);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(ticketPriceLabel);
            this.Controls.Add(this.ticketPriceTextBox);
            this.Controls.Add(seatNumberLabel);
            this.Controls.Add(this.seatNumberTextBox);
            this.Controls.Add(seatTypeLabel);
            this.Controls.Add(this.seatTypeTextBox);
            this.Controls.Add(this.ticketsDataGridView);
            this.Controls.Add(this.ticketsBindingNavigator);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicketsForm_FormClosing);
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).EndInit();
            this.ticketsBindingNavigator.ResumeLayout(false);
            this.ticketsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private airlinesDataSet airlinesDataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private airlinesDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private airlinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ticketsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ticketsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ticketsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox ticketPriceTextBox;
        private System.Windows.Forms.TextBox seatNumberTextBox;
        private System.Windows.Forms.TextBox seatTypeTextBox;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}