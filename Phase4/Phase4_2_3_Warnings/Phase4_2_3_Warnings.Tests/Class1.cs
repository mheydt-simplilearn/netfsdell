using NUnit.Framework;
using System;

namespace Phase4_2_3_Warnings.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test] // not in document
        public void Warnings()
        {
            int total = 100, marks1 = 60, marks2 = 75;
            string name = null;

            //Warn.If(marks1 > 100);
            Warn.If(name != null);

            Warn.Unless(marks1 + marks2 < 200);

            //.Warn("This is a warning message");
        }



    }

}
