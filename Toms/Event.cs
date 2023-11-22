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

        }

        private void Event_Load(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Event ev = new Event();
            ev.eventtitle = tbEvent.Text;
            Safe.sus.AddLast(ev);
        }
    }
}
