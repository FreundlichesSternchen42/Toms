using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Serialization;

namespace Toms
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
        }

        // Verkettete Listen + Stacks zur Speicherung aller Daten (Events/Kategorien/Änderungen)
        public static LinkedList<Event> savedDates = new LinkedList<Event>();
        public static LinkedList<Categories> savedCategories = new LinkedList<Categories>();
        public static Stack<object> everythingYouEverDidOnThisProject = new Stack<object>();

        // Ende-Methode
        private void bt_backToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // STRG+Z für Undo-Feature
        private void Popup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                navigateUndo();
            }
        }        

        // Zentrale Zuordnungsmethode aller Undo-Methoden
        public static void navigateUndo()
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

        private void Popup_Load(object sender, EventArgs e)
        {
            rtbPopup.Text = "Momentan gibt es folgende Events: \n \n";
            for (int i = 0; i < savedDates.Count; i++)
            {
                Event ev = Popup.savedDates.ElementAt(i);
                rtbPopup.Text = rtbPopup.Text + (i+1) + ": " + ev.eventtitle + ", " + ev.category + ", " + ev.date + ", " + getRepeationAsString(ev.repeation) + "\n";
            }
        }

        public string getRepeationAsString(int integer)
        {
            switch (integer)
            {
                default: return "no repeation";  break;
                case 1: return "yearly repeation"; break;
                case 2: return "monthly repeation"; break;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Event delEvent = Popup.savedDates.ElementAt(int.Parse(tbIDInput.Text)-1);
                savedDates.Remove(delEvent);
                delEvent.action = "delete event";
                everythingYouEverDidOnThisProject.Push(delEvent);
                MessageBox.Show("Your Event: " + delEvent.eventtitle + " was successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No valid index number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }   
}
