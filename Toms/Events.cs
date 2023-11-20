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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void BtBackToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Events_Load(object sender, EventArgs e)
        {

        }

        private void btAddEvent_Click(object sender, EventArgs e)
        {
            Event ev = new Event();
            ev.eventtitle = tbEventTitle.Text;

        }
    }
}
