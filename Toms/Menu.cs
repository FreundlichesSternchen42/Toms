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

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                if (Popup.everythingYouEverDidOnThisProject.Count > 0)
                {
                    object lastModification = Popup.everythingYouEverDidOnThisProject.Pop();
                    if (lastModification.GetType() == typeof(Categories))
                    {
                        Categories.undoCategory(lastModification);
                    }
                    else if (lastModification.GetType() == typeof(Event))
                    {
                        Event.undoEvent(lastModification);
                    }
                    else
                    {
                        MessageBox.Show("Error: Unusually Change! \n Please ignore that, it's probably code caused!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You don`t changed anything!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
