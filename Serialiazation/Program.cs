using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialiazation
{
    [XmlRoot("Store")]
    internal class Program
    {
        static void Main(string[] args)
        {
            var serializer = new XmlSerializer(typeof(Item));
            using(var wr = new StreamWriter("ItemInfo.xml"))
            {
                serializer.Serialize(wr, new Item() { Name="ItemName", Price = 2000, Producer= "ItemProducer" });
            };
        }
    }
}
