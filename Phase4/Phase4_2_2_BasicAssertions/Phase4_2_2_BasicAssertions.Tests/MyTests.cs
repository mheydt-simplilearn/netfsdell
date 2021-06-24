using NUnit.Framework;
using System;

namespace Phase4_2_2_BasicAssertions.Tests
{
    [TestFixture]
    public class MyTests
    {
        [Test]
        public void BasicAssertions()
        {
            // arrange
            int total = 100, marks1 = 60, marks2 = 75;
            string name = null;

            // assert
            Assert.That(marks1, Is.Not.EqualTo(marks2));
            Assert.That(marks1, Is.LessThan(marks2));
            Assert.That(marks2, Is.InRange(50, 75));
            Assert.That(name, Is.Null);
        }

        [Test]
        public void TestThatSumIsCorrect()
        {
            int total = 100, marks1 = 60, marks2 = 75;

            // act
            var sum = marks1 + marks2 + 1;

            // assert
            Assert.That(sum, Is.EqualTo(marks1 + marks2));
        }
    }

}
