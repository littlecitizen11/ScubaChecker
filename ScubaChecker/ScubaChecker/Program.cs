using System;
using System.Collections.Generic;
using System.Linq;

namespace ScubaChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCase t1 = new TestCase("Adani", 1);
            TestCase t2 = new TestCase("King", 2);

            TestCase[] testCases = new TestCase[2];
            testCases[0] = t1;
            testCases[1] = t2;

            Serializer<TestCase> ser = new Serializer<TestCase>();
            TestRunner<TestCase> dser = new TestRunner<TestCase>();
            var a = dser.Deserialize(ser.Serialize(testCases));
            Console.WriteLine(a.ToString() == testCases.ToString());

        }
    }
}
