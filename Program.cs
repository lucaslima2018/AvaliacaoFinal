using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Json;
using System.Web;

namespace AvaliacaoFinal {
    class Program {
        static void Main(string[] args) {
            
            XmlTextReader reader = new XmlTextReader("PRODUCTS.xml");
            while (reader.Read()) {
                switch (reader.NodeType) {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
            Console.ReadLine();

            Console.WriteLine("Informe o Nome do Produto: ");
            string productName = Console.ReadLine();
            Console.WriteLine(productName);

            string xml = "PRODUCTS.xml";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string json = JsonConvert.SerializeXmlNode(doc);

            Console.WriteLine(json);

        }
    }
}
