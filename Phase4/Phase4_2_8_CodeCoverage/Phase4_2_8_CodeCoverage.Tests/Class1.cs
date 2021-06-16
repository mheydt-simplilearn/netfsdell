using NUnit.Framework;
using System;

namespace Phase4_2_8_CodeCoverage.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void BasicAssertions()
        {
            int total = 100, marks1 = 60, marks2 = 75;
            string name = null;

            Assert.That(marks1, Is.Not.EqualTo(marks2));
            Assert.That(marks1, Is.LessThan(marks2));
            Assert.That(marks2, Is.InRange(50, 75));

            Assert.That(name, Is.Null);
        }

        [Test]
        public void Warnings()
        {
            int total = 100, marks1 = 60, marks2 = 75;
            string name = null;

            Warn.If(marks1 > 100);
            Warn.If(name == null);

            Warn.Unless(marks1 + marks2 < 200);

            Assert.Warn("This is a warning message");
        }

        [Test]
        public void ArrangeActAssert()
        {
            var calc = new Calculator();
            var answer = calc.add(5, 19);

            Assert.That(answer, Is.EqualTo(24));
        }

        [Test]
        public void MultipleAssertions()
        {
            int total = 100, marks1 = 60, marks2 = 75;
            string name = null;

            Assert.Multiple(() =>
            {
                Assert.That(marks1, Is.Not.EqualTo(marks2));
                Assert.That(marks1, Is.LessThan(marks2));
                Assert.That(marks2, Is.InRange(50, 75));
            });

        }

        [Test]
        public void Exceptions()
        {
            var calc = new Calculator();

            Assert.Throws<InvalidOperationException>(() => calc.addStrings("aaa", "Bbb"));
        }




    }

}
