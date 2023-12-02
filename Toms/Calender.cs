using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Toms
{
    public partial class Calendar : Form
    {

        // Variabendeklarationen
        public int year;
        public int month;
        public int startDay;
        public int lastDay;
        public int week;
        public bool addmode;
        public bool view;

        public Calendar()
        {
            InitializeComponent();     
            
        }

        // Schließt diese Methode
        private void BtBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Springt zum nächsten Monat
        private void BtNext_Click(object sender, EventArgs e)
        {
            month++;
            if (month == 13)
            {
                month = 1;
                year++;
            }
            showMonthCalendarView();
        }

        // Springt zum letzten Monat
        private void BtPrevious_Click(object sender, EventArgs e)
        {
            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }
            showMonthCalendarView();
        }

        // Methode für die Monatsansicht
        public void showMonthCalendarView()
        {
            view = false;
            // frägt Anfangstag ab / frägt Anzahl der Tage ab
            startDay = Convert.ToInt16(DateTime.Parse(new DateTime(year, month, 1).ToString()).DayOfWeek) - 1;
            lastDay = Convert.ToInt16(DateTime.DaysInMonth(year, month));

            // Da Kalender standardmäßig mit Sonntag anfängt muss bei Sonntag (-1) der Wert auf 6 gesetzt werden um auch in Reihenfolge Mo-So zu sein
            if (startDay == -1)
            {
                startDay = 6;
            }

            // Anzeige des angezeigten Monats und Jahres
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbCDate.Text = monthname + " " + year;

            // Reset der Tabelle und Deaktivierung aller unnötigen Tabellenzellen
            for (int i = 1; i <= 42; i++)
            {
                giveCalendarObject(i).Text = "";

                if (i <= startDay || i >= (lastDay + startDay + 1))
                {
                    giveCalendarObject(i).Visible = false; // Deaktiviert unnötige Kalenderzeilen
                }
                else
                {
                    giveCalendarObject(i).Visible = true; // Aktiviert nötige Kalenderzeilen
                }
            }

            // Durchnummerierung der Monatsansicht
            for (int i = 1; i <= lastDay; i++)
            {
                int id = i + startDay;
                DateTime dt = Convert.ToDateTime(i.ToString() + "." + month.ToString() + "." + year.ToString());
                giveCalendarObject(id).SelectionFont = new Font(giveCalendarObject(id).Font, FontStyle.Bold);
                giveCalendarObject(id).Text = i.ToString();
                LinkedList<Event> events = getEventofDate(dt);

                // Anzeige der Events (Termine)
                if(events.Count > 0)
                {
                    giveCalendarObject(id).Text = giveCalendarObject(id).Text + "\n\n " + events.First().date + " " + events.First().eventtitle;
                    if(events.Count > 1)
                    {
                        giveCalendarObject(id).Text = giveCalendarObject(id).Text + "\n\n +" + (events.Count - 1) + " more";
                        
                    }
                    
                    if (getCategoryofName(events.First().category) != null)
                    {
                        giveCalendarObject(id).ForeColor = getCategoryofName(events.First().category).categoryColor;
                    }
                }
            }
        }

        // übersetzt Koordinaten zu id
        public RichTextBox give2DCalendarObject(int x, int y)
        {
            return giveCalendarObject(x + 7 * y);
        }

        // Kalenderansteuerungsmethode: Gibt die RTB mit der jeweiligen ID weiter
        public RichTextBox giveCalendarObject(int id)
        {
            switch (id)
            {
                default: return rtbCalendar01;
                case -7: return rtbHead7;
                case -6: return rtbHead6;
                case -5: return rtbHead5;
                case -4: return rtbHead4;
                case -3: return rtbHead3;
                case -2: return rtbHead2;
                case -1: return rtbHead1;
                case 01: return rtbCalendar01;
                case 02: return rtbCalendar02;
                case 03: return rtbCalendar03;
                case 04: return rtbCalendar04;
                case 05: return rtbCalendar05;
                case 06: return rtbCalendar06;
                case 07: return rtbCalendar07;
                case 08: return rtbCalendar08;
                case 09: return rtbCalendar09;
                case 10: return rtbCalendar10;
                case 11: return rtbCalendar11;
                case 12: return rtbCalendar12;
                case 13: return rtbCalendar13;
                case 14: return rtbCalendar14;
                case 15: return rtbCalendar15;
                case 16: return rtbCalendar16;
                case 17: return rtbCalendar17;
                case 18: return rtbCalendar18;
                case 19: return rtbCalendar19;
                case 20: return rtbCalendar20;
                case 21: return rtbCalendar21;
                case 22: return rtbCalendar22;
                case 23: return rtbCalendar23;
                case 24: return rtbCalendar24;
                case 25: return rtbCalendar25;
                case 26: return rtbCalendar26;
                case 27: return rtbCalendar27;
                case 28: return rtbCalendar28;
                case 29: return rtbCalendar29;
                case 30: return rtbCalendar30;
                case 31: return rtbCalendar31;
                case 32: return rtbCalendar32;
                case 33: return rtbCalendar33;
                case 34: return rtbCalendar34;
                case 35: return rtbCalendar35;
                case 36: return rtbCalendar36;
                case 37: return rtbCalendar37;
                case 38: return rtbCalendar38;
                case 39: return rtbCalendar39;
                case 40: return rtbCalendar40;
                case 41: return rtbCalendar41;
                case 42: return rtbCalendar42;
            }
        }

        // Automatischer Resize mit Timer
        private void TmUpdate_Tick(object sender, EventArgs e)
        {
            tlpCalendar.Width = this.Width - 100;
            tlpCalendar.Height = this.Height - 250;
        }

        // Startwerte für diese Klasse
        private void Calendar_Load(object sender, EventArgs e)
        { 
            year = Convert.ToInt32(DateTime.Now.Year);
            month = Convert.ToInt32(DateTime.Now.Month);
            addmode = false;
            showMonthCalendarView();
        }

        // findet alle Events mit gesuchtem Datum
        public LinkedList<Event> getEventofDate(DateTime date)
        {
            LinkedList<Event> events = new LinkedList<Event>();
            for (int i = 0; i < Popup.savedDates.Count; i++)
            {
                // keine Wiederholung (repeation == 0)
                if(Popup.savedDates.ElementAt(i).repeation == 0 && date == Popup.savedDates.ElementAt(i).getDateTime().Date)
                {
                    events.AddLast(Popup.savedDates.ElementAt(i));
                }
                // Jährliche Wiederholung (repeation == 1)
                else if(Popup.savedDates.ElementAt(i).repeation == 1 && Popup.savedDates.ElementAt(i).getDateTime().Day == date.Day && Popup.savedDates.ElementAt(i).getDateTime().Month == date.Month)
                {
                    events.AddLast(Popup.savedDates.ElementAt(i));
                }
                // Monatliche Wiederholung (repeation == 2)
                else if (Popup.savedDates.ElementAt(i).repeation == 2 && Popup.savedDates.ElementAt(i).getDateTime().Day == date.Day)
                {
                    events.AddLast(Popup.savedDates.ElementAt(i));
                }
            }
            return events;
        }

        // findet Kategorie mit gesuchtem Namen
        public static Categories getCategoryofName(string name)
        {
            for (int i = 0; i < Popup.savedCategories.Count; i++)
            {
                if (name == Popup.savedCategories.ElementAt(i).categoryName)
                {
                    return Popup.savedCategories.ElementAt(i);
                }
            }
            return null;
        }

        // findet Event mit gesuchtem Namen
        public static Event getEventofName(string name)
        {
            for (int i = 0; i < Popup.savedDates.Count; i++)
            {
                if (name == Popup.savedDates.ElementAt(i).eventtitle)
                {
                    return Popup.savedDates.ElementAt(i);
                }
            }
            return null;
        }

        // Erzeugt Datum aus gewünschter ID
        public DateTime getDate(int id)
        {
            if (view == false) // Monatsansicht
            {
                return Convert.ToDateTime((id - startDay).ToString() + "." + month.ToString() + "." + year.ToString());
            }
            else // Jahresansicht
            {
                int day = id % 7;
                return Convert.ToDateTime((week + day).ToString() + "." + month.ToString() + "." + year.ToString());
            }
        }
        // Allgemeine Buttonauslösemethode mit Übergabe der jeweiligen ID
        public void pressedCalendar(int id)
        {
            if (addmode == true)
            {
                DateTime dt = getDate(id);
                Event @event = new Event();
                @event.eventtitle = "from Calendar";
                @event.date = dt.ToString("dd.MM.yyyy");
                @event.Show();
            }
            else 
            { 
                // hier Platz für zukünftige Feature
            }
        }

        // Methoden welche durch die einzelnen Buttons ausgelöst werden:
        private void rtbCalendar01_Click(object sender, EventArgs e)
        {
            pressedCalendar(1);
        }
        private void rtbCalendar02_Click(object sender, EventArgs e)
        {
            pressedCalendar(2);
        }
        private void rtbCalendar03_Click(object sender, EventArgs e)
        {
            pressedCalendar(3);
        }
        private void rtbCalendar04_Click(object sender, EventArgs e)
        {
            pressedCalendar(4);
        }
        private void rtbCalendar05_Click(object sender, EventArgs e)
        {
            pressedCalendar(5);
        }
        private void rtbCalendar06_Click(object sender, EventArgs e)
        {
            pressedCalendar(6);
        }
        private void rtbCalendar07_Click(object sender, EventArgs e)
        {
            pressedCalendar(7);
        }
        private void rtbCalendar08_Click(object sender, EventArgs e)
        {
            pressedCalendar(8);
        }
        private void rtbCalendar09_Click(object sender, EventArgs e)
        {
            pressedCalendar(9);
        }
        private void rtbCalendar10_Click(object sender, EventArgs e)
        {
            pressedCalendar(10);
        }
        private void rtbCalendar11_Click(object sender, EventArgs e)
        {
            pressedCalendar(11);
        }
        private void rtbCalendar12_Click(object sender, EventArgs e)
        {
            pressedCalendar(12);
        }
        private void rtbCalendar13_Click(object sender, EventArgs e)
        {
            pressedCalendar(13);
        }
        private void rtbCalendar14_Click(object sender, EventArgs e)
        {
            pressedCalendar(14);
        }
        private void rtbCalendar15_Click(object sender, EventArgs e)
        {
            pressedCalendar(15);
        }
        private void rtbCalendar16_Click(object sender, EventArgs e)
        {
            pressedCalendar(16);
        }
        private void rtbCalendar17_Click(object sender, EventArgs e)
        {
            pressedCalendar(17);
        }
        private void rtbCalendar18_Click(object sender, EventArgs e)
        {
            pressedCalendar(18);
        }
        private void rtbCalendar19_Click(object sender, EventArgs e)
        {
            pressedCalendar(19);
        }
        private void rtbCalendar20_Click(object sender, EventArgs e)
        {
            pressedCalendar(20);
        }
        private void rtbCalendar21_Click(object sender, EventArgs e)
        {
            pressedCalendar(21);
        }
        private void rtbCalendar22_Click(object sender, EventArgs e)
        {
            pressedCalendar(22);
        }
        private void rtbCalendar23_Click(object sender, EventArgs e)
        {
            pressedCalendar(23);
        }
        private void rtbCalendar24_Click(object sender, EventArgs e)
        {
            pressedCalendar(24);
        }
        private void rtbCalendar25_Click(object sender, EventArgs e)
        {
            pressedCalendar(25);
        }
        private void rtbCalendar26_Click(object sender, EventArgs e)
        {
            pressedCalendar(26);
        }
        private void rtbCalendar27_Click(object sender, EventArgs e)
        {
            pressedCalendar(27);
        }
        private void rtbCalendar28_Click(object sender, EventArgs e)
        {
            pressedCalendar(28);
        }
        private void rtbCalendar29_Click(object sender, EventArgs e)
        {
            pressedCalendar(29);
        }
        private void rtbCalendar30_Click(object sender, EventArgs e)
        {
            pressedCalendar(30);
        }
        private void rtbCalendar31_Click(object sender, EventArgs e)
        {
            pressedCalendar(31);
        }
        private void rtbCalendar32_Click(object sender, EventArgs e)
        {
            pressedCalendar(32);
        }
        private void rtbCalendar33_Click(object sender, EventArgs e)
        {
            pressedCalendar(33);
        }
        private void rtbCalendar34_Click(object sender, EventArgs e)
        {
            pressedCalendar(34);
        }
        private void rtbCalendar35_Click(object sender, EventArgs e)
        {
            pressedCalendar(35);
        }
        private void rtbCalendar36_Click(object sender, EventArgs e)
        {
            pressedCalendar(36);
        }
        private void rtbCalendar37_Click(object sender, EventArgs e)
        {
            pressedCalendar(37);
        }
        private void rtbCalendar38_Click(object sender, EventArgs e)
        {
            pressedCalendar(38);
        }
        private void rtbCalendar39_Click(object sender, EventArgs e)
        {
            pressedCalendar(39);
        }
        private void rtbCalendar40_Click(object sender, EventArgs e)
        {
            pressedCalendar(40);
        }
        private void rtbCalendar41_Click(object sender, EventArgs e)
        {
            pressedCalendar(41);
        }
        private void rtbCalendar42_Click(object sender, EventArgs e)
        {
            pressedCalendar(42);
        }

        // Add-Mode Button 
        private void btAddMode_Click(object sender, EventArgs e)
        {
            if (addmode)
            {
                addmode = false;
                btAddMode.Text = "+";
            }
            else
            {
                addmode = true;
                btAddMode.Text = "-";
            }
        }

        // STRG+Z für Undo-Feature
        private void Calendar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Popup.navigateUndo();
            }
        }
    }
}
