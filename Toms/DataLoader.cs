using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using Toms; 
using System.Drawing;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Toms
{ 
    public class DataLoader
    {
        // interner Speicher für nötige Daten
        public static LinkedList<Event> savedDates = new LinkedList<Event>();
        public static LinkedList<Categories> savedCategories = new LinkedList<Categories>();
        public static Stack<object> everythingYouEverDidOnThisProject = new Stack<object>();

        public void loadData()
        {
            string filePath = File.Exists("save1.xml") ? "save1.xml" : "init.xml";
            XDocument doc = XDocument.Load(filePath);
  
            List<Categories> categories = loadCategories(doc);
            List<Event> events = loadEvents(doc);
  
            if (filePath == "init.xml")
            {
                // Feiertage für Baden-Württemberg hinzufügen
                addFeiertage(ref categories, ref events);
            }
            for (int i = 0; i < events.Count; i++)
            {
                savedDates.AddLast(events[i]);
            }
            for (int i = 0; i < categories.Count; i++)
            {
                savedCategories.AddLast(categories[i]);
            }

            // Speichern in save.xml
            saveData(savedCategories, savedDates);
        }

        private void addFeiertage(ref List<Categories> categories, ref List<Event> events)
        {
            // Feiertage-Kategorie hinzufügen, falls noch nicht vorhanden
            var feiertageCategory = categories.FirstOrDefault(c => c.categoryName == "Feiertage");
            if (feiertageCategory == null)
            {
                // Lade die Kategorie aus init.xml
                XDocument initDoc = XDocument.Load("init.xml");
                var categoryElement = initDoc.Descendants("category").FirstOrDefault(c => c.Element("name")?.Value == "Feiertage");

                if (categoryElement != null)
                {
                    int r = int.Parse(categoryElement.Element("color").Element("R").Value);
                    int g = int.Parse(categoryElement.Element("color").Element("G").Value);
                    int b = int.Parse(categoryElement.Element("color").Element("B").Value);
                    bool deleteFlag = bool.Parse(categoryElement.Element("DeleteFlag").Value);

                    feiertageCategory = new Categories
                    {
                        categoryName = "Feiertage",
                        categoryColor = Color.FromArgb(r, g, b),
                        DeleteFlag = deleteFlag
                    };
                    categories.Add(feiertageCategory);
                }
            }

            // Ereignisse für Feiertage 2023 und 2024 hinzufügen
            // Dies erfordert das Parsen der .ics-Dateien, um Feiertagsdaten und -namen zu extrahieren
            // Hier wird eine Methode ParseFeiertageFromICS angenommen, die eine Liste von Event zurückgibt
            List<Event> feiertage2023 = parseFeiertageFromICS("FeiertageBW2023.ics");
            List<Event> feiertage2024 = parseFeiertageFromICS("FeiertageBW2024.ics");

            events.AddRange(feiertage2023);
            events.AddRange(feiertage2024);
        }

        //Daten in Kalender einfügen
        private List<Categories> loadCategories(XDocument doc)
        {
            var categories = from cat in doc.Descendants("category")
                             let nameElement = cat.Element("categoryName")
                             let colorElement = cat.Element("categoryColor")
                             let deleteFlagElement = cat.Element("DeleteFlag")
                             where nameElement != null && colorElement != null &&
                                   colorElement.Element("R") != null &&
                                   colorElement.Element("G") != null &&
                                   colorElement.Element("B") != null &&
                                   deleteFlagElement != null
                             let r = int.Parse(colorElement.Element("R").Value)
                             let g = int.Parse(colorElement.Element("G").Value)
                             let b = int.Parse(colorElement.Element("B").Value)
                             select new Categories
                             {
                                 categoryName = nameElement.Value,
                                 categoryColor = Color.FromArgb(r, g, b),
                                 DeleteFlag = bool.Parse(deleteFlagElement.Value)
                             };
            return categories.ToList();
        }

        private List<Event> parseFeiertageFromICS(string filePath)
        {
            List<Event> feiertage = new List<Event>();
            string[] lines = File.ReadAllLines(filePath);
            Event currentEvent = null;

            foreach (var line in lines)
            {
                if (line.StartsWith("BEGIN:VEVENT"))
                {
                    currentEvent = new Event();
                }
                else if (line.StartsWith("SUMMARY:"))
                {
                    currentEvent.eventtitle = line.Substring("SUMMARY:".Length).Trim();
                    if (filePath == "FeiertageBW2024.ics") currentEvent.eventtitle = currentEvent.eventtitle + " 24";

                }
                else if (line.StartsWith("DTSTART;"))
                {
                    string dateString = line.Substring(line.IndexOf(":") + 1).Trim();
                    DateTime parsedDate = DateTime.ParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture);

                    // Konvertiere das Datum in das Format yyyyMMdd als Ganzzahl
                    currentEvent.date = int.Parse(parsedDate.ToString("yyyyMMdd"));
                    currentEvent.time = "00:01";
                    currentEvent.repeation = 0;
                    currentEvent.action = "";
                    currentEvent.DeleteFlag = false;
                    currentEvent.category = "Feiertage";
                }
                else if (line.StartsWith("END:VEVENT"))
                {
                    feiertage.Add(currentEvent);
                }
            }
        return feiertage;
        }

        private List<Event> loadEvents(XDocument doc)
        {
            var savedDates = from evt in doc.Descendants("event")
                             select new Event
                             {
                                 eventtitle = (string)evt.Element("eventtitle"),
                                 date = int.Parse(DateTime.ParseExact((string)evt.Element("date"), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("yyyyMMdd")),
                                 time = (string)evt.Element("time"),
                                 repeation = int.Parse(evt.Element("repeation").Value),
                                 category = (string)evt.Element("category"),
                                 action = (string)evt.Element("action"),
                                 DeleteFlag = bool.Parse(evt.Element("DeleteFlag").Value)
                             };

            return savedDates.ToList();
        }
      
       public void saveData(LinkedList<Categories> savedCategories, LinkedList<Event> savedEvents)
       {
            {
                var xDoc = new XDocument(
                    new XElement("data",
                         new XElement("categories",
                           savedCategories.Select(c =>
                               new XElement("category",
                                   new XElement("categoryName", c.categoryName),
                                   new XElement("categoryColor", // Verwende 'categoryColor' als übergeordnetes Element
                                       new XElement("R", c.categoryColor.R),
                                       new XElement("G", c.categoryColor.G),
                                       new XElement("B", c.categoryColor.B)
                                   ),
                                   new XElement("DeleteFlag", c.DeleteFlag)
                                   )
                               )
                           ),
                        new XElement("events",
                            savedEvents.Select(e =>
                                new XElement("event",
                              
                                    new XElement("eventtitle", e.eventtitle),
                                   new XElement("date", e.date),
                                   new XElement("time", e.time),    
                                    new XElement("repeation", e.repeation),
                                        new XElement("category", e.category),
                                        new XElement("action", e.action),                    
                                    new XElement("DeleteFlag", e.DeleteFlag)
                                )
                            )
                        )
                    )
                );
                xDoc.Save("save1.xml");
            }
        }
    }
}
