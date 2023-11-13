using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_safe_Click(object sender, EventArgs e)
        {
            Safe safe = new Safe();
            safe.Show();
            this.Hide();
        }

        private void bt_end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtCalender_Click(object sender, EventArgs e)
        {
            lbDate calender = new lbDate();
            calender.Show();
            this.Hide();
           

        }

        private void BtEvents_Click(object sender, EventArgs e)
        {
            Events events = new Events();
            events.Show();
            this.Hide();
        }

        private void BtCategories_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
            this.Hide();
        }
    }
}
