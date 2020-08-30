using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using MamasChecker.Abstract;

namespace ScubaChecker
{
    public class Serializer<T> : ISerializer<T>
    {
        public Stream Serialize(T[] testsToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T[]));
            Stream st = new MemoryStream();
            /*            foreach (var item in testsToSerialize)
                        {
                            xmlSerializer.Serialize(st, item);
                        }*/
            XmlTextWriter xmlTextWriter = new XmlTextWriter(st, Encoding.UTF8);
            xmlSerializer.Serialize(st, testsToSerialize);
            return st;
        }
    }
}
