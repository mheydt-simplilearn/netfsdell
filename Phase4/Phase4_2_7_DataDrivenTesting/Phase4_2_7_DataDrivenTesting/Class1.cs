using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Phase4_2_7_DataDrivenTesting
{
    [TestFixture]
    public class Class1
    {


        [Test]
        [TestCase(10, 20, ExpectedResult = 30)]
        [TestCase(100, 300, ExpectedResult = 300)]
        [TestCase(1000, 2000, ExpectedResult = 3000)]
        public int DataDriven1(int x, int y)
        {
            var calc = new Calculator();
            return calc.add(x, y);
        }



        public static List<TestCaseData> TestCases
        {
            get
            {
                var testCases = new List<TestCaseData>();

                using (var fs = File.OpenRead("testdata.txt"))
                using (var sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            string[] split = line.Split(new char[] { ',' },
                                StringSplitOptions.None);

                            int a = Convert.ToInt32(split[0]);
                            int b = Convert.ToInt32(split[1]);
                            int answer = Convert.ToInt32(split[2]);

                            var testCase = new TestCaseData(a, b).Returns(answer);
                            testCases.Add(testCase);
                        }
                    }
                }

                return testCases;
            }


        }

        [Test]
        [TestCaseSource("TestCases")]
        public int DataDriven2(int x, int y)
        {
            var calc = new Calculator();
            return calc.add(x, y);
        }

    }

}
