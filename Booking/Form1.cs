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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CardCheckButton_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            card.ShowDialog();
        }


        private void ReserveButton_Click(object sender, EventArgs e)
        {
            ReserveCard card = new ReserveCard();
            card.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = DateTime.Now.ToString();
        }
    }

}
