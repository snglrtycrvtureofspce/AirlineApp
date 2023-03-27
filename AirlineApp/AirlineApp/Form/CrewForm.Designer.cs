namespace AirlineApp.Form
{
    partial class CrewForm
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
            System.Windows.Forms.Label crewCodeLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrewForm));
            this.airlinesDataSet = new AirlineApp.airlinesDataSet();
            this.crewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crewTableAdapter = new AirlineApp.airlinesDataSetTableAdapters.CrewTableAdapter();
            this.tableAdapterManager = new AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager();
            this.crewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.crewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.crewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewCodeTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            crewCodeLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingNavigator)).BeginInit();
            this.crewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // crewCodeLabel
            // 
            crewCodeLabel.AutoSize = true;
            crewCodeLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            crewCodeLabel.Location = new System.Drawing.Point(12, 262);
            crewCodeLabel.Name = "crewCodeLabel";
            crewCodeLabel.Size = new System.Drawing.Size(87, 16);
            crewCodeLabel.TabIndex = 4;
            crewCodeLabel.Text = "Crew Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Courier New", 9.75F);
            label2.Location = new System.Drawing.Point(228, 289);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 16);
            label2.TabIndex = 59;
            label2.Text = "Критерий:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 9.75F);
            label1.Location = new System.Drawing.Point(12, 289);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 16);
            label1.TabIndex = 57;
            label1.Text = "Фильтрация:";
            // 
            // airlinesDataSet
            // 
            this.airlinesDataSet.DataSetName = "airlinesDataSet";
            this.airlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crewBindingSource
            // 
            this.crewBindingSource.DataMember = "Crew";
            this.crewBindingSource.DataSource = this.airlinesDataSet;
            // 
            // crewTableAdapter
            // 
            this.crewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirplanesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrewMemberTableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = this.crewTableAdapter;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.PassengersTableAdapter = null;
            this.tableAdapterManager.PeopleTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirlineApp.airlinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crewBindingNavigator
            // 
            this.crewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.crewBindingNavigator.BindingSource = this.crewBindingSource;
            this.crewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.crewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.crewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.crewBindingNavigatorSaveItem});
            this.crewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.crewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.crewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.crewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.crewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.crewBindingNavigator.Name = "crewBindingNavigator";
            this.crewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.crewBindingNavigator.Size = new System.Drawing.Size(464, 25);
            this.crewBindingNavigator.TabIndex = 0;
            this.crewBindingNavigator.Text = "bindingNavigator1";
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
            // crewBindingNavigatorSaveItem
            // 
            this.crewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.crewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("crewBindingNavigatorSaveItem.Image")));
            this.crewBindingNavigatorSaveItem.Name = "crewBindingNavigatorSaveItem";
            this.crewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.crewBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.crewBindingNavigatorSaveItem.Click += new System.EventHandler(this.crewBindingNavigatorSaveItem_Click);
            // 
            // crewDataGridView
            // 
            this.crewDataGridView.AutoGenerateColumns = false;
            this.crewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.crewDataGridView.DataSource = this.crewBindingSource;
            this.crewDataGridView.Location = new System.Drawing.Point(12, 28);
            this.crewDataGridView.Name = "crewDataGridView";
            this.crewDataGridView.Size = new System.Drawing.Size(443, 220);
            this.crewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CrewID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CrewID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CrewCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "CrewCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FlightsID";
            this.dataGridViewTextBoxColumn3.HeaderText = "FlightsID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CrewMemberID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CrewMemberID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // crewCodeTextBox
            // 
            this.crewCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crewBindingSource, "CrewCode", true));
            this.crewCodeTextBox.Location = new System.Drawing.Point(113, 259);
            this.crewCodeTextBox.Name = "crewCodeTextBox";
            this.crewCodeTextBox.Size = new System.Drawing.Size(342, 20);
            this.crewCodeTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.saveButton.Location = new System.Drawing.Point(15, 361);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(440, 39);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.deleteButton.Location = new System.Drawing.Point(231, 313);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(224, 42);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.addButton.Location = new System.Drawing.Point(15, 313);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(198, 42);
            this.addButton.TabIndex = 30;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(113, 287);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(100, 20);
            this.tbFilter.TabIndex = 58;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "CrewCode"});
            this.cbFilter.Location = new System.Drawing.Point(313, 286);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(142, 21);
            this.cbFilter.TabIndex = 56;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // CrewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 409);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(crewCodeLabel);
            this.Controls.Add(this.crewCodeTextBox);
            this.Controls.Add(this.crewDataGridView);
            this.Controls.Add(this.crewBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экипаж";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrewForm_FormClosing);
            this.Load += new System.EventHandler(this.CrewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingNavigator)).EndInit();
            this.crewBindingNavigator.ResumeLayout(false);
            this.crewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airlinesDataSet airlinesDataSet;
        private System.Windows.Forms.BindingSource crewBindingSource;
        private airlinesDataSetTableAdapters.CrewTableAdapter crewTableAdapter;
        private airlinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator crewBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton crewBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView crewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox crewCodeTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}