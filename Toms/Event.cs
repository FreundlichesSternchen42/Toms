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
    public partial class Event : Form
    {
        public DateTime date;
        public string eventtitle;
        public string category;
        public int repeation;
        public string action;
        public Event()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("Default");
            cbCategory.SelectedIndex = 0;
            if(eventtitle == "from Calendar")
            {
                dtbDate.Value = date;
            }
            for (int i = 0; i < Popup.savedCategories.Count; i++)
            {
                cbCategory.Items.Add(Popup.savedCategories.ElementAt(i).categoryName);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tbEvent.Text != "")
            {
                if(getTime() == DateTime.MinValue)
                {
                    MessageBox.Show("Your Event has no correct time. \nTime should be devorced with ':' or '.'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Calendar.getEventofName(tbEvent.Text) != null)
                {
                    MessageBox.Show("Your Event has no unique name. \n please change the name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Event ev = new Event();
                    ev.eventtitle = tbEvent.Text;
                    ev.date = dtbDate.Value.Date + getTime().TimeOfDay;
                    ev.category = cbCategory.SelectedItem.ToString();
                    ev.repeation = cbRepeat.SelectedIndex;
                    Popup.savedDates.AddLast(ev);
                    ev.action = "create event";
                    Popup.everythingYouEverDidOnThisProject.Push(ev);
                    MessageBox.Show("Your Event has been created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Your Event has no title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            if (tbEvent.Text == "")
            {
                btSave.Text = "Event needs a name!";
            }
            else if(Calendar.getEventofName(tbEvent.Text) != null)
            {
                btSave.Text = "Event needs an unique name!";
            }
            else
            {
                btSave.Text = "Save event";
            }
        }

        public DateTime getTime()
        {
            string[] value = tbTime.Text.Split(new char[] {'.',':'});
            DateTime dt;
            try
            {
                DateTime.TryParse(value[0] + ":" + value[1], out dt);
            }
            catch (Exception)
            {
                dt = DateTime.MinValue;
            }
            return dt;
        }

        public static void undoEvent(object lastModification)
        {
            if (lastModification != null)
            {
                if (lastModification.GetType() == typeof(Event))
                {
                    Event ev = (Event)lastModification;
                    if (ev.action == "create event")
                    {
                        MessageBox.Show("Undo: Your Category: " + ev.eventtitle + " was successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Popup.savedDates.Remove(ev);
                    }
                    else if (ev.action == "delete event")
                    {
                        MessageBox.Show("Undo: Your Category: " + ev.eventtitle + " was successfully recreated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Popup.savedDates.AddLast(ev);
                    }
                }
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (Calendar.getEventofName(tbEvent.Text) != null)
            {
                Event ev = Calendar.getEventofName(tbEvent.Text);
                ev.action = "delete event";
                Popup.everythingYouEverDidOnThisProject.Push(ev);
                Popup.savedDates.Remove(Calendar.getEventofName(tbEvent.Text));
                MessageBox.Show("Your Category: " + tbEvent.Text + " was successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Category with the name: '" + tbEvent.Text + "' found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Event_KeyDown(object sender, KeyEventArgs e)
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
