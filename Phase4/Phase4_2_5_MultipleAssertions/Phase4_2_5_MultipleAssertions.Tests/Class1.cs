using NUnit.Framework;
using System;

namespace Phase4_2_5_MultipleAssertions.Tests
{
    [TestFixture]
    public class Class1
    {


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


    }

}
