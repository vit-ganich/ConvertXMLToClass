using System.Collections.Generic;
using System.Xml.Serialization;

namespace Sandbox
{
    [XmlRoot(ElementName = "Object")]
    public class Object
    {
        [XmlElement(ElementName = "label")]
        public string Label { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "xpath")]
        public string XPath { get; set; }
    }

    [XmlRoot(ElementName = "Container")]
    public class Container
    {
        [XmlElement(ElementName = "label")]
        public string Label { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "Object")]
        public List<Object> Object { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "Repository")]
    public class Repository
    {
        [XmlElement(ElementName = "Container")]
        public Container Container { get; set; }
    }
}
