using System;
using System.Xml.Serialization;
using System.IO;

namespace HistorianTrendViewer.BL
{
    public static class Serializer
    {
        public static void Serialize(object _serializableobject, string _filename)
        {
            XmlSerializer serializer = new XmlSerializer(_serializableobject.GetType());
            using (FileStream fs = new FileStream(_filename, FileMode.Create))
            {
                serializer.Serialize(fs, _serializableobject);
            }
        }

        public static object Deserialize(string _filename, Type _type)
        {
            if (!string.IsNullOrEmpty(_filename) && System.IO.File.Exists(_filename))
            {
                XmlSerializer serializer = new XmlSerializer(_type);
                using (FileStream fs = new FileStream(_filename, FileMode.Open))
                {
                    return serializer.Deserialize(fs);
                }
            }

            else
                return null;
        }
    }
}