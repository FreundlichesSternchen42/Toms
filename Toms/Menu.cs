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
            Popup safe = new Popup();
            safe.Show();
        }

        private void bt_end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtCalender_Click(object sender, EventArgs e)
        {
            Calendar calender = new Calendar();
            calender.Show();
        }

        private void BtEvent_Click(object sender, EventArgs e)
        {
            Event events = new Event();
            events.Show();
        }

        private void BtCategories_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
        }
    }
}
