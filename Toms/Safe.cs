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
    public partial class Safe : Form
    {
        public Safe()
        {
            InitializeComponent();
        }

        public static LinkedList<Event> savedDates = new LinkedList<Event>();
        private void bt_backToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_safe_Click(object sender, EventArgs e)
        {
            /*
 
            private Kunde KundeEinlesen()
            {
                XmlSerializer ser = new XmlSerializer(typeof(Kunde));
                StreamReader sr = new StreamReader(@"c:\Kunde1.xml");
                Kunde Kunde1 = (Kunde)ser.Deserialize(sr);
                sr.Close();
                return Kunde1;
            }

            private void KundeAnlegenUndSpeichern(string newVorname, string newNachname)
            {
                Kunde Kunde1 = new Kunde(newVorname, newNachname);

                XmlSerializer ser = new XmlSerializer(typeof(Kunde));
                FileStream str = new FileStream(@"c:\Kunde1.xml", FileMode.Create);
                ser.Serialize(str, Kunde1);
                str.Close();
            }

            public class Kunde
            {
            public Kunde(string newVorname, string newNachname)
            {
                Vorname = newVorname;
                Nachname = newNachname;
            }

            public Kunde()
            { }

            private string _Vorname;
            public string Vorname
            {
                get { return _Vorname; }
                set { _Vorname = value; }
            }

            private string _Nachname;
            public string Nachname
            {
                get { return _Nachname; }
                set { _Nachname = value; }

            */
        }

        private void Safe_Load(object sender, EventArgs e)
        {

        }
    }
    
}
