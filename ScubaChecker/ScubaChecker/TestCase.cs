using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ScubaChecker
{
    [Serializable()]
    public class TestCase : ITestCase
    {
        public string TestContent { get; set; }
        public int Id { get; set; }
        public TestCase(string content, int id)
        {
            TestContent = content;
            Id = id;
        }
        public TestCase()
        {

        }
        public bool Run()
        {
            return true;
        }

    }
}
