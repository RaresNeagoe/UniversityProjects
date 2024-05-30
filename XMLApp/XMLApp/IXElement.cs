using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLApp
{
    public interface IXElement
    {
        string XName { get; }
        void Add(IXElement element);
        void Remove(IXElement element);
        string GetXMLText(); //reprezentare ca string
    }
}
