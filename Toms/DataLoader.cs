using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using Toms; // Annahme, dass dies der Namespace aus den bereitgestellten Dateien ist
using System.Drawing;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Toms
{ 
    public class DataLoader
    {
  
        public void LoadData()
        {
            string filePath = File.Exists("save.xml") ? "save.xml" : "init.xml";
            XDocument doc = XDocument.Load(filePath);
  
            List<Categories> categories = LoadCategories(doc);
            List<Event> events = LoadEvents(doc);
  
            if (filePath == "init.xml")
            {
                // Feiertage für Baden-Württemberg hinzufügen
                AddFeiertage(ref categories, ref events);
            }
  
            // Speichern in save.xml
            SaveData(categories, events);
        }

        public void LoadICS() { }  //??????????????????????????????????????????????????????????????????????????????


        private void AddFeiertage(ref List<Categories> categories, ref List<Event> events)
        {
            // Feiertage-Kategorie hinzufügen, falls noch nicht vorhanden
            var feiertageCategory = categories.FirstOrDefault(c => c.Name == "Feiertage");
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
                        Name = "Feiertage",
                        categoryColor = Color.FromArgb(r, g, b),
                        DeleteFlag = deleteFlag
                    };
                    categories.Add(feiertageCategory);
                }
            }


            // Ereignisse für Feiertage 2023 und 2024 hinzufügen
            // Dies erfordert das Parsen der .ics-Dateien, um Feiertagsdaten und -namen zu extrahieren
            // Hier wird eine Methode ParseFeiertageFromICS angenommen, die eine Liste von Event zurückgibt
            List<Event> feiertage2023 = ParseFeiertageFromICS("FeiertageBW2023.ics");
            List<Event> feiertage2024 = ParseFeiertageFromICS("FeiertageBW2024.ics");

            events.AddRange(feiertage2023);
            events.AddRange(feiertage2024);
        }


        private List<Categories> LoadCategories(XDocument doc)
        {
            var categories = from cat in doc.Descendants("category")
                             select new Categories
                             {
                                
                                 categoryName = (string)cat.Element("name"),
                                 categoryColor = Color.FromArgb(
                                     (int)cat.Element("color").Element("R"),
                                     (int)cat.Element("color").Element("G"),
                                     (int)cat.Element("color").Element("B")),
                                 DeleteFlag = (bool)cat.Element("deleteFlag")
                             };
  
            return categories.ToList();
        }
  
        private List<Event> ParseFeiertageFromICS(string filePath)
        {
  
            //2024 Trigger einbauen. filr 
  
            /*
                  public DateTime date;
                  public string time;
                  public string eventtitle;
                  public string category;
                  public int repeation;
                  public string action;
                  public bool DeleteFlag;
            */
  
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
  
         private List<Event> LoadEvents(XDocument doc)
         {
            var savedDates = from evt in doc.Descendants("event")
                             select new Event
                             {
                                 eventtitle = (string)evt.Element("eventtitle"),
                                 date = (int)evt.Element(""),
                                 time = (string)evt.Element("time"),
                                 repeation = (int)evt.Element("repeation"),
                                 category = (string)evt.Element("category"),
                                 action = (string)evt.Element("action"),
                                 DeleteFlag = (bool)evt.Element("DeleteFlag")
                             };
             return savedDates.ToList();
         }
  
       private void AddFeiertag(ref List<Categories> categories, ref List<Event> events)
       {
           // Feiertage-Kategorie hinzufügen, falls noch nicht vorhanden
           var feiertageCategory = categories.FirstOrDefault(c => c.categoryName == "Feiertage");
           if (feiertageCategory == null)
           {
               feiertageCategory = new Categories { categoryName = "Feiertage", categoryColor = Color.Red };
               categories.Add(feiertageCategory);
           }
      
           // Ereignisse für Feiertage 2023 und 2024 hinzufügen
           // Dies erfordert das Parsen der .ics-Dateien, um Feiertagsdaten und -namen zu extrahieren
           // Hier wird eine Methode ParseFeiertageFromICS angenommen, die eine Liste von Event zurückgibt
           List<Event> feiertage2023 = ParseFeiertageFromICS("FeiertageBW2023.ics");
           List<Event> feiertage2024 = ParseFeiertageFromICS("FeiertageBW2024.ics");
      
           events.AddRange(feiertage2023);
           events.AddRange(feiertage2024);
       }
      
       private void SaveData(List<Categories> categories, List<Event> events)
       {

            {
                var xDoc = new XDocument(
                    new XElement("data",
                        new XElement("categories",
                            categories.Select(c =>
                                new XElement("category",
                                   
                                    new XElement("categoryName", c.categoryName),
                                    new XElement("categoryColor", c.categoryColor),
                                        new XElement("R", c.categoryColor.R),
                                        new XElement("G", c.categoryColor.G),
                                        new XElement("B", c.categoryColor.B),
                                    new XElement("DeleteFlag", c.DeleteFlag)
                                )
                            )
                        ),
                        new XElement("events",
                            events.Select(e =>
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

                xDoc.Save("save.xml");
            }

        }

    }
}
