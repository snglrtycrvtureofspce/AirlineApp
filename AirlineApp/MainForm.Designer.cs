namespace AirlineApp
{
    partial class MainForm
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.changeDBButton = new System.Windows.Forms.Button();
            this.queryButton = new System.Windows.Forms.Button();
            this.flightsButton = new System.Windows.Forms.Button();
            this.airplanesButton = new System.Windows.Forms.Button();
            this.passengersButton = new System.Windows.Forms.Button();
            this.ticketsButton = new System.Windows.Forms.Button();
            this.crewMemberButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeDBButton
            // 
            this.changeDBButton.Location = new System.Drawing.Point(387, 536);
            this.changeDBButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeDBButton.Name = "changeDBButton";
            this.changeDBButton.Size = new System.Drawing.Size(312, 90);
            this.changeDBButton.TabIndex = 0;
            this.changeDBButton.Text = "Редактирование БД";
            this.changeDBButton.UseVisualStyleBackColor = true;
            this.changeDBButton.Click += new System.EventHandler(this.changeDBButton_Click);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(13, 13);
            this.queryButton.Margin = new System.Windows.Forms.Padding(4);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(312, 90);
            this.queryButton.TabIndex = 1;
            this.queryButton.Text = "Запросы";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // flightsButton
            // 
            this.flightsButton.Location = new System.Drawing.Point(13, 138);
            this.flightsButton.Margin = new System.Windows.Forms.Padding(4);
            this.flightsButton.Name = "flightsButton";
            this.flightsButton.Size = new System.Drawing.Size(312, 90);
            this.flightsButton.TabIndex = 3;
            this.flightsButton.Text = "Полёты";
            this.flightsButton.UseVisualStyleBackColor = true;
            this.flightsButton.Click += new System.EventHandler(this.flightsButton_Click);
            // 
            // airplanesButton
            // 
            this.airplanesButton.Location = new System.Drawing.Point(707, 438);
            this.airplanesButton.Margin = new System.Windows.Forms.Padding(4);
            this.airplanesButton.Name = "airplanesButton";
            this.airplanesButton.Size = new System.Drawing.Size(312, 90);
            this.airplanesButton.TabIndex = 4;
            this.airplanesButton.Text = "Самолёты";
            this.airplanesButton.UseVisualStyleBackColor = true;
            this.airplanesButton.Click += new System.EventHandler(this.airplanesButton_Click);
            // 
            // passengersButton
            // 
            this.passengersButton.Location = new System.Drawing.Point(707, 536);
            this.passengersButton.Margin = new System.Windows.Forms.Padding(4);
            this.passengersButton.Name = "passengersButton";
            this.passengersButton.Size = new System.Drawing.Size(312, 90);
            this.passengersButton.TabIndex = 5;
            this.passengersButton.Text = "Пассажиры";
            this.passengersButton.UseVisualStyleBackColor = true;
            this.passengersButton.Click += new System.EventHandler(this.passengersButton_Click);
            // 
            // ticketsButton
            // 
            this.ticketsButton.Location = new System.Drawing.Point(13, 236);
            this.ticketsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ticketsButton.Name = "ticketsButton";
            this.ticketsButton.Size = new System.Drawing.Size(312, 90);
            this.ticketsButton.TabIndex = 6;
            this.ticketsButton.Text = "Билеты";
            this.ticketsButton.UseVisualStyleBackColor = true;
            this.ticketsButton.Click += new System.EventHandler(this.ticketsButton_Click);
            // 
            // crewMemberButton
            // 
            this.crewMemberButton.Location = new System.Drawing.Point(13, 334);
            this.crewMemberButton.Margin = new System.Windows.Forms.Padding(4);
            this.crewMemberButton.Name = "crewMemberButton";
            this.crewMemberButton.Size = new System.Drawing.Size(312, 90);
            this.crewMemberButton.TabIndex = 7;
            this.crewMemberButton.Text = "Член экипажа";
            this.crewMemberButton.UseVisualStyleBackColor = true;
            this.crewMemberButton.Click += new System.EventHandler(this.crewMemberButton_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Courier New", 9.75F);
            label2.Location = new System.Drawing.Point(71, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(191, 16);
            label2.TabIndex = 55;
            label2.Text = "Результирующие таблицы:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 646);
            this.Controls.Add(label2);
            this.Controls.Add(this.crewMemberButton);
            this.Controls.Add(this.ticketsButton);
            this.Controls.Add(this.passengersButton);
            this.Controls.Add(this.airplanesButton);
            this.Controls.Add(this.flightsButton);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.changeDBButton);
            this.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeDBButton;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Button flightsButton;
        private System.Windows.Forms.Button airplanesButton;
        private System.Windows.Forms.Button passengersButton;
        private System.Windows.Forms.Button ticketsButton;
        private System.Windows.Forms.Button crewMemberButton;
    }
}