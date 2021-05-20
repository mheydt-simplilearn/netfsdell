using NUnit.Framework;
using System;

namespace Phase4_2_4_ArrangeActAssert.Tests
{
    [TestFixture]
    public class Class1
    {


        [Test]
        public void ArrangeActAssert()
        {
            var calc = new Calculator();
            var answer = calc.add(5, 19);

            Assert.That(answer, Is.EqualTo(24));
        }



    }

}
