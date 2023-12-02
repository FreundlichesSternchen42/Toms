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

namespace Toms
{ 
    internal class DataLoader
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

        public void LoadICS() { }
        List<Event> ParseFeiertageFromICS(string filePath)
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
                    currentEvent.Name = line.Substring("SUMMARY:".Length).Trim();
                }
                else if (line.StartsWith("DTSTART;"))
                {
                    string dateString = line.Substring(line.IndexOf(":") + 1).Trim();
                    currentEvent.Date = DateTime.ParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture);
                }
                else if (line.StartsWith("END:VEVENT"))
                {
                    feiertage.Add(currentEvent);
                }
            }
  
            return feiertage;
        }
  
        private void AddFeiertage(ref List<Category> categories, ref List<Event> events)
        {
            // Feiertage-Kategorie hinzufügen, falls noch nicht vorhanden
            var feiertageCategory = categories.FirstOrDefault(c => c.Name == "Feiertage");
            if (feiertageCategory == null)
            {
                feiertageCategory = new Category { Name = "Feiertage", Color = Color.Red };
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
                 currentEvent.date = DateTime.ParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture);
                 currentEvent.time = "00:01";
                 currentEvent.repeation = 0;
                 currentEvent.action = "";
                 currentEvent.DeleteFlag = 0;
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
             var events = from evt in doc.Descendants("event")
                          select new Event
                          {
                              eventtitle = (string)evt.Element("eventtitle"),
                              date = (string)evt.Element("date"),
                              time = (string)evt.Element("time"),
                              repeation = (int)evt.Element("repeation"),
                              category = (string)evt.Element("category"),
                              action = (string)evt.Element("action"),
                              DeleteFlag = (bool)evt.Element("DeleteFlag"); 
                           }
        
             return events.ToList();
         }
  
       private void AddFeiertage(ref List<Categories> categories, ref List<Event> events)
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
            // Implementierung zum Speichern der Daten in save.xml
            // Dies würde das Erstellen eines XDocument und das Schreiben der Daten beinhalten
        }
  
        // Platzhalter-Implementierung zum Parsen von .ics-Dateien
        // Dies sollte durch eine tatsächliche Logik zum Parsen von .ics-Dateien ersetzt werden
        private List<Event> ParseFeiertageFromICS(string filePath)
        {
            return new List<Event>();
        }
    }
}
