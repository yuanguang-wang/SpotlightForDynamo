using System.Xml;

namespace Spotlight.Support
{
    public static class DynamoCustomization
    {
        private const string OutputPath = "/Volumes/[C] Windows 11 PVM/Users/yuanguang.wang/AppData/Roaming/Dynamo/Dynamo Revit/2.12/packages/Spotlight/bin";

        public static void Write(string dynNamespace)
        {
            XmlWriter file = XmlWriter.Create(OutputPath + "/" + dynNamespace + "_DynamoCustomization+.xml");
            file.WriteStartDocument();
            file.WriteStartElement("doc");
            file.WriteStartElement("assembly");
            file.WriteStartElement("name");
            file.WriteValue(dynNamespace);
            file.WriteEndElement();
            file.WriteEndElement();
            file.WriteStartElement("namespaces");
            file.WriteStartElement("namespace");
            file.WriteAttributeString("name", dynNamespace);
            file.WriteStartElement("category");
            file.WriteValue(dynNamespace);
            file.WriteEndElement();
            file.WriteEndElement();
            file.WriteEndElement();
            file.WriteEndElement();
            file.WriteEndDocument();
            file.Close();
        }
    }
}