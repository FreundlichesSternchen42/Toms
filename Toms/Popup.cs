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

        public static LinkedList<Event> savedDates = new LinkedList<Event>();
        public static LinkedList<Categories> savedCategories = new LinkedList<Categories>();
        public static Stack<object> everythingYouEverDidOnThisProject = new Stack<object>();
        private void bt_backToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Safe_Load(object sender, EventArgs e)
        {

        }
    }
    
}
