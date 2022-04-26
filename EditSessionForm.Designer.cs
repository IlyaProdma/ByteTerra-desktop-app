namespace DubnaHackathon
{
    partial class EditSessionForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.sessionIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.od1TextBox = new System.Windows.Forms.TextBox();
            this.od2TextBox = new System.Windows.Forms.TextBox();
            this.od3TextBox = new System.Windows.Forms.TextBox();
            this.od4TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.td1TextBox = new System.Windows.Forms.TextBox();
            this.td2TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.td3TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.td4TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.td5TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.td6TextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.td7TextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.td8TextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.td9TextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sessionIdTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 223);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер сессии:";
            // 
            // sessionIdTextBox
            // 
            this.sessionIdTextBox.Location = new System.Drawing.Point(153, 3);
            this.sessionIdTextBox.Name = "sessionIdTextBox";
            this.sessionIdTextBox.Size = new System.Drawing.Size(144, 31);
            this.sessionIdTextBox.TabIndex = 1;
            this.sessionIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integerTextBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ОД1-ОД4:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.od4TextBox);
            this.groupBox2.Controls.Add(this.od3TextBox);
            this.groupBox2.Controls.Add(this.od2TextBox);
            this.groupBox2.Controls.Add(this.od1TextBox);
            this.groupBox2.Location = new System.Drawing.Point(153, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 183);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // od1TextBox
            // 
            this.od1TextBox.Location = new System.Drawing.Point(-3, 30);
            this.od1TextBox.Name = "od1TextBox";
            this.od1TextBox.Size = new System.Drawing.Size(150, 31);
            this.od1TextBox.TabIndex = 0;
            this.od1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // od2TextBox
            // 
            this.od2TextBox.Location = new System.Drawing.Point(-3, 67);
            this.od2TextBox.Name = "od2TextBox";
            this.od2TextBox.Size = new System.Drawing.Size(150, 31);
            this.od2TextBox.TabIndex = 1;
            this.od2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // od3TextBox
            // 
            this.od3TextBox.Location = new System.Drawing.Point(-3, 104);
            this.od3TextBox.Name = "od3TextBox";
            this.od3TextBox.Size = new System.Drawing.Size(150, 31);
            this.od3TextBox.TabIndex = 2;
            this.od3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // od4TextBox
            // 
            this.od4TextBox.Location = new System.Drawing.Point(-3, 141);
            this.od4TextBox.Name = "od4TextBox";
            this.od4TextBox.Size = new System.Drawing.Size(150, 31);
            this.od4TextBox.TabIndex = 3;
            this.od4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ОД1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "ОД2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "ОД3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "ОД4:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.panel9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(688, 182);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(318, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 223);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ТД1-ТД9:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.td1TextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 48);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "ТД1:";
            // 
            // td1TextBox
            // 
            this.td1TextBox.Location = new System.Drawing.Point(56, 4);
            this.td1TextBox.Name = "td1TextBox";
            this.td1TextBox.Size = new System.Drawing.Size(150, 31);
            this.td1TextBox.TabIndex = 1;
            this.td1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // td2TextBox
            // 
            this.td2TextBox.Location = new System.Drawing.Point(56, 4);
            this.td2TextBox.Name = "td2TextBox";
            this.td2TextBox.Size = new System.Drawing.Size(150, 31);
            this.td2TextBox.TabIndex = 1;
            this.td2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "ТД2:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.td2TextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 53);
            this.panel2.TabIndex = 2;
            // 
            // td3TextBox
            // 
            this.td3TextBox.Location = new System.Drawing.Point(56, 4);
            this.td3TextBox.Name = "td3TextBox";
            this.td3TextBox.Size = new System.Drawing.Size(150, 31);
            this.td3TextBox.TabIndex = 1;
            this.td3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "ТД3:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.td3TextBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(3, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 51);
            this.panel3.TabIndex = 2;
            // 
            // td4TextBox
            // 
            this.td4TextBox.Location = new System.Drawing.Point(56, 4);
            this.td4TextBox.Name = "td4TextBox";
            this.td4TextBox.Size = new System.Drawing.Size(150, 31);
            this.td4TextBox.TabIndex = 1;
            this.td4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "ТД4:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.td4TextBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(228, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 48);
            this.panel4.TabIndex = 2;
            // 
            // td5TextBox
            // 
            this.td5TextBox.Location = new System.Drawing.Point(56, 4);
            this.td5TextBox.Name = "td5TextBox";
            this.td5TextBox.Size = new System.Drawing.Size(150, 31);
            this.td5TextBox.TabIndex = 1;
            this.td5TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "ТД5:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.td5TextBox);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(228, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 53);
            this.panel5.TabIndex = 2;
            // 
            // td6TextBox
            // 
            this.td6TextBox.Location = new System.Drawing.Point(56, 4);
            this.td6TextBox.Name = "td6TextBox";
            this.td6TextBox.Size = new System.Drawing.Size(150, 31);
            this.td6TextBox.TabIndex = 1;
            this.td6TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "ТД6:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.td6TextBox);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(228, 116);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(219, 51);
            this.panel6.TabIndex = 2;
            // 
            // td7TextBox
            // 
            this.td7TextBox.Location = new System.Drawing.Point(56, 4);
            this.td7TextBox.Name = "td7TextBox";
            this.td7TextBox.Size = new System.Drawing.Size(150, 31);
            this.td7TextBox.TabIndex = 1;
            this.td7TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "ТД7:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.td7TextBox);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(453, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(235, 48);
            this.panel7.TabIndex = 3;
            // 
            // td8TextBox
            // 
            this.td8TextBox.Location = new System.Drawing.Point(56, 4);
            this.td8TextBox.Name = "td8TextBox";
            this.td8TextBox.Size = new System.Drawing.Size(150, 31);
            this.td8TextBox.TabIndex = 1;
            this.td8TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "ТД8:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.td8TextBox);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Location = new System.Drawing.Point(453, 57);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(235, 53);
            this.panel8.TabIndex = 2;
            // 
            // td9TextBox
            // 
            this.td9TextBox.Location = new System.Drawing.Point(56, 4);
            this.td9TextBox.Name = "td9TextBox";
            this.td9TextBox.Size = new System.Drawing.Size(150, 31);
            this.td9TextBox.TabIndex = 1;
            this.td9TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floatTextBox_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "ТД9:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.td9TextBox);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Location = new System.Drawing.Point(453, 116);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(235, 51);
            this.panel9.TabIndex = 2;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(12, 241);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(170, 45);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Применить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // EditSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 292);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditSessionForm";
            this.Text = "Добавление результатов измерений";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox sessionIdTextBox;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox od4TextBox;
        private TextBox od3TextBox;
        private TextBox od2TextBox;
        private TextBox od1TextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel9;
        private TextBox td9TextBox;
        private Label label14;
        private Panel panel8;
        private TextBox td8TextBox;
        private Label label13;
        private Panel panel7;
        private TextBox td7TextBox;
        private Label label12;
        private Panel panel6;
        private TextBox td6TextBox;
        private Label label11;
        private Panel panel5;
        private TextBox td5TextBox;
        private Label label10;
        private Panel panel4;
        private TextBox td4TextBox;
        private Label label9;
        private Panel panel3;
        private TextBox td3TextBox;
        private Label label8;
        private Panel panel2;
        private TextBox td2TextBox;
        private Label label7;
        private Panel panel1;
        private TextBox td1TextBox;
        private Label label6;
        private GroupBox groupBox3;
        private Button confirmButton;
    }
}