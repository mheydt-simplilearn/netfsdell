using NUnit.Framework;
using System;

namespace Phase4_2_6_Exceptions.Tests
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void Exceptions()
        {
            var calc = new Calculator();

            Assert.Throws<InvalidOperationException>(() => calc.addStrings("aaa", "Bbb"));
        }


    }

}
