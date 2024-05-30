using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLApp
{
    //atribut XML
    class XAttribute : IXElement
    {
        private string name;
        public string XName => name;
        public string value;

        public XAttribute(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public void Add(IXElement element)
        {

        }

        public string GetXMLText()
        {
            return $"{name}=\"{value}\"";
        }

        public void Remove(IXElement element)
        {
        }
    }

}
