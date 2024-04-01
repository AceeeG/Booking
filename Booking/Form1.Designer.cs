namespace Booking
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GuestCardPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FIOTextBox = new System.Windows.Forms.RichTextBox();
            this.CardCheckButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DischargedButton = new System.Windows.Forms.RadioButton();
            this.BuzyButton = new System.Windows.Forms.RadioButton();
            this.AvailableButton = new System.Windows.Forms.RadioButton();
            this.ReservedButton = new System.Windows.Forms.RadioButton();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GuestCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuestCardPanel
            // 
            this.GuestCardPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GuestCardPanel.Controls.Add(this.label8);
            this.GuestCardPanel.Controls.Add(this.label7);
            this.GuestCardPanel.Controls.Add(this.CheckOutDateTimePicker);
            this.GuestCardPanel.Controls.Add(this.CheckInDateTimePicker);
            this.GuestCardPanel.Controls.Add(this.FIOTextBox);
            this.GuestCardPanel.Controls.Add(this.CardCheckButton);
            this.GuestCardPanel.Controls.Add(this.label6);
            this.GuestCardPanel.Controls.Add(this.StatusDataGridView);
            this.GuestCardPanel.Controls.Add(this.label5);
            this.GuestCardPanel.Controls.Add(this.pictureBox1);
            this.GuestCardPanel.Controls.Add(this.label4);
            this.GuestCardPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.GuestCardPanel.Location = new System.Drawing.Point(600, 0);
            this.GuestCardPanel.Name = "GuestCardPanel";
            this.GuestCardPanel.Size = new System.Drawing.Size(368, 561);
            this.GuestCardPanel.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(6, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Дата выезда";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(6, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Дата заезда";
            // 
            // CheckOutDateTimePicker
            // 
            this.CheckOutDateTimePicker.Location = new System.Drawing.Point(147, 441);
            this.CheckOutDateTimePicker.Name = "CheckOutDateTimePicker";
            this.CheckOutDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.CheckOutDateTimePicker.TabIndex = 16;
            // 
            // CheckInDateTimePicker
            // 
            this.CheckInDateTimePicker.Location = new System.Drawing.Point(147, 387);
            this.CheckInDateTimePicker.Name = "CheckInDateTimePicker";
            this.CheckInDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.CheckInDateTimePicker.TabIndex = 15;
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(84, 309);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.ReadOnly = true;
            this.FIOTextBox.Size = new System.Drawing.Size(263, 43);
            this.FIOTextBox.TabIndex = 14;
            this.FIOTextBox.Text = "";
            // 
            // CardCheckButton
            // 
            this.CardCheckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CardCheckButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CardCheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardCheckButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CardCheckButton.Location = new System.Drawing.Point(171, 492);
            this.CardCheckButton.Name = "CardCheckButton";
            this.CardCheckButton.Size = new System.Drawing.Size(194, 66);
            this.CardCheckButton.TabIndex = 13;
            this.CardCheckButton.Text = "Просмотр карточки";
            this.CardCheckButton.UseVisualStyleBackColor = false;
            this.CardCheckButton.Click += new System.EventHandler(this.CardCheckButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(6, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "ФИО";
            // 
            // StatusDataGridView
            // 
            this.StatusDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.StatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatusDataGridView.Location = new System.Drawing.Point(84, 237);
            this.StatusDataGridView.Name = "StatusDataGridView";
            this.StatusDataGridView.RowHeadersWidth = 51;
            this.StatusDataGridView.RowTemplate.Height = 24;
            this.StatusDataGridView.Size = new System.Drawing.Size(263, 44);
            this.StatusDataGridView.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(6, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Статус";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(120, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 148);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(142, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер №";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 561);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 558);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список гостей";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReserveButton);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(279, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 552);
            this.panel1.TabIndex = 7;
            // 
            // ReserveButton
            // 
            this.ReserveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReserveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReserveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReserveButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ReserveButton.Location = new System.Drawing.Point(0, 485);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(318, 67);
            this.ReserveButton.TabIndex = 8;
            this.ReserveButton.Text = "Зарезервировать";
            this.ReserveButton.UseVisualStyleBackColor = false;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(312, 373);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список гостей";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(366, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 30);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "  Список гостей";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.TimerLabel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.DischargedButton);
            this.panel3.Controls.Add(this.BuzyButton);
            this.panel3.Controls.Add(this.AvailableButton);
            this.panel3.Controls.Add(this.ReservedButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 561);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(98, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Статус";
            // 
            // DischargedButton
            // 
            this.DischargedButton.AutoSize = true;
            this.DischargedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DischargedButton.Location = new System.Drawing.Point(51, 323);
            this.DischargedButton.Name = "DischargedButton";
            this.DischargedButton.Size = new System.Drawing.Size(173, 29);
            this.DischargedButton.TabIndex = 4;
            this.DischargedButton.TabStop = true;
            this.DischargedButton.Text = "Выписываются";
            this.DischargedButton.UseVisualStyleBackColor = true;
            // 
            // BuzyButton
            // 
            this.BuzyButton.AutoSize = true;
            this.BuzyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuzyButton.Location = new System.Drawing.Point(51, 262);
            this.BuzyButton.Name = "BuzyButton";
            this.BuzyButton.Size = new System.Drawing.Size(104, 29);
            this.BuzyButton.TabIndex = 3;
            this.BuzyButton.TabStop = true;
            this.BuzyButton.Text = "Заняты";
            this.BuzyButton.UseVisualStyleBackColor = true;
            // 
            // AvailableButton
            // 
            this.AvailableButton.AutoSize = true;
            this.AvailableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvailableButton.Location = new System.Drawing.Point(51, 195);
            this.AvailableButton.Name = "AvailableButton";
            this.AvailableButton.Size = new System.Drawing.Size(137, 29);
            this.AvailableButton.TabIndex = 2;
            this.AvailableButton.TabStop = true;
            this.AvailableButton.Text = "Свободные";
            this.AvailableButton.UseVisualStyleBackColor = true;
            // 
            // ReservedButton
            // 
            this.ReservedButton.AutoSize = true;
            this.ReservedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReservedButton.Location = new System.Drawing.Point(51, 128);
            this.ReservedButton.Name = "ReservedButton";
            this.ReservedButton.Size = new System.Drawing.Size(196, 29);
            this.ReservedButton.TabIndex = 1;
            this.ReservedButton.TabStop = true;
            this.ReservedButton.Text = "Зарезервировано";
            this.ReservedButton.UseVisualStyleBackColor = true;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(36, 3);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(74, 25);
            this.TimerLabel.TabIndex = 6;
            this.TimerLabel.Text = "Время";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GuestCardPanel);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.GuestCardPanel.ResumeLayout(false);
            this.GuestCardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GuestCardPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton AvailableButton;
        private System.Windows.Forms.RadioButton ReservedButton;
        private System.Windows.Forms.RadioButton DischargedButton;
        private System.Windows.Forms.RadioButton BuzyButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StatusDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CardCheckButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox FIOTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker CheckOutDateTimePicker;
        private System.Windows.Forms.DateTimePicker CheckInDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

