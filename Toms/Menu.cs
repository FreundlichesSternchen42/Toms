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

        // Weiterleitung zur Popup-Form
        private void btPopup_Click(object sender, EventArgs e)
        {
            Popup popup = new Popup();
            popup.Show();
        }

        // Beendigung des gesamten Programms
        private void btEnd_Click(object sender, EventArgs e)
        {
            // hier speichern einfügen !!!
            Application.Exit();
        }

        // Weiterleitung zur Kalendar-Form
        private void BtCalender_Click(object sender, EventArgs e)
        {
            Calendar calender = new Calendar();
            // prüfen ob save.xml vorhanden. Wenn nicht, init.xml laden und mit Feiertgen befüllen. 
            calender.Show();
        }

        // Weiterleitung zur Event-Form
        private void BtEvent_Click(object sender, EventArgs e)
        {
            Event events = new Event();
            events.Show();
        }

        // Weiterleitung zur Kategorie-Form
        private void BtCategories_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
        }

        // STRG+Z für Undo-Feature
        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Popup.navigateUndo();
            }
        }
    }
}
