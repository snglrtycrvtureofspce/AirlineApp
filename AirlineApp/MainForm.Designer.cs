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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.changeDBButton = new System.Windows.Forms.Button();
            this.queryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeDBButton
            // 
            this.changeDBButton.Location = new System.Drawing.Point(68, 90);
            this.changeDBButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeDBButton.Name = "changeDBButton";
            this.changeDBButton.Size = new System.Drawing.Size(312, 90);
            this.changeDBButton.TabIndex = 0;
            this.changeDBButton.Text = "Редактирование БД";
            this.changeDBButton.UseVisualStyleBackColor = true;
            this.changeDBButton.Click += new System.EventHandler(this.changeDBButton_Click);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(524, 90);
            this.queryButton.Margin = new System.Windows.Forms.Padding(4);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(312, 90);
            this.queryButton.TabIndex = 1;
            this.queryButton.Text = "Запросы";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 812);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.changeDBButton);
            this.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeDBButton;
        private System.Windows.Forms.Button queryButton;
    }
}