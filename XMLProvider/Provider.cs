using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XMLProvider
{
    public class XMLProvider<T>
    {
        public static void XMLSerialize(List<T> data, string filepath)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<T>));
            XmlWriter writer = XmlWriter.Create(filepath);
            serializer.WriteObject(writer, data);
            writer.Close();
        }
        public static List<T> XMLDeserialize(string filepath)
        {
            List<T> data = new List<T>();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            using (XmlReader reader = XmlReader.Create(filepath, settings))
            {
                DataContractSerializer formatter0 = new DataContractSerializer(typeof(List<T>));
                data =  (List<T>)formatter0.ReadObject(reader);
            }
            return data;

        }
    }
}