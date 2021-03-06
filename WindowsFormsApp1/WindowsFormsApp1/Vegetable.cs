﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public class Vegetable : IXmlSerializable
    {
        private string name;
        public string Name
        {
            get 
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }

        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        private int numberSeasonOfMaturation;
        public int NumberSeasonOfMaturation
        {
            get 
            {
                return numberSeasonOfMaturation;
            }
            set
            {
                numberSeasonOfMaturation = value;
            }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void WriteToFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                Append(fileName);
            }
            else
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;
                settings.NewLineOnAttributes = true;
                settings.ConformanceLevel = ConformanceLevel.Auto;

                XmlWriter writer = XmlWriter.Create(fileName, settings);
                WriteXml(writer);
                writer.Close();
            }
        }

        public void Append(string fileName)
        {
            XDocument xDocument = XDocument.Load(fileName);
            XElement root = xDocument.Element("Vegetables");
            IEnumerable<XElement> rows = root.Descendants("Vegetable");
            XElement lastRow = rows.Last();
            lastRow.AddAfterSelf(
               new XElement("Vegetable",
               new XElement("Name", name),
               new XElement("Country", country),
               new XElement("NumberSeasonOfMaturation", numberSeasonOfMaturation.ToString())));
            xDocument.Save(fileName);
        }

        public List<Vegetable> GetAll(string fileName)
        {
            InfoAboutWarehouse.Vegetables.Clear();

            ReadXml(XmlReader.Create(fileName));

            return InfoAboutWarehouse.Vegetables;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            Vegetable vegetable = null;
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {

                    if (reader.Name.Equals("Vegetable"))
                    {
                        vegetable = new Vegetable();
                        reader.Read();
                    }
                    switch (reader.Name)
                    {
                        case "Name":
                            reader.Read();
                            vegetable.name = reader.Value;
                            break;

                        case "Country":
                            reader.Read();
                            vegetable.country = reader.Value;
                            break;

                        case "NumberSeasonOfMaturation":
                            reader.Read();
                            vegetable.numberSeasonOfMaturation = Int32.Parse(reader.Value);
                            break;
                    }
                }
                if (reader.Name.Equals("Vegetable"))
                {
                    InfoAboutWarehouse.Vegetables.Add(vegetable);
                }
            }
            reader.Close();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Vegetables");
                writer.WriteStartElement("Vegetable");
                    writer.WriteElementString("Name", name);
                    writer.WriteElementString("Country", country);
                    writer.WriteElementString("NumberSeasonOfMaturation", numberSeasonOfMaturation.ToString());
                writer.WriteEndElement();
            writer.WriteEndElement();
        }

        public static Vegetable ReadVegetable(XmlReader reader)
        {
            Vegetable vegetable = new Vegetable();
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "Name":
                            reader.Read();
                            vegetable.name = reader.Value;
                            break;

                        case "Country":
                            reader.Read();
                            vegetable.country = reader.Value;
                            break;

                        case "NumberSeasonOfMaturation":
                            reader.Read();
                            vegetable.numberSeasonOfMaturation = Int32.Parse(reader.Value);
                            break;
                    }
                }
                if (reader.Name.Equals("Vegetable"))
                {
                    break;
                }
            }

            return vegetable;
        }

        public override string ToString()
        {
            return name + " / " + country + " / " + numberSeasonOfMaturation;
        }
    }
}
