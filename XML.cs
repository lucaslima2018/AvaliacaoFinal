using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;
using System.Xml.Linq;

namespace AvaliacaoFinal {
    public class XML {

    }

    public bool ReadUsingLinqNameSelect(string productName) {
        XDocument doc = XDocument.Load("PRODUCTS.xml");
        var query = from c in doc.Element("Products").Elements("Product")
                    where c.Element("Product_name").Value == productName
                    select c;

        return query.Count() > 0;

    }
}
