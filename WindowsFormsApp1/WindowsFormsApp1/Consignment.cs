using System;
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
    public class Consignment : IXmlSerializable
    {
        private Vegetable vegetable;
        public Vegetable Vegetable
        {
            get
            {
                return vegetable;
            }
            set
            {
                vegetable = value;
            }
        }

        private Delivery delivery;
        public Delivery Delivery
        {
            get
            {
                return delivery;
            }
            set
            {
                delivery = value;
            }
        }

        private int count;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        private int costOfTransportation;
        public int CostOfTransportation
        {
            get
            {
                return costOfTransportation;
            }
            set
            {
                costOfTransportation = value;
            }
        }

        private DateTime dateOfDelivery;
        public DateTime DateOfDelivery
        {
            get
            {
                return dateOfDelivery;
            }
            set
            {
                dateOfDelivery = value;
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
            XElement root = xDocument.Element("Warehouses");
            IEnumerable<XElement> rows = root.Descendants("Consignment");
            XElement lastRow = rows.Last();
            lastRow.AddAfterSelf(
               new XElement("Consignment",
               new XElement("Delivery", delivery),
               new XElement("Vegetable",
                new XElement("Name", vegetable.Name),
                new XElement("Country", vegetable.Country),
                new XElement("NumberSeasonOfMaturation", vegetable.NumberSeasonOfMaturation)),
               new XElement("DateOfDelivery", dateOfDelivery),
               new XElement("Count", count),
               new XElement("Price", price),
               new XElement("CostOfTransportation", costOfTransportation)));
            xDocument.Save(fileName);
        }

        public List<Consignment> GetAll(string fileName)
        {
            InfoAboutWarehouse.warehouse.Consignments.Clear();

            ReadXml(XmlReader.Create(fileName));

            return InfoAboutWarehouse.warehouse.Consignments;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            Consignment consignment = null;
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {

                    if (reader.Name.Equals("Consignment"))
                    {
                        consignment = new Consignment();
                        reader.Read();
                    }
                    switch (reader.Name)
                    {
                        case "Delivery":
                            reader.Read();
                            consignment.delivery = (Delivery)Enum.Parse(typeof(Delivery), reader.Value);
                            break;

                        case "Vegetable":
                            consignment.vegetable = Vegetable.ReadVegetable(reader);
                            break;

                        case "DateOfDelivery":
                            reader.Read();
                            consignment.dateOfDelivery = DateTime.Parse(reader.Value);
                            break;

                        case "Count":
                            reader.Read();
                            consignment.count = int.Parse(reader.Value);
                            break;

                        case "Price":
                            reader.Read();
                            consignment.price = int.Parse(reader.Value);
                            break;

                        case "CostOfTransportation":
                            reader.Read();
                            consignment.costOfTransportation = int.Parse(reader.Value);
                            break;
                    }
                }
                if (reader.Name.Equals("Consignment"))
                {
                    InfoAboutWarehouse.warehouse.Consignments.Add(consignment);
                }
            }
            reader.Close();
        }

        public static List<Consignment> ReadConsignment(XmlReader reader)
        {
            Consignment consignment = new Consignment();
            Consignment consignment2 = new Consignment();
            List<Consignment> consignments = new List<Consignment>();
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {                    
                    switch (reader.Name)
                    {
                        case "Delivery":
                            reader.Read();
                            consignment.delivery = (Delivery)Enum.Parse(typeof(Delivery), reader.Value);
                            break;

                        case "Vegetable":
                            consignment.vegetable = Vegetable.ReadVegetable(reader);
                            break;

                        case "DateOfDelivery":
                            reader.Read();
                            consignment.dateOfDelivery = DateTime.Parse(reader.Value);
                            break;

                        case "Count":
                            reader.Read();
                            consignment.count = int.Parse(reader.Value);
                            break;

                        case "Price":
                            reader.Read();
                            consignment.price = int.Parse(reader.Value);
                            break;

                        case "CostOfTransportation":
                            reader.Read();
                            consignment.costOfTransportation = int.Parse(reader.Value);
                            consignments.Add(consignment);
                            consignment = new Consignment();
                            break;
                    }
                }
                if (reader.Equals("Consignment"))
                {
                    break;
                }
            }
            return consignments;
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Consignments");
                writer.WriteStartElement("Consignment");
                    writer.WriteElementString("Delivery", delivery.ToString());
                    Vegetable.WriteXml(writer);
                    writer.WriteElementString("DateOfDelivery", dateOfDelivery.ToString());
                    writer.WriteElementString("Count", count.ToString());
                    writer.WriteElementString("Price", price.ToString());
                    writer.WriteElementString("CostOfTransportation", costOfTransportation.ToString());
                writer.WriteEndElement();
            writer.WriteEndElement();
        }

        public override string ToString()
        {
            return delivery + " / " + vegetable + " / " + dateOfDelivery + " / " + count + " / " + price + " / " + costOfTransportation;
        }
    }
}

