using System;

namespace XmlBuilder
{
    class Program
    {

        class XmlBuilder {
            private string xml;

            public XmlBuilder()
            {
                this.xml = "";
            }

            public XmlBuilder beginTag(string value)
            {
                this.xml += "<" + value + ">";
                return this;
            }
            public XmlBuilder content(string value)
            {
                this.xml += " " + value + " ";
                return this;
            }
            public XmlBuilder endTag(string value)
            {
                this.xml += "</" + value + ">";
                return this;
            }

            public string get()
            {
                return this.xml;
            }
        }
        static void Main(string[] args)
        {
            XmlBuilder x = new XmlBuilder();

            x.beginTag("note")
             .beginTag("to")
             .content("Mohammed")
             .endTag("to")

             .beginTag("from")
             .content("SAUD")
             .endTag("from")

             .beginTag("heading")
             .content("Remainder")
             .endTag("heading")

             .beginTag("body")
             .content("Submit the assignment on time")
             .endTag("body")

              .endTag("note");

            Console.WriteLine(x.get());

        }
    }
}
