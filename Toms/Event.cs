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
            Event ev = new Event();
            ev.eventtitle = tbEvent.Text;
            ev.date = dtbDate.Value.Date;
            ev.category = cbCategory.SelectedItem.ToString();
            Safe.savedDates.AddLast(ev);
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
    }
}
