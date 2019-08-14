using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Serialization
{
    [XmlRoot("Fields_Attributes")]
    public class ClassForXMLSerialization2
    {
        [XmlAttribute(AttributeName = "FF")]
        public int firstField = 2;
        [XmlAttribute(AttributeName = "SF")]
        public string SecondField = "SF - 3";

        public override string ToString()
        {
            return "First field = " + firstField.ToString() + " | Second field = " + SecondField;
        }

        public void ResetFields()
        {
            firstField = default(int);
            SecondField = default(string);
        }
    }
}
