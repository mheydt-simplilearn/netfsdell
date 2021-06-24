using Moq;
using NUnit.Framework;
using System;

namespace Phase4_2_11_MocksStubFakesAndMoles.Tests
{
    [TestFixture]
    public class Class1
    {


        [Test]
        public void Mocking()
        {
            int x = 9, y = 19;
            Mock<ICalculator> mockCalc = new Mock<ICalculator>();
            ICalculator calc = mockCalc.Object;
            var a = calc.add(1, 2);
            Assert.That(calc, Is.Not.Null);
        }

        [Test]
        public void Stub()
        {
            int x = 9, y = 19;
            Mock<ICalculator> mockCalc = new Mock<ICalculator>();
            mockCalc
                .Setup(c => c.add(It.IsAny<Int32>(), It.IsAny<Int32>()))
                .Returns(x + y);

            ICalculator calc = mockCalc.Object;
            var result = calc.add(x, y);
            Assert.That(result, Is.EqualTo(x + y));
        }

        [Test]
        public void Fake()
        {
            int x = 9, y = 19;
            FakeCalculator calc = new FakeCalculator();
            Assert.That(calc.add(x, y), Is.EqualTo(28));
        }

    }

}
