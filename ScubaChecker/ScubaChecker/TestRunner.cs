using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ScubaChecker
{
    public class TestRunner<T> : ITestsRunner<T>
    {
        public T[] Deserialize(Stream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
            XmlSerializer ser = new XmlSerializer(typeof(T[]));
            T[] newTs = (T[])ser.Deserialize(stream);
            return newTs;
        }
    }
}
