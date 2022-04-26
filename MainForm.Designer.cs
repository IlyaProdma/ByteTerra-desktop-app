namespace DubnaHackathon
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.googleGridView = new System.Windows.Forms.DataGridView();
            this.createSessionButton = new System.Windows.Forms.Button();
            this.editSessionButton = new System.Windows.Forms.Button();
            this.createReportButton = new System.Windows.Forms.Button();
            this.chooseSheetGroupBox = new System.Windows.Forms.GroupBox();
            this.ionSheetRadioButton = new System.Windows.Forms.RadioButton();
            this.timingSheetRadioButton = new System.Windows.Forms.RadioButton();
            this.dataSheetRadioButton = new System.Windows.Forms.RadioButton();
            this.refreshTableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.googleGridView)).BeginInit();
            this.chooseSheetGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // googleGridView
            // 
            this.googleGridView.AllowUserToAddRows = false;
            this.googleGridView.AllowUserToDeleteRows = false;
            this.googleGridView.AllowUserToResizeColumns = false;
            this.googleGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.googleGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.googleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.googleGridView.Location = new System.Drawing.Point(12, 12);
            this.googleGridView.Name = "googleGridView";
            this.googleGridView.ReadOnly = true;
            this.googleGridView.RowHeadersWidth = 60;
            this.googleGridView.RowTemplate.Height = 33;
            this.googleGridView.Size = new System.Drawing.Size(1554, 600);
            this.googleGridView.TabIndex = 0;
            // 
            // createSessionButton
            // 
            this.createSessionButton.Location = new System.Drawing.Point(12, 618);
            this.createSessionButton.Name = "createSessionButton";
            this.createSessionButton.Size = new System.Drawing.Size(185, 97);
            this.createSessionButton.TabIndex = 1;
            this.createSessionButton.Text = "Добавить сессию";
            this.createSessionButton.UseVisualStyleBackColor = true;
            this.createSessionButton.Click += new System.EventHandler(this.createSessionButton_Click);
            // 
            // editSessionButton
            // 
            this.editSessionButton.Location = new System.Drawing.Point(203, 618);
            this.editSessionButton.Name = "editSessionButton";
            this.editSessionButton.Size = new System.Drawing.Size(185, 97);
            this.editSessionButton.TabIndex = 2;
            this.editSessionButton.Text = "Изменить информацию";
            this.editSessionButton.UseVisualStyleBackColor = true;
            this.editSessionButton.Click += new System.EventHandler(this.editSessionButton_Click);
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(394, 618);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(185, 97);
            this.createReportButton.TabIndex = 3;
            this.createReportButton.Text = "Сформировать отчет";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // chooseSheetGroupBox
            // 
            this.chooseSheetGroupBox.Controls.Add(this.ionSheetRadioButton);
            this.chooseSheetGroupBox.Controls.Add(this.timingSheetRadioButton);
            this.chooseSheetGroupBox.Controls.Add(this.dataSheetRadioButton);
            this.chooseSheetGroupBox.Location = new System.Drawing.Point(1266, 618);
            this.chooseSheetGroupBox.Name = "chooseSheetGroupBox";
            this.chooseSheetGroupBox.Size = new System.Drawing.Size(300, 150);
            this.chooseSheetGroupBox.TabIndex = 4;
            this.chooseSheetGroupBox.TabStop = false;
            this.chooseSheetGroupBox.Text = "Выбор таблицы";
            // 
            // ionSheetRadioButton
            // 
            this.ionSheetRadioButton.AutoSize = true;
            this.ionSheetRadioButton.Location = new System.Drawing.Point(6, 100);
            this.ionSheetRadioButton.Name = "ionSheetRadioButton";
            this.ionSheetRadioButton.Size = new System.Drawing.Size(217, 29);
            this.ionSheetRadioButton.TabIndex = 2;
            this.ionSheetRadioButton.TabStop = true;
            this.ionSheetRadioButton.Text = "Информация по иону";
            this.ionSheetRadioButton.UseVisualStyleBackColor = true;
            this.ionSheetRadioButton.CheckedChanged += new System.EventHandler(this.ionSheetRadioButton_CheckedChanged);
            // 
            // timingSheetRadioButton
            // 
            this.timingSheetRadioButton.AutoSize = true;
            this.timingSheetRadioButton.Location = new System.Drawing.Point(6, 65);
            this.timingSheetRadioButton.Name = "timingSheetRadioButton";
            this.timingSheetRadioButton.Size = new System.Drawing.Size(91, 29);
            this.timingSheetRadioButton.TabIndex = 1;
            this.timingSheetRadioButton.TabStop = true;
            this.timingSheetRadioButton.Text = "Timing";
            this.timingSheetRadioButton.UseVisualStyleBackColor = true;
            this.timingSheetRadioButton.CheckedChanged += new System.EventHandler(this.timingSheetRadioButton_CheckedChanged);
            // 
            // dataSheetRadioButton
            // 
            this.dataSheetRadioButton.AutoSize = true;
            this.dataSheetRadioButton.Location = new System.Drawing.Point(6, 30);
            this.dataSheetRadioButton.Name = "dataSheetRadioButton";
            this.dataSheetRadioButton.Size = new System.Drawing.Size(74, 29);
            this.dataSheetRadioButton.TabIndex = 0;
            this.dataSheetRadioButton.TabStop = true;
            this.dataSheetRadioButton.Text = "Data";
            this.dataSheetRadioButton.UseVisualStyleBackColor = true;
            this.dataSheetRadioButton.CheckedChanged += new System.EventHandler(this.dataSheetRadioButton_CheckedChanged);
            // 
            // refreshTableButton
            // 
            this.refreshTableButton.Location = new System.Drawing.Point(1031, 618);
            this.refreshTableButton.Name = "refreshTableButton";
            this.refreshTableButton.Size = new System.Drawing.Size(229, 34);
            this.refreshTableButton.TabIndex = 5;
            this.refreshTableButton.Text = "Обновить таблицу";
            this.refreshTableButton.UseVisualStyleBackColor = true;
            this.refreshTableButton.Click += new System.EventHandler(this.refreshTableButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.refreshTableButton);
            this.Controls.Add(this.chooseSheetGroupBox);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.editSessionButton);
            this.Controls.Add(this.createSessionButton);
            this.Controls.Add(this.googleGridView);
            this.Name = "MainForm";
            this.Text = "Byte Terra";
            ((System.ComponentModel.ISupportInitialize)(this.googleGridView)).EndInit();
            this.chooseSheetGroupBox.ResumeLayout(false);
            this.chooseSheetGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView googleGridView;
        private Button createSessionButton;
        private Button editSessionButton;
        private Button createReportButton;
        private GroupBox chooseSheetGroupBox;
        private RadioButton ionSheetRadioButton;
        private RadioButton timingSheetRadioButton;
        private RadioButton dataSheetRadioButton;
        private Button refreshTableButton;
    }
}