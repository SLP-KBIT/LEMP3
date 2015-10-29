using System;
using System.IO;
using System.Xml.Serialization;

namespace LEMP3.Model.Common
{
    class XMLSupporter
    {
        private static readonly string APP_ROOT
            = System.AppDomain.CurrentDomain.BaseDirectory;

        public static T ReadXml<T>(string fileName) where T : new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamReader stream;
            T obj;
            try
            {
                stream = new StreamReader(APP_ROOT + fileName);
                obj = (T)serializer.Deserialize(stream);
                stream.Close();
            }
            catch (System.Exception)
            {
                obj = new T();
            }
            return obj;
        }

        public static void WriteXml<T>(string fileName, T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamWriter stream = new StreamWriter(APP_ROOT + fileName);
            System.Console.WriteLine(APP_ROOT + fileName);
            serializer.Serialize(stream, obj);
            stream.Close();
        }
    }
}
