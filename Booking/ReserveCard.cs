using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class ReserveCard : Form
    {
        UsersContext db;

        public ReserveCard()
        {
            InitializeComponent();

            db = new UsersContext();
        }

        private void GoReserve_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(FIOTextBox.Text) && !String.IsNullOrEmpty(PaymentTextBox.Text) && DaysChanger.Value != 0)
            {
                User user = new User(FIOTextBox.Text, BirthDayDateTimePicker.Value.ToString(), Convert.ToInt32(PaymentTextBox.Text), Convert.ToInt32(DaysChanger.Value), Convert.ToInt32(AnimalCheckBox.Checked));
                db.Booking.Add(user);
                
                this.Hide();
                MessageBox.Show("Номер зарезервирован");
            }
            else
            {
                MessageBox.Show("Вы не ввели все данные");
            }
        }


        private void DaysChangerChange(object sender, EventArgs e)
        {
            decimal pay = 2000 * DaysChanger.Value;
            PaymentTextBox.Text = pay.ToString();
        }
    }
}
