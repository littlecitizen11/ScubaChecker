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
            xmlSerializer.Serialize(st, testsToSerialize);
            return st;
        }
    }
}
