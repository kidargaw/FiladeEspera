using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace FiladeEspera
{
    public class ClientDAL
    {
        private static string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\client.xml";

        public static void WriteXml(Client client)
        {
            try
            {
                if (File.Exists(filePath) == false)
                {
                    WriteQueueXml(client);
                }
                else
                {
                    WriteQueueToAppendXml(client);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


        private static void WriteQueueXml(Client client)
        {


            using (XmlWriter writer = XmlWriter.Create(filePath))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Clients");


                writer.WriteStartElement("Client");

                writer.WriteElementString("Num", client.Num.ToString());
                writer.WriteElementString("Priority", client.Priority.ToString());
                writer.WriteElementString("Data", client.Data.ToString());
                writer.WriteElementString("Type", client.Type);

                writer.WriteEndElement();


                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

        }


        private static void WriteQueueToAppendXml(Client client)
        {

            XDocument xDocument = XDocument.Load(filePath);
            XElement root = xDocument.Element("Clients");
            System.Collections.Generic.IEnumerable<XElement> rows = root.Descendants("Client");
            XElement firstRow = rows.First();
            firstRow.AddBeforeSelf(
               new XElement("Client",
               new XElement("Num", client.Num.ToString()),
               new XElement("Priority", client.Priority.ToString()),
               new XElement("Data", client.Data.ToString()),
               new XElement("Type", client.Type)));
            xDocument.Save(filePath);
        }



       


        public static List<string> GetBooksExtension(string titleSearch)
        {
            XDocument xdoc = XDocument.Load(filePath);
            var query = xdoc.Descendants("Type").
            Where(t => t.Value.ToLower().Contains(titleSearch.ToLower())).
            Select(t => t.Value);

            return query.ToList<string>();
        }


 

        public static List<Client> GetAllClient()
        {
            List<Client> listClient = new List<Client>();

            XElement xelement = XElement.Load(filePath);
            IEnumerable<XElement> clients = xelement.Elements();


            foreach (var client in clients)
            {
                var client1 = new Client();
                client1.Num = Convert.ToInt32(client.Element("Num").Value);
                client1.Data = Convert.ToDateTime(client.Element("Data").Value);
                client1.Priority = Convert.ToInt32(client.Element("Priority").Value);
                client1.Type = client.Element("Type").Value;
                listClient.Add(client1);
            }

            return listClient;
        }


    }
}