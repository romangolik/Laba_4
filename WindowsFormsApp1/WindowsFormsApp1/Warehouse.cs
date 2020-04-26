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
    public class Warehouse : IXmlSerializable
    {
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        private int costOfService;
        public int CostOfService
        {
            get
            {
                return costOfService;
            }
            set
            {
                costOfService = value;
            }
        }

        private List<Consignment> consignments = new List<Consignment>();

        public List<Consignment> Consignments
        {
            get
            {
                return consignments;
            }

            set
            {
                consignments = value;
            }
        }

        public void AddConsignment(Consignment consignment)
        {
            consignments.Add(consignment);
        }

        public void RemoveConsigment(Consignment consignment)
        {
            consignments.Remove(consignment);
        }

        public string ToShortString()
        {
            int totalCost = 0;
            foreach (Consignment consignment in consignments)
            {
                totalCost += consignment.Price * consignment.Count;
            }
            return "Class name: Warehouse, the total cost of the goods in the warehouse: " + totalCost;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public Warehouse GetAll(string fileName)
        {
            Form1.elementOfWarehouses = null;

            ReadXml(XmlReader.Create(fileName));

            return Form1.elementOfWarehouses;
        }

        public void WriteToFile(string fileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            settings.NewLineOnAttributes = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);
            WriteXml(xmlWriter);
        }

        public void ReadXml(XmlReader reader)
        {
            Consignment consignment = new Consignment();
            Warehouse warehouse = null;
            reader.MoveToContent();
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.Name.Equals("Warehouse"))
                    {
                        warehouse = new Warehouse();
                        reader.Read();
                    }
                    switch (reader.Name)
                    {
                        case "Number":
                            reader.Read();
                            warehouse.Number = int.Parse(reader.Value);
                            break;

                        case "CostOfService":
                            reader.Read();
                            warehouse.CostOfService = int.Parse(reader.Value);
                            break;

                        case "Consignments":
                            warehouse.Consignments = Consignment.ReadConsignment(reader);
                            break;
                    }
                }
                Form1.elementOfWarehouses = warehouse;
            }
            
            reader.Close();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Warehouses");
             writer.WriteStartElement("Warehouse");
              writer.WriteElementString("Number", Number.ToString());
              writer.WriteElementString("CostOfService", CostOfService.ToString());
              if (consignments.Count > 0)
              {
                consignments[0].WriteXml(writer);
              }
             writer.WriteEndElement();
            writer.WriteEndElement();
            writer.Close();

            for (int i = 1; i < consignments.Count; i++)
            {
                consignments[i].Append("store/warehouses/warehouse_" + Number + ".xml");
            }
        }

        public override string ToString()
        {
            return "Warehouse number: " + number + ", cost of servise: " + costOfService;
        }
    }
}
