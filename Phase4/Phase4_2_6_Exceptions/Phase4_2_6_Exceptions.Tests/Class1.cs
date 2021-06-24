using NUnit.Framework;
using System;

namespace Phase4_2_6_Exceptions.Tests
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void ThrowsException()
        {
            var calc = new Calculator();

            // act / assert
            Assert.Throws<InvalidOperationException>(() => calc.addStrings("a", "2"));

            // check good parameters and return value
            // check bad parameters and return values
            // checks exception exceptions
        }

        [Test]
        public void AddsProperly()
        {
            var calc = new Calculator();

            // act / assert
            Assert.That(calc.addStrings("1", "2"), Is.EqualTo(3));
        }
    }

}
