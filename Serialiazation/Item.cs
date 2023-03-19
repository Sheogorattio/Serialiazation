using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Serialiazation
{
    public class Item
    {
        public Item() { }
        public Item(string name, string producer, double price)
        {
            this.Name = name;
            this.Producer = producer;
            this.Price = price;
        }
        [XmlAttribute]
        public string Name { get; set; }
        public string Producer { get; set; }
        public double Price { get; set; }
    }
}
