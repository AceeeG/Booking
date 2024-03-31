namespace Booking
{
    partial class ReserveCard
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
            this.GoReserveButton = new System.Windows.Forms.Button();
            this.AnimalCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DaysChanger = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BirthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PaymentTextBox = new System.Windows.Forms.TextBox();
            this.ComeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DaysChanger)).BeginInit();
            this.SuspendLayout();
            // 
            // GoReserveButton
            // 
            this.GoReserveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoReserveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoReserveButton.Location = new System.Drawing.Point(109, 402);
            this.GoReserveButton.Name = "GoReserveButton";
            this.GoReserveButton.Size = new System.Drawing.Size(218, 58);
            this.GoReserveButton.TabIndex = 31;
            this.GoReserveButton.Text = "Зарезервировать";
            this.GoReserveButton.UseVisualStyleBackColor = false;
            this.GoReserveButton.Click += new System.EventHandler(this.GoReserve_Click);
            // 
            // AnimalCheckBox
            // 
            this.AnimalCheckBox.AutoSize = true;
            this.AnimalCheckBox.Location = new System.Drawing.Point(24, 352);
            this.AnimalCheckBox.Name = "AnimalCheckBox";
            this.AnimalCheckBox.Size = new System.Drawing.Size(206, 20);
            this.AnimalCheckBox.TabIndex = 30;
            this.AnimalCheckBox.Text = "Путешествую с животными";
            this.AnimalCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(214, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Количество дней";
            // 
            // DaysChanger
            // 
            this.DaysChanger.Location = new System.Drawing.Point(24, 293);
            this.DaysChanger.Name = "DaysChanger";
            this.DaysChanger.Size = new System.Drawing.Size(139, 22);
            this.DaysChanger.TabIndex = 28;
            this.DaysChanger.ValueChanged += new System.EventHandler(this.DaysChangerChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(19, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Оплата";
            // 
            // BirthDayDateTimePicker
            // 
            this.BirthDayDateTimePicker.Location = new System.Drawing.Point(202, 104);
            this.BirthDayDateTimePicker.Name = "BirthDayDateTimePicker";
            this.BirthDayDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.BirthDayDateTimePicker.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Дата рождения";
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOTextBox.Location = new System.Drawing.Point(97, 27);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(305, 27);
            this.FIOTextBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(19, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "ФИО";
            // 
            // PaymentTextBox
            // 
            this.PaymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentTextBox.Location = new System.Drawing.Point(109, 221);
            this.PaymentTextBox.Name = "PaymentTextBox";
            this.PaymentTextBox.ReadOnly = true;
            this.PaymentTextBox.Size = new System.Drawing.Size(293, 27);
            this.PaymentTextBox.TabIndex = 32;
            // 
            // ComeDateTimePicker
            // 
            this.ComeDateTimePicker.Location = new System.Drawing.Point(202, 167);
            this.ComeDateTimePicker.Name = "ComeDateTimePicker";
            this.ComeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ComeDateTimePicker.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Заселение";
            // 
            // ReserveCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(433, 472);
            this.Controls.Add(this.ComeDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PaymentTextBox);
            this.Controls.Add(this.GoReserveButton);
            this.Controls.Add(this.AnimalCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DaysChanger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BirthDayDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIOTextBox);
            this.Controls.Add(this.label6);
            this.Name = "ReserveCard";
            this.Text = "ReserveCard";
            ((System.ComponentModel.ISupportInitialize)(this.DaysChanger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoReserveButton;
        private System.Windows.Forms.CheckBox AnimalCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DaysChanger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BirthDayDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PaymentTextBox;
        private System.Windows.Forms.DateTimePicker ComeDateTimePicker;
        private System.Windows.Forms.Label label4;
    }
}