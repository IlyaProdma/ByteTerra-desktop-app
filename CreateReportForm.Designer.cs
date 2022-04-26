namespace DubnaHackathon
{
    partial class CreateReportForm
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
            this.inputSessionIdLabel = new System.Windows.Forms.Label();
            this.sessionIdTextBox = new System.Windows.Forms.TextBox();
            this.reportTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.monProtocolRadioButton = new System.Windows.Forms.RadioButton();
            this.admProtocolRadioButton = new System.Windows.Forms.RadioButton();
            this.chooseDirSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentDirSaveLabel = new System.Windows.Forms.Label();
            this.createReportsButton = new System.Windows.Forms.Button();
            this.fileSaver = new System.ComponentModel.BackgroundWorker();
            this.statusLabel = new System.Windows.Forms.Label();
            this.reportTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputSessionIdLabel
            // 
            this.inputSessionIdLabel.AutoSize = true;
            this.inputSessionIdLabel.Location = new System.Drawing.Point(12, 15);
            this.inputSessionIdLabel.Name = "inputSessionIdLabel";
            this.inputSessionIdLabel.Size = new System.Drawing.Size(210, 25);
            this.inputSessionIdLabel.TabIndex = 0;
            this.inputSessionIdLabel.Text = "Номер(а) сессии/сессий:";
            // 
            // sessionIdTextBox
            // 
            this.sessionIdTextBox.Location = new System.Drawing.Point(228, 15);
            this.sessionIdTextBox.Name = "sessionIdTextBox";
            this.sessionIdTextBox.ShortcutsEnabled = false;
            this.sessionIdTextBox.Size = new System.Drawing.Size(163, 31);
            this.sessionIdTextBox.TabIndex = 1;
            this.sessionIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sessionIdTextBox_KeyPress);
            // 
            // reportTypeGroupBox
            // 
            this.reportTypeGroupBox.Controls.Add(this.monProtocolRadioButton);
            this.reportTypeGroupBox.Controls.Add(this.admProtocolRadioButton);
            this.reportTypeGroupBox.Location = new System.Drawing.Point(12, 49);
            this.reportTypeGroupBox.Name = "reportTypeGroupBox";
            this.reportTypeGroupBox.Size = new System.Drawing.Size(300, 115);
            this.reportTypeGroupBox.TabIndex = 2;
            this.reportTypeGroupBox.TabStop = false;
            this.reportTypeGroupBox.Text = "Тип отчета";
            // 
            // monProtocolRadioButton
            // 
            this.monProtocolRadioButton.AutoSize = true;
            this.monProtocolRadioButton.Location = new System.Drawing.Point(6, 65);
            this.monProtocolRadioButton.Name = "monProtocolRadioButton";
            this.monProtocolRadioButton.Size = new System.Drawing.Size(233, 29);
            this.monProtocolRadioButton.TabIndex = 3;
            this.monProtocolRadioButton.TabStop = true;
            this.monProtocolRadioButton.Text = "Протокол мониторинга";
            this.monProtocolRadioButton.UseVisualStyleBackColor = true;
            this.monProtocolRadioButton.CheckedChanged += new System.EventHandler(this.monProtocolRadioButton_CheckedChanged);
            // 
            // admProtocolRadioButton
            // 
            this.admProtocolRadioButton.AutoSize = true;
            this.admProtocolRadioButton.Location = new System.Drawing.Point(6, 30);
            this.admProtocolRadioButton.Name = "admProtocolRadioButton";
            this.admProtocolRadioButton.Size = new System.Drawing.Size(190, 29);
            this.admProtocolRadioButton.TabIndex = 0;
            this.admProtocolRadioButton.TabStop = true;
            this.admProtocolRadioButton.Text = "Протокол допуска";
            this.admProtocolRadioButton.UseVisualStyleBackColor = true;
            this.admProtocolRadioButton.CheckedChanged += new System.EventHandler(this.admProtocolRadioButton_CheckedChanged);
            // 
            // chooseDirSaveButton
            // 
            this.chooseDirSaveButton.Location = new System.Drawing.Point(12, 170);
            this.chooseDirSaveButton.Name = "chooseDirSaveButton";
            this.chooseDirSaveButton.Size = new System.Drawing.Size(300, 67);
            this.chooseDirSaveButton.TabIndex = 3;
            this.chooseDirSaveButton.Text = "Выбрать директорию сохранения";
            this.chooseDirSaveButton.UseVisualStyleBackColor = true;
            this.chooseDirSaveButton.Click += new System.EventHandler(this.chooseDirSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущая папка сохранения:";
            // 
            // currentDirSaveLabel
            // 
            this.currentDirSaveLabel.AutoSize = true;
            this.currentDirSaveLabel.Location = new System.Drawing.Point(318, 170);
            this.currentDirSaveLabel.Name = "currentDirSaveLabel";
            this.currentDirSaveLabel.Size = new System.Drawing.Size(0, 25);
            this.currentDirSaveLabel.TabIndex = 5;
            // 
            // createReportsButton
            // 
            this.createReportsButton.Location = new System.Drawing.Point(693, 12);
            this.createReportsButton.Name = "createReportsButton";
            this.createReportsButton.Size = new System.Drawing.Size(170, 65);
            this.createReportsButton.TabIndex = 6;
            this.createReportsButton.Text = "Сохранить";
            this.createReportsButton.UseVisualStyleBackColor = true;
            this.createReportsButton.Click += new System.EventHandler(this.createReportsButton_Click);
            // 
            // fileSaver
            // 
            this.fileSaver.WorkerReportsProgress = true;
            this.fileSaver.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fileSaver_DoWork);
            this.fileSaver.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.fileSaver_ProgressChanged);
            this.fileSaver.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.fileSaver_RunWorkerCompleted);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(410, 21);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(163, 25);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Идет сохранение...";
            // 
            // CreateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 254);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.createReportsButton);
            this.Controls.Add(this.currentDirSaveLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseDirSaveButton);
            this.Controls.Add(this.reportTypeGroupBox);
            this.Controls.Add(this.sessionIdTextBox);
            this.Controls.Add(this.inputSessionIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateReportForm";
            this.Text = "CreateReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateReportForm_FormClosing);
            this.reportTypeGroupBox.ResumeLayout(false);
            this.reportTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label inputSessionIdLabel;
        private TextBox sessionIdTextBox;
        private GroupBox reportTypeGroupBox;
        private RadioButton monProtocolRadioButton;
        private RadioButton admProtocolRadioButton;
        private Button chooseDirSaveButton;
        private Label label1;
        private Label currentDirSaveLabel;
        private Button createReportsButton;
        private System.ComponentModel.BackgroundWorker fileSaver;
        private Label statusLabel;
    }
}