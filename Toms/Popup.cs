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
 //     public static LinkedList<Event> savedDates = new LinkedList<Event>();
 //     public static LinkedList<Categories> savedCategories = new LinkedList<Categories>();
 //     public static Stack<object> everythingYouEverDidOnThisProject = new Stack<object>();

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
            if (DataLoader.everythingYouEverDidOnThisProject.Count > 0)
            {
                object lastModification = DataLoader.everythingYouEverDidOnThisProject.Pop();
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
            updateUserInterface();
        }
        public void updateUserInterface()
        {
            if (DataLoader.savedDates.Count > 0)
            {
                rtbPopup.Text = "Event list: \n \n";
                for (int i = 0; i < DataLoader.savedDates.Count; i++)
                {
                    Event ev = DataLoader.savedDates.ElementAt(i);
                    rtbPopup.Text = rtbPopup.Text + (i+1) + ": " + ev.eventtitle + ", " + ev.category + ", " + ev.date + ", " + ev.time.Replace(".",":") + getRepeationAsString(ev.repeation) + "\n";
                }
            }
            else
            {
                rtbPopup.Text = "No Event listed! \n \nPlease add something in the Event-Form!";
                label1.Visible = false;
                tbIDInput.Visible = false;
                btDelete.Visible = false;
            }
        }

        public string getRepeationAsString(int integer)
        {
            switch (integer)
            {
                default: return "no repeation"; 
                case 1: return "yearly repeation"; 
                case 2: return "monthly repeation"; 
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Event delEvent = DataLoader.savedDates.ElementAt(int.Parse(tbIDInput.Text)-1);
                DataLoader.savedDates.Remove(delEvent);
                delEvent.action = "delete event";
                DataLoader.everythingYouEverDidOnThisProject.Push(delEvent);
                MessageBox.Show("Your Event: " + delEvent.eventtitle + " was successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateUserInterface();
            }
            catch (Exception)
            {
                MessageBox.Show("No valid index number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}
