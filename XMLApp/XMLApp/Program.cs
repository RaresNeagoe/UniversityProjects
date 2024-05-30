using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace XMLApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookstore = new XElement("bookstore");
            var book1 = new XElement("book");
            book1.Attributes.Add(new XAttribute("category", "cooking"));
            book1.Add(new XElement("title") { Text = new XText("Everyday Italian"), Attributes = new List<XAttribute> { new XAttribute("lang", "en") } });
            book1.Add(new XElement("author") { Text = new XText("Giada De Laurentiis") });
            book1.Add(new XElement("year") { Text = new XText("2005") });
            book1.Add(new XElement("price") { Text = new XText("30.00") });
            bookstore.Add(book1);
            var book2 = new XElement("book");
            book2.Attributes.Add(new XAttribute("category", "children"));
            book2.Add(new XElement("title") { Text = new XText("Harry Potter"), Attributes = new List<XAttribute> { new XAttribute("lang", "en") } });
            book2.Add(new XElement("author") { Text = new XText("J. K. Rowling") });
            book2.Add(new XElement("year") { Text = new XText("2001") });
            book2.Add(new XElement("price") { Text = new XText("25.99") });
            bookstore.Add(book2);
            var book3 = new XElement("book");
            book3.Attributes.Add(new XAttribute("category", "web"));
            book3.Add(new XElement("title") { Text = new XText("Learning XML"), Attributes = new List<XAttribute> { new XAttribute("lang", "en") } });
            book3.Add(new XElement("author") { Text = new XText("Erik T. Ray") });
            book3.Add(new XElement("year") { Text = new XText("2003") });
            book3.Add(new XElement("price") { Text = new XText("39.95") });
            bookstore.Add(book3);

            Console.WriteLine(bookstore.GetXMLText());
            string source_dir = @"D:\PROIECTE METODE AVANSATE DE PROGRAMARE\XMLApp\fisier.xml";
            System.IO.File.WriteAllText(source_dir, bookstore.GetXMLText());

            bookstore.Remove(book2);
            System.IO.File.WriteAllText(source_dir, bookstore.GetXMLText());
        }
    }
}
