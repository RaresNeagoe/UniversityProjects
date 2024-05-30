using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLApp
{
    //text in cadrul unui element
    class XText : IXElement
    {
        private string text;
        public string XName => "Text";
        public XText(string text)
        {
            this.text = text;
        }

        public void Add(IXElement element)
        {
            
        }

        public string GetXMLText()
        {
            return text;
        }

        public void Remove(IXElement element)
        {

        }
    }

}
