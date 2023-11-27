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
            for (int i = 0; i < Safe.savedCategories.Count; i++)
            {
                cbCategory.Items.Add(Safe.savedCategories.ElementAt(i).categoryName);
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
                else
                {
                    Event ev = new Event();
                    ev.eventtitle = tbEvent.Text;
                    ev.date = dtbDate.Value.Date + getTime().TimeOfDay;
                    ev.category = cbCategory.SelectedItem.ToString();
                    ev.repeation = cbRepeat.SelectedIndex;
                    Safe.savedDates.AddLast(ev);
                    ev.action = "create event";
                    Safe.everythingYouEverDidOnThisProject.Push(ev);
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
    }
}
