using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLApp
{
    //element XML
    class XElement : IXElement
    {
        public List<IXElement> Elements { get; set; } = new List<IXElement>();
        public List<XAttribute> Attributes { get; set; } = new List<XAttribute>();
        public XText Text { get; set; }
        public string XName { get; private set; }
        public XElement(string name)
        {
            XName = name;
        }

        public void Add(IXElement element)
        {
            if (element is XAttribute attribute)
            {
                Attributes.Add(attribute);
            }
            else if (element is XText text)
            {
                Text = text;
            }
            else
            {
                Elements.Add(element);
            }
        }

        public string GetXMLText()
        {
            var sb = new StringBuilder();
            sb.Append($"  <{XName}");
            foreach (var attr in Attributes)
            {
                sb.Append($" {attr.GetXMLText()}\n");
            }
            sb.Append(">");
            if (Text != null)
            {
                sb.Append(Text.GetXMLText());
            }
            foreach (var elem in Elements)
            {
                sb.Append(elem.GetXMLText());
            }
            sb.Append($"</{XName}>");
            sb.Append("\r\n");
            return sb.ToString();
        }

        public void Remove(IXElement element)
        {
            if (element is XAttribute attribute)
            {
                Attributes.Remove(attribute);
            }
            else if (element is XText text && Text == text)
            {
                Text = null;
            }
            else
            {
                Elements.Remove(element);
            }
        }
    }

}
