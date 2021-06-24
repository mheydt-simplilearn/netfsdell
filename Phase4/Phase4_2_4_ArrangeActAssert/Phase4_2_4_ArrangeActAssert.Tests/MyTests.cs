using NUnit.Framework;
using System;

namespace Phase4_2_4_ArrangeActAssert.Tests
{
    [TestFixture]
    public class MyTests
    {


        [Test]
        public void ArrangeActAssert()
        {
            // arrange
            var calc = new Calculator();
            
            // act
            var answer = calc.add(5, 19);

            // asset
            Assert.That(answer, Is.EqualTo(24));
        }



    }

}
