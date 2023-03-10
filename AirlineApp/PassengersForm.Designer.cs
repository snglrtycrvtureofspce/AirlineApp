namespace AirlineApp
{
    partial class PassengersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengersForm));
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label passportDataLabel;
            System.Windows.Forms.Label seatNumberLabel;
            System.Windows.Forms.Label seatTypeLabel;
            this.airlinesDataSet = new AirlineApp.airlinesDataSet();
            this.passengersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passengersTableAdapter = new AirlineApp.airlinesDataSetTableAdapters.PassengersTableAdapter();
            this.tableAdapterManager = new AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager();
            this.passengersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.passengersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.passengersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.passportDataTextBox = new System.Windows.Forms.TextBox();
            this.seatNumberTextBox = new System.Windows.Forms.TextBox();
            this.seatTypeTextBox = new System.Windows.Forms.TextBox();
            fullNameLabel = new System.Windows.Forms.Label();
            passportDataLabel = new System.Windows.Forms.Label();
            seatNumberLabel = new System.Windows.Forms.Label();
            seatTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersBindingNavigator)).BeginInit();
            this.passengersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passengersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airlinesDataSet
            // 
            this.airlinesDataSet.DataSetName = "airlinesDataSet";
            this.airlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengersBindingSource
            // 
            this.passengersBindingSource.DataMember = "Passengers";
            this.passengersBindingSource.DataSource = this.airlinesDataSet;
            // 
            // passengersTableAdapter
            // 
            this.passengersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirplanesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrewMemberTableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.PassengersTableAdapter = this.passengersTableAdapter;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // passengersBindingNavigator
            // 
            this.passengersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.passengersBindingNavigator.BindingSource = this.passengersBindingSource;
            this.passengersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.passengersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.passengersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.passengersBindingNavigatorSaveItem});
            this.passengersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.passengersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.passengersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.passengersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.passengersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.passengersBindingNavigator.Name = "passengersBindingNavigator";
            this.passengersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.passengersBindingNavigator.Size = new System.Drawing.Size(575, 25);
            this.passengersBindingNavigator.TabIndex = 0;
            this.passengersBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // passengersBindingNavigatorSaveItem
            // 
            this.passengersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.passengersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("passengersBindingNavigatorSaveItem.Image")));
            this.passengersBindingNavigatorSaveItem.Name = "passengersBindingNavigatorSaveItem";
            this.passengersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.passengersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.passengersBindingNavigatorSaveItem.Click += new System.EventHandler(this.passengersBindingNavigatorSaveItem_Click);
            // 
            // passengersDataGridView
            // 
            this.passengersDataGridView.AutoGenerateColumns = false;
            this.passengersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.passengersDataGridView.DataSource = this.passengersBindingSource;
            this.passengersDataGridView.Location = new System.Drawing.Point(12, 28);
            this.passengersDataGridView.Name = "passengersDataGridView";
            this.passengersDataGridView.Size = new System.Drawing.Size(543, 342);
            this.passengersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PassengerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PassengerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PassportData";
            this.dataGridViewTextBoxColumn3.HeaderText = "PassportData";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SeatNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "SeatNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SeatType";
            this.dataGridViewTextBoxColumn5.HeaderText = "SeatType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.addButton.Location = new System.Drawing.Point(290, 410);
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
            this.deleteButton.Location = new System.Drawing.Point(290, 472);
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
            this.saveButton.Location = new System.Drawing.Point(62, 514);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(189, 54);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            fullNameLabel.Location = new System.Drawing.Point(18, 413);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(39, 16);
            fullNameLabel.TabIndex = 30;
            fullNameLabel.Text = "ФИО:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengersBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(151, 410);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fullNameTextBox.TabIndex = 31;
            // 
            // passportDataLabel
            // 
            passportDataLabel.AutoSize = true;
            passportDataLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            passportDataLabel.Location = new System.Drawing.Point(18, 439);
            passportDataLabel.Name = "passportDataLabel";
            passportDataLabel.Size = new System.Drawing.Size(127, 16);
            passportDataLabel.TabIndex = 32;
            passportDataLabel.Text = "Номер паспорта:";
            // 
            // passportDataTextBox
            // 
            this.passportDataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengersBindingSource, "PassportData", true));
            this.passportDataTextBox.Location = new System.Drawing.Point(151, 436);
            this.passportDataTextBox.Name = "passportDataTextBox";
            this.passportDataTextBox.Size = new System.Drawing.Size(100, 20);
            this.passportDataTextBox.TabIndex = 33;
            // 
            // seatNumberLabel
            // 
            seatNumberLabel.AutoSize = true;
            seatNumberLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            seatNumberLabel.Location = new System.Drawing.Point(18, 465);
            seatNumberLabel.Name = "seatNumberLabel";
            seatNumberLabel.Size = new System.Drawing.Size(103, 16);
            seatNumberLabel.TabIndex = 34;
            seatNumberLabel.Text = "Номер места:";
            // 
            // seatNumberTextBox
            // 
            this.seatNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengersBindingSource, "SeatNumber", true));
            this.seatNumberTextBox.Location = new System.Drawing.Point(151, 462);
            this.seatNumberTextBox.Name = "seatNumberTextBox";
            this.seatNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.seatNumberTextBox.TabIndex = 35;
            // 
            // seatTypeLabel
            // 
            seatTypeLabel.AutoSize = true;
            seatTypeLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            seatTypeLabel.Location = new System.Drawing.Point(18, 491);
            seatTypeLabel.Name = "seatTypeLabel";
            seatTypeLabel.Size = new System.Drawing.Size(103, 16);
            seatTypeLabel.TabIndex = 36;
            seatTypeLabel.Text = "Тип сиденья:";
            // 
            // seatTypeTextBox
            // 
            this.seatTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengersBindingSource, "SeatType", true));
            this.seatTypeTextBox.Location = new System.Drawing.Point(151, 488);
            this.seatTypeTextBox.Name = "seatTypeTextBox";
            this.seatTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.seatTypeTextBox.TabIndex = 37;
            // 
            // PassengersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 575);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(passportDataLabel);
            this.Controls.Add(this.passportDataTextBox);
            this.Controls.Add(seatNumberLabel);
            this.Controls.Add(this.seatNumberTextBox);
            this.Controls.Add(seatTypeLabel);
            this.Controls.Add(this.seatTypeTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passengersDataGridView);
            this.Controls.Add(this.passengersBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassengersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassengersForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassengersForm_FormClosing);
            this.Load += new System.EventHandler(this.PassengersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersBindingNavigator)).EndInit();
            this.passengersBindingNavigator.ResumeLayout(false);
            this.passengersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passengersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airlinesDataSet airlinesDataSet;
        private System.Windows.Forms.BindingSource passengersBindingSource;
        private airlinesDataSetTableAdapters.PassengersTableAdapter passengersTableAdapter;
        private airlinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator passengersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton passengersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView passengersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox passportDataTextBox;
        private System.Windows.Forms.TextBox seatNumberTextBox;
        private System.Windows.Forms.TextBox seatTypeTextBox;
    }
}