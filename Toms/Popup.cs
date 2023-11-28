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

        private void Popup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                navigateUndo();
            }
        }        
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
    }   
}
